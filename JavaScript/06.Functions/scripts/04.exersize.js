function divCounter()
{
    var divs = document.getElementsByTagName("DIV");
    var cnt = 0;
    for (var indx in divs)
    {
        cnt++;
    }
    return divs.length;
}

jsConsole.write("Divs in current html page :" + divCounter());
