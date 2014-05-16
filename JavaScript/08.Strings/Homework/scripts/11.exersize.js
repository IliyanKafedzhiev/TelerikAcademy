function stringFormat(format)
{
    var i = 0;

    for (i = 0; i < 30; i++)
    {
        var regex = new RegExp("[{]" + i + "[}]", "gi");
        format = format.replace(regex, arguments[i + 1]);
    }

    return format;
}

var frmt = '{0}, {1}, {0} text {2}';
var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
jsConsole.writeLine(str);