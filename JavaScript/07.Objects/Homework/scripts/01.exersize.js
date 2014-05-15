function Point(x, y)
{
    this.x = x;
    this.y = y;
    this.toString = function () { return " Point(" + this.x + "," + this.y + ") ";};
}

function Line(startPoint, endPoint)
{
    this.startPoint = startPoint;
    this.endPoint = endPoint;
    this.distance = function ()
    {
        return Math.sqrt(Math.pow((endPoint.x - startPoint.x), 2) + Math.pow((endPoint.y - startPoint.y), 2));
    };
    this.toString = function()
    {
        return "Line(" + this.startPoint + " ," + this.endPoint + ")";
    }
}

function canFormTriangle(firstLine,secondLine,thirdLine)
{
    var slopeFirstLine = (firstLine.endPoint.y - firstLine.startPoint.y) / (firstLine.endPoint.x - firstLine.startPoint.x);
    var slopeSecondLine = (secondLine.endPoint.y - secondLine.startPoint.y) / (secondLine.endPoint.x - secondLine.startPoint.x);
    var slopeThirdLine = (thirdLine.endPoint.y - thirdLine.startPoint.y) / (thirdLine.endPoint.x - thirdLine.startPoint.x);

    if (slopeFirstLine == slopeSecondLine || slopeFirstLine == slopeThirdLine
         || slopeSecondLine == slopeThirdLine)
    {
        return false;
    }
    return true;
}

var firstPoint = new Point(1, -1.1);
var secondPoint = new Point(5, 2);
var thirdPoint = new Point(4, -1.23);
var fourthPoint = new Point(6, 2.2);
var fivethPoint = new Point(7, -13);
var sixthPoint = new Point(8, 2.13);

var firstLine = new Line(firstPoint, secondPoint);
var secondLine = new Line(thirdPoint, fourthPoint);
var thirdLine = new Line(fivethPoint, sixthPoint);

jsConsole.writeLine(firstLine + "Distance :" + firstLine.distance());
jsConsole.writeLine(firstLine + secondLine + thirdLine + "can form triangle :" + canFormTriangle(firstLine, secondLine, thirdLine).toString());

