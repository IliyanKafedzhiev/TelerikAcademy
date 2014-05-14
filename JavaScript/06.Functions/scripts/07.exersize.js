function isBigger(arr, index)
{
    if (index > 0 && index < arr.length - 1)
    {
        if ((arr[index - 1] < arr[index]) && (arr[index + 1] < arr[index]))
        {
            return true;
        }
    }
    return false;
}
function indexOfFirstBigger(arr)
{
    for (var i = 0; i < arr.length; i++)
    {
        if(isBigger(arr,i) === true)
        {
            return i;
        }
    }
    return -1;
}

var arr = [1, 2, 3, 4, 5, 3, 5, 1];
jsConsole.write("Index of first bigger is : " + indexOfFirstBigger(arr));