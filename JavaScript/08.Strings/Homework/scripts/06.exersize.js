function extractContent(text)
{
    //regex gotten from stackoverflow - not universly perfect
    return text.replace(/<(?:"[^"]*"['"]*|'[^']*'['"]*|[^'">])+>/gi, '');
}

var text = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";
jsConsole.writeLine(text);