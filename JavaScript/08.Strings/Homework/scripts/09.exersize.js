function extractEmails(text)
{
    var words = new Array();
    var emails = new Array();

    words = text.split(' ');

    var i = 0;
    for (i = 0; i < words.length; i++)
    {
        if (words[i].match(/(.*)[@](.*)[.](.*)/gi))
        {
            emails.push(words[i]);
        }
    }

    return emails;
}

var text = "Hello iliyan@gmail.com myemial";
jsConsole.writeLine(extractEmails(text).join(" ,"));