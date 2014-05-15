function groupBy(arr, prpt)
{
    var groupedArr = [];

    var finalArray = [];

    if (prpt == "age")
    {

        var reppeatlessElements = []; //array with reppeatless elements

        for (var i = 0; i < arr.length; i++)
        {

            var reppeat = false; //checks if the element reppeats

            for (var j = 0; j < i; j++)
            {
                if (arr[i].age == arr[j].age)
                {
                    reppeat = true;
                    break; //if element reppeats break the iteration
                }
            }

            if (reppeat == false)
            { //if element does not reppeat push it to the reppeatless array
                reppeatlessElements.push(arr[i]);
            }
        }

        for (var i = 0; i < reppeatlessElements.length; i++)
        {
            var tempArr = [];

            for (var j = 0; j < arr.length; j++)
            {
                if (reppeatlessElements[i].age == arr[j].age)
                {
                    tempArr.push(arr[j]);
                    //console.log(reppeatlessElements[i]);
                    //console.log(arr[i]);
                }
            }
            groupedArr.push(tempArr);
        }

        for (var i = 0; i < groupedArr.length; i++)
        {
            finalArray.push({ Key: groupedArr[i][0].age, Value: groupedArr[i] });
        }

    }
    else // if prpt is "firstname"
    {
        var reppeatlessElements = []; //array with reppeatless elements

        for (var i = 0; i < arr.length; i++)
        {

            var reppeat = false; //checks if the element reppeats

            for (var j = 0; j < i; j++)
            {
                if (arr[i].firstname == arr[j].firstname)
                {
                    reppeat = true;
                    break; //if element reppeats break the iteration
                }
            }

            if (reppeat == false)
            { //if element does not reppeat push it to the reppeatless array
                reppeatlessElements.push(arr[i]);
            }
        }

        for (var i = 0; i < reppeatlessElements.length; i++)
        {
            var tempArr = [];

            for (var j = 0; j < arr.length; j++)
            {
                if (reppeatlessElements[i].firstname == arr[j].firstname)
                {
                    tempArr.push(arr[j]);
                }
            }
            groupedArr.push(tempArr);
        }

        for (var i = 0; i < groupedArr.length; i++)
        {
            finalArray.push({ Key: groupedArr[i][0].firstname, Value: groupedArr[i] });
        }
    }

    return finalArray;
}
var persons = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Pesho', lastname: 'Petrov', age: 3 },
  { firstname: "Bay", lastname: "Ivan", age: 12 },
  { firstname: "Bay", lastname: "Ivan", age: 80 },
  { firstname: "Bay", lastname: "Ivan", age: 33 },
  { firstname: "sad", lastname: "dsadd", age: 32 },
  { firstname: "Gosdddddddddho", lastname: "Peaaatrov", age: 32 }, ];


jsConsole.writeLine("grouprd by age");

var a = groupBy(persons, "age");

for (var i in a)
{
    jsConsole.writeLine(a[i]);
}

jsConsole.writeLine("grouprd by firstname");

var b = groupBy(persons, "firstname");

for (var i in b)
{
    jsConsole.writeLine(b[i]);
}