function OnClickPrintGreatest()
{
    var greatest = jsConsole.readFloat("#r-1");
    var b = jsConsole.readFloat("#r-2");
    var c = jsConsole.readFloat("#r-3");
    var d = jsConsole.readFloat("#r-4");
    var e = jsConsole.readFloat("#r-5");

    if (greatest < b)
    {
        greatest = b;
    }
    if (greatest < c)
    {
        greatest = c;
    }
    if (greatest< d)
    {
        greatest = d;
    }
    if (greatest < e)
    {
        greatest = e;
    }
    jsConsole.write("Greatest number of these is " + greatest);
    jsConsole.writeLine(" ");
}