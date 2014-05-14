

function onClickReadNum()
{
    var digit = jsConsole.readInteger("#r-integer");

    switch(digit)
    {
        case 1: jsConsole.write("one");
            break;
        case 2: jsConsole.write("two");
            break;
        case 3: jsConsole.write("three");
            break;
        case 4: jsConsole.write("four");
            break;
        case 5: jsConsole.write("five");
            break;
        case 6: jsConsole.write("six");
            break;
        case 7: jsConsole.write("seven");
            break;
        case 8: jsConsole.write("eight");
            break;
        case 9: jsConsole.write("nine");
            break;
        case 10: jsConsole.write("ten");
            break;
        case 0: jsConsole.write("zero");
            break;
        default: jsConsole.write("I can read only by ten");
    }

}