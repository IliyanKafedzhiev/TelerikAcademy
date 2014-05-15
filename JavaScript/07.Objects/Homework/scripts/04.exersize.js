function hasProperty(obj,searchedProperty)
{
    for (var prop in obj)
    {
        if (prop === searchedProperty)
        {
            return true;
        }
    }
    return false;
}

var obj = {
    type: "unknown",
    run: function ()
    {
        console.log("function");
    }
}

jsConsole.writeLine("Has property someProp :" + hasProperty(obj, "someProp"));
jsConsole.writeLine("Has property type :" + hasProperty(obj, "type"));