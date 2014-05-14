function onClickSolve()
{
    var a = jsConsole.readFloat("#r-a");
    var b = jsConsole.readFloat("#r-b");
    var c = jsConsole.readFloat("#r-c");
    if (a === 0)
    {
        jsConsole.write(((-c) / b));
        return;
    }
    var D = b * b - 4 * a * c;
    if (D === 0)
    {
        jsConsole.write("Two multiple roots" + ((-b) / (2 * a)));
        return;
    }
    if (D > 0)
    {
        var x1 = ((-b) + Math.sqrt(D)) / (2 * a);
        var x2 = ((-b) - Math.sqrt(D)) / (2 * a);
        jsConsole.write("Two roots x1=" + x1 + " and x2 = " + x2);
    }
    else
    {
        jsConsole.write("Equation has not solution");
    }
}