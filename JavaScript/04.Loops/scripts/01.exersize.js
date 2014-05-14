function onClickReadNum()
{
    var digit = jsConsole.readInteger("#r-integer");


    for (var i = 1; i <= digit; i++)
    {
        jsConsole.write(i + " ");
    }
}