
var sec = [2, 1, 12, 3, 3, 2, 2, 2, 1];
var maxLenght = 0;
var startIndex = 0;
var endIndex = 0;

var currElem = sec[0];
var curMaxLenght = 0;
var curStartIndex = 0;
var curEndIndex = 0;
for (var i = 0; i < sec.length; i++)
{
    if (currElem == sec[i])
    {
        curMaxLenght++;
        curEndIndex = i;
    }
    else
    {
        curStartIndex = i;
        curEndIndex = i;
        currElem = sec[i];
        curMaxLenght = 1;
    }
    if (curMaxLenght > maxLenght)
    {
        maxLenght = curMaxLenght;
        startIndex = curStartIndex;
        endIndex = curEndIndex;
    }
}

for (var i = startIndex; i <= endIndex; i++)
{
    jsConsole.write(sec[i]);
    if (i != endIndex)
    {
        jsConsole.write(" , ");
    }
}

