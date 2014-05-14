var sign;
var firstValue = 22;
var secondValue = 33;
var thirdValue = 2;

if (firstValue < 0)
{
    sign = '-';
    if (secondValue < 0)
    {
        sign = '+';
        if (thirdValue < 0)
        {
            sign = '-';
        }
    }
    else if (thirdValue < 0)
    {
        sign = '+';
    }

}
else
{
    sign = '+';
    if (secondValue < 0)
    {
        sign = '-';
        if (thirdValue < 0)
        {
            sign = '+';
        }
    }
    else if (thirdValue < 0)
    {
        sign = '-';
    }
}

console.log("Sign of Product of " + firstValue + "*" + secondValue + "*" + thirdValue + " = " + sign);
