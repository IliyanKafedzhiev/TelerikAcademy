String.prototype.checkForCorectlyExpression = function ()
{
    var myStr = this;
    var openBraces = 0;
    var closedBraces = 0;
    for (var i = 0; i < myStr.length; i++)
    {
        if (myStr[i] === '(')
        {
            openBraces++;

        }
        else if (myStr[i] === ')')
        {
            openBraces--;
        }
        if (openBraces < 0)
        {
            return false;
        }
    }
    if (openBraces != 0)
    {
        return false;
    }
    return true;
}

var myExpression = "((a+b)/5-d)";

jsConsole.writeLine("Is correct expression follow string :" + myExpression + " :" + myExpression.checkForCorectlyExpression().toString());

myExpression = ")(a+b))";

jsConsole.writeLine("Is correct expression follow string :" + myExpression + " :" + myExpression.checkForCorectlyExpression().toString());