function replaceTextBetweenTags(text)
{
    //transform text between tags
    var result = text.replace(/<upcase>(.*?)<\/upcase>/g, toUpper);
    result = result.replace(/<lowcase>(.*?)<\/lowcase>/g, toLower);
    result = result.replace(/<mixcase>(.*?)<\/mixcase>/g, toMixed);

    //delete tags
    result = result.replace(/<upcase>/gi, '');
    result = result.replace(/<\/upcase>/gi, '');
    result = result.replace(/<lowcase>/gi, '');
    result = result.replace(/<\/lowcase>/gi, '');
    result = result.replace(/<mixcase>/gi, '');
    result = result.replace(/<\/mixcase>/gi, '');

    return result;
}

//functions for text transforming
function toUpper(match) { return match.toUpperCase(); }
function toLower(match) { return match.toLowerCase(); }
function toMixed(match)
{
    var i = 0;
    var result = '';
    for (i = 0; i < match.length; i++)
    {
        if (Math.floor(Math.random() * 10 + 1) % 2 === 0)
        {
            result += match[i].toLowerCase();
        }
        else
        {
            result += match[i].toUpperCase();
        }
    }

    return result;
}

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

jsConsole.writeLine(replaceTextBetweenTags(text));