console.log("1.Write an expression that checks if given integer is odd or even");
var integer = 55;
var isOdd = (((integer % 2 == 0) ? false : true) == true) ? "Integer is Odd" : "Integer is Even";
console.log(integer, isOdd);
console.log("                                 ");


console.log("2.Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time");
var integerSecond = 35;
var canBeDevidedBy7and5 = ((integerSecond % 5 == 0) && (integerSecond % 7 == 0)) ? "Yes Integer can be devided by 7 and 5 without remainder" : "No Integer can't be devided by 7 and 5 without remainder";
console.log(integerSecond, canBeDevidedBy7and5);
console.log("                                 ");


console.log("3.Write an expression that calculates rectangle’s area by given width and height.");
var width = 10;
var height = 20;
var areaRectagle = width * height;
console.log("Area is " + areaRectagle);
console.log("           ");


console.log("4.Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.");
var integer = 1732;
var isThirdDigit7 = ((integer = (integer / 100) | 0) && (integer % 10 == 7)) ? "Yes Third digit is 7 " : "No";
console.log(integer, isThirdDigit7);
console.log("                                                 ");


console.log("5.Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.");
var integer = 4;
var mask = 4;
var isThirdBit1 = (integer = (integer | mask) && (integer == 4)) ? "Yes Third bit is 1 " : "No";
console.log(integer, isThirdBit1);
console.log("                                                 ");


//x - center_x)^2 + (y - center_y)^2 < radius^2
console.log("6.Write an expression that checks if given print (x,  y) is within a circle K(O, 5).");
var x = 2;
var y = 1;
var isPointInCircle = (((x * x) + (y * y)) < 25) ? "Yes " : "No";
console.log(x, ",", y, isPointInCircle);
console.log("                                                 ");


console.log("7.Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.");
var n = 41;
var n2 = ((n / 2) - 0.5) | 0;
var isPrime = true;
for (var i = n2; i > 1; i--)
{
    if (n % i == 0)
    {
        isPrime = false;
    }
}
console.log(n, " is " + ((isPrime) ? "Prime" : "Not Prime"));
console.log("                                                 ");


console.log("8.Write an expression that calculates trapezoid's area by given sides a and b and height h.");
var smallBase = 4.3;
var bigBase = 6.6;
var height = 2.987;
var trapezoidArea = ((smallBase + bigBase) / 2) * height;
console.log("Trapezoid Area is :" + trapezoidArea);
console.log("                                                 ");


//x - center_x)^2 + (y - center_y)^2 < radius^2
console.log("9.Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).");
var x = 2;
var y = 1;
var isPointInCircle = ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) < 9) ? true : false;
var isPointOutOfRectangle = !((x >= -1 && x <= 5 && y <= 1 && y >= -1) ? true : false);
if (isPointInCircle && isPointOutOfRectangle)
{
    console.log(x + "," + y + ":  Point is in figures");
}
else
{
    console.log(x + "," + y + ":  Point is not in figures");
}
console.log("                                                 ");