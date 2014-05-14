var firstCharArr = ['a', 'b', 'c', 'd'];
var secondCharArr = ['a','b', 'c', 'd'];

for (var i = 0; (i < firstCharArr.length) && (i < secondCharArr.length); i++)
{
    if(firstCharArr[i] < secondCharArr[i])
    {
        jsConsole.writeLine(firstCharArr.toString() + " is < than " + secondCharArr.toString());
        break;
    }
    else if (firstCharArr[i] > secondCharArr[i])
    {
        jsConsole.writeLine(firstCharArr.toString() + " is > than " + secondCharArr.toString());
        break;
    }
    if ((firstCharArr.length == i + 1)&& (secondCharArr.length == i + 1))
    {
        jsConsole.writeLine(firstCharArr.toString() + " is equal to  " + secondCharArr.toString());
        break;
    }
    if ((firstCharArr.length == i + 1))
    {
        jsConsole.writeLine(firstCharArr.toString() + " is < than " + secondCharArr.toString());
        break;
    }
    if (secondCharArr.length == i + 1)
    {
        jsConsole.writeLine(firstCharArr.toString() + " is > than " + secondCharArr.toString());
        break;
    }
}