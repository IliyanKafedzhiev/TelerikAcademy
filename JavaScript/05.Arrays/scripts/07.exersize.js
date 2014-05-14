var sortedArr = [1, 2, 4, 5, 8, 9, 12, 14, 16, 18, 19, 21, 22, 25, 26];

function binarySearch(from, to, searchedElem)
{
    if (to > from)
    {
        var middle = ((from + to) / 2) | 0;
        if (sortedArr[middle] == searchedElem)
        {
            return middle;
        }
        else
        {
            if (sortedArr[middle] < searchedElem)
            {
                return binarySearch(middle + 1, to, searchedElem);
            }
            else
            {
                return binarySearch(from, middle, searchedElem);
            }
        }
    }
    else
    {
        if (sortedArr[to] == searchedElem)
        {
            return to;
        }
        else
        {
            return -1;
        }
    }
}

jsConsole.write("index of elem 21 is " + binarySearch(0, sortedArr.length - 1, 21));