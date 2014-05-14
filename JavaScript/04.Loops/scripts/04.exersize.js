var objects = [document, window, navigator];
for (var index in objects)
{
    var obj = objects[index];
    var smallestProp = "activeElement";
    var largestProp = "activeElement";
    for (var prop in obj)
    {
        if (prop > largestProp)
        {
            largestProp = prop;
        }
        if (prop < smallestProp)
        {
            smallestProp = prop;
        }
    }
    jsConsole.writeLine("Smallest Property in " + objects[index].toString() + " is :" + smallestProp);
    jsConsole.writeLine("Largest Property in " + objects[index].toString() + " is :" + largestProp);
}
