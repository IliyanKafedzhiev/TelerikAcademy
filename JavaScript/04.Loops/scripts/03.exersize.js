
var sec = [321,1, 2, 3, 4, 5, 6, 7, 8, 9, 10,-44,2];
var min = sec[0];
var max = sec[0];

for (var index in sec)
{
    if (sec[index] > max)
    {
        max = sec[index];
    }
    if (sec[index] < min)
    {
        min = sec[index];
    }
}
jsConsole.write("Max is :" + max + "<br/>" + "Min is :" + min);
