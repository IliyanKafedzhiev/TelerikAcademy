function onButtonClick()
{
	var myWindows = window;
	var browser = myWindows.navigator.appCodeName;
	var isMozila =( browser == "Mozilla");
	if (isMozila)
	{
		alert("Yes");
	}
	else
	{
		alert("No");
	}
}
