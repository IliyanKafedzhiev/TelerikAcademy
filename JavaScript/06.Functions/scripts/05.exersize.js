
function countOfElInArr(arr,elem)
{
    var cnt = 0;
    for (var i = 0; i < arr.length; i++)
    {
        if (arr[i] == elem)
        {
            cnt++;
        }
    }
    return cnt;
}

function Test()
{
    arr = [];
    for (var i = 0; i < 55; i++)
    {
        if (countOfElInArr(arr,5) != i)
        {
            return false;
        }
        arr.push(5);
    }
    return true;
}

jsConsole.write("Test for myFunc is " + Test());