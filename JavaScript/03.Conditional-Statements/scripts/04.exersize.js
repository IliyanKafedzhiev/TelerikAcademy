var a = [];
a[1] = 3;
a[2] = 1;
a[3] = 2;

if (a[1] < a[2])
{
    var tmp = a[1];
    a[1] = a[2];
    a[2] = tmp;
    if (a[2] < a[3])
    {
        var tmp = a[3];
        a[3] = a[2];
        a[2] = tmp;
        if (a[1] < a[2])
        {
            var tmp = a[1];
            a[1] = a[2];
            a[2] = tmp;
        }
    }
    else
    {
        if (a[2] < a[3])
        {
            var tmp = a[1];
            a[1] = a[2];
            a[2] = tmp;
        }
    }
}
else
{
    if (a[2] < a[3])
    {
        var tmp = a[3];
        a[3] = a[2];
        a[2] = tmp;
        if (a[1] < a[2])
        {
            var tmp = a[1];
            a[1] = a[2];
            a[2] = tmp;
        }
    }
}

console.log("nums in Decreasing order");
for (var i = 1; i < 4; i++)
{
    console.log(a[i]);
}