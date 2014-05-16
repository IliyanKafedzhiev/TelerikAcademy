String.prototype.reverse = function()
{
    return this.split("").reverse().join("")
}

var myStr = "Hello World";
jsConsole.writeLine(myStr.reverse())