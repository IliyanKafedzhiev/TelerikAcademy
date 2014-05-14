
var sec = [3,2,3,4,2,2,4];
var maxLenght = 0;
var startIndex = 0;
var endIndex = 0;

var currElem = sec[0];
var curMaxLenght = 0;
var curStartIndex = 0;
var curEndIndex = 0;
for (var i = 0; i < sec.length; i++)
{
    if (currElem + 1 == sec[i])
    {
        currElem++;
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

