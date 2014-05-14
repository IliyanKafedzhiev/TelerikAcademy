var Best;
var firstValue = 22;
var secondValue = 33;
var thirdValue = 2;

Best = firstValue;

if (Best < secondValue)
{
    Best = secondValue;
}
if (Best < thirdValue)
{
    Best = thirdValue;
}

console.log("Bigger Value is : "+Best);