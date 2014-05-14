var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
arr.sort();
var indexOfModa = 0;
var times = 1;

var curIndexModa=0;
var curTimes=0;
for (var i = 0; i < arr.length; i++)
{
    if (arr[i] == arr[curIndexModa])
    {
        curTimes++;
    }
    else
    {
        curIndexModa = i;
        curTimes = 1;
    }

    if (times < curTimes)
    {
        indexOfModa = curIndexModa;
        times = curTimes;
    }
}

jsConsole.write(arr[indexOfModa] + " (" + times + "times)");