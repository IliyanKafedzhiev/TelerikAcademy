function reverseDigit(num)
{
    var result=num.toString();
    result = result.split("").reverse().join("");
    return parseInt(result);
}

jsConsole.write("Reverse number of 123456789 is " + reverseDigit(123456789));