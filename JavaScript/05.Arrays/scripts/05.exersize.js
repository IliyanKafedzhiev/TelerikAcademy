
var arr = [32, 4, 2, 32, 3, 21, 321, 43, 2, 13, 12, 321, 3, 21, 232343, 25, 43, 6];
var sortedArr = [];
var min,tmp;
for (var i = 0; i < arr.length; i++)
{
    min = i;
    for (var j = i+1; j < arr.length; j++)
    {
        if (arr[min] > arr[j])
        {
            min = j;
        }
    }
    tmp = arr[i];
    arr[i] = arr[min];
    arr[min] = tmp;
}

jsConsole.write(arr.join(" ,"));