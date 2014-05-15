Array.prototype.remove = function (val)
{
    for (var i in this)
    {
        if (val === this[i])
        {
            this.splice(i, 1);
        }
    }
    
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

arr.remove(1);

jsConsole.write(arr.join(" ,").toString());