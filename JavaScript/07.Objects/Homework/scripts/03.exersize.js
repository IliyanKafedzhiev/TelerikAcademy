function deepCopy(obj)
{
    if (typeof (obj) != "object" || obj == null)
    {
        return obj;
    }
    else
    {
        var copy = obj.constructor();
        for (var prop in obj)
        {
            copy[prop] = deepCopy(obj[prop]);
        }
        return copy;
    }
}

var iliyan = {
    name: "Iliyan",
    hair: {
        color: "brown",
        type: "streight",
        toString: function ()
        {
            return "Hair type(" + this.color + " ," + this.type + ") ";
        }
    },
    toString: function ()
    {
        return this.name + " :" + this.hair.toString();
    }
}

jsConsole.writeLine(iliyan.toString());
var copyOfIliyan = deepCopy(iliyan);
copyOfIliyan.name = "Copy of Iliyan";
copyOfIliyan.hair.color = "red";
copyOfIliyan.hair.type = "curly";
jsConsole.writeLine("Modified :" + copyOfIliyan.toString());

jsConsole.writeLine("Old Value :" + iliyan.toString());

