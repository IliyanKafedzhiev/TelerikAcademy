//target match
function replaceAnchor(text)
{
    return text.replace(/<a(.*)>(.*)<\/a>/gi, replaceTag);
}

//tag replace
function replaceTag(match)
{
    match = match.replace(/<a/gi, '[URL');
    match = match.replace(/>/gi, ']');
    match = match.replace(/<\/a/gi, '[/URL');
    return match;
}

var text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

jsConsole.writeLine(replaceAnchor(text));