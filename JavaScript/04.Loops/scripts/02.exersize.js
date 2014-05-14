function onClickReadNum()
{
    var digit = jsConsole.readInteger("#r-integer");


    for (var i = 1; i <= digit; i++)
    {
        if (i % 3 != 0 && i%7 != 0)
        {
            jsConsole.write(i + " ");
        }
    }
}