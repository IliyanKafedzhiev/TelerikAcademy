function isBigger(arr,index)
{
    if (index > 0 && index < arr.length-1)
    {
        if ((arr[index - 1] < arr[index]) && (arr[index + 1] < arr[index]))
        {
            return true;
        }
    }
    return false;
}

var arr = [1,2,3,4,5,3,5,1];
jsConsole.write("Is elem at position 4 bigger than  its neighbors " + isBigger(arr, 4));