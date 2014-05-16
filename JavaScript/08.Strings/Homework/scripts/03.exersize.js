String.prototype.countSubString = function(substr)
{
    substr = substr.toLowerCase();
    var copyOfString = this;

    copyOfString = copyOfString.toLowerCase();

    var index = copyOfString.indexOf(substr, 0);
    var counter = 0;
    while (index != -1)
    {
        counter++;
        index = copyOfString.indexOf(substr, index + 1);
    }
    return counter;
}

var string = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
var substr = "in";

jsConsole.writeLine(string.countSubString(substr));
