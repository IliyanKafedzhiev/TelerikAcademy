//uses simple regex
function replaceWhiteSpace(text)
{
    return text.replace(/\s/g, '&nbsp;');
}

var test = "Hello   My Text ";

jsConsole.writeLine(replaceWhiteSpace(text));