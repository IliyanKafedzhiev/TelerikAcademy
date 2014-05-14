
function FillResultWithOneNum(firstNum)
{
    switch (firstNum)
    {
        case 0:
            jsConsole.write( "Zero");
            break;
        case 1:
            jsConsole.write( "One");
            break;
        case 2:
            jsConsole.write( "Two");
            break;
        case 3:
            jsConsole.write( "Three");
            break;
        case 4:
            jsConsole.write( "Four");
            break;
        case 5:
            jsConsole.write( "Five");
            break;
        case 6:
            jsConsole.write( "Six");
            break;
        case 7:
            jsConsole.write( "Seven");
        case 8:
            jsConsole.write( "Eight");
            break;
        case 9:
            jsConsole.write( "Nine");
            break;
        default:
            break;
    }
}

function FillResultWithTwoNum(firstNum, secondNum)
{
    if (secondNum == 1)
    {
        switch (firstNum)
        {
            case 0:
                jsConsole.write( "Ten");
                break;
            case 1:
                jsConsole.write( "Eleven");
                break;
            case 2:
                jsConsole.write( "Twelve");
                break;
            case 3:
                jsConsole.write( "Thirteen");
                break;
            case 4:
                jsConsole.write( "Fourteen");
                break;
            case 5:
                jsConsole.write( "Fifteen");
                break;
            case 6:
                jsConsole.write( "Sixteen");
                break;
            case 7:
                jsConsole.write( "Seventeen");
                break;
            case 8:
                jsConsole.write( "Eighteen");
                break;
            case 9:
                jsConsole.write( "Nineteen");
                break;
            default:
                break;
        }
    } else
    {
        switch (secondNum)
        {
            case 2:
                jsConsole.write( "Twenty ");
                break;
            case 3:
                jsConsole.write( "Thirty ");
                break;
            case 4:
                jsConsole.write( "Forty ");
                break;
            case 5:
                jsConsole.write( "Fifty ");
                break;
            case 6:
                jsConsole.write( "Sixty ");
                break;
            case 7:
                jsConsole.write( "Seventy ");
                break;
            case 8:
                jsConsole.write( "Eighty ");
                break;
            case 9:
                jsConsole.write( "Ninety ");
                break;
            default:
                break;
        }
        if (firstNum != 0)
        {
            FillResultWithOneNum(firstNum);
        }
        
    }
}

function OnClickTalk()
{
    var myNum = jsConsole.readInteger("#r-a");
    
    var firstNum = myNum % 10;
    myNum = ((myNum / 10)) | 0;
    var secondNum;
    var thirdNum;
    if (myNum > 0)
    {
        secondNum = myNum % 10;
        myNum = ((myNum / 10))|0;
        if (myNum > 0)
        {
            thirdNum = myNum % 10;
        }
    }

    if (secondNum == undefined)
    {
        FillResultWithOneNum(firstNum);

    } else if (thirdNum == undefined)
    {
        FillResultWithTwoNum(firstNum, secondNum);
    }
    else
    {
        FillResultWithOneNum(thirdNum);
        jsConsole.write( " hundred ");
        if (firstNum != 0 && secondNum == 0)
        {
            jsConsole.write( " and ");
            FillResultWithOneNum(firstNum);
        }
        else if (secondNum !=0)
        {
            jsConsole.write( " and ");
            FillResultWithTwoNum(firstNum,secondNum);
        }
    }
    jsConsole.writeLine(" ");
}