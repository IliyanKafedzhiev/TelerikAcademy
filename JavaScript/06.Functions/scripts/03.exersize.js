var text = "As they rounded a bend in the path that ran beside the And river, Lara recognized the silhouette of a fig tree atop a nearby hill. The weather was hot and the days were long. The fig tree was in full leaf, but not yet bearing fruit.";
var wordToSearch = "and";
var isCaseSensitive = false;

function CountOccurenceWord(text, wordToSearch, isCaseSensitive)
{
    isCaseSensitive = isCaseSensitive || false;
    var countSearchedWord = 0;

    if (isCaseSensitive === false)
    {
        text =text.toLocaleLowerCase();
        var strArr = text.split(wordToSearch.toLowerCase()); //split is case-insensitive

        for (var str in strArr)
        {
            countSearchedWord++;
        }
        --countSearchedWord;
        jsConsole.writeLine("The count of word '" + wordToSearch + "' (case-insensitive search)  is: " + countSearchedWord)
    }
    else
    {
        var index = text.indexOf(wordToSearch);//indexOf is case-sensitive

        while (index >= 0)
        {
            countSearchedWord++;
            index = text.indexOf(wordToSearch, index + 1);
        }
        jsConsole.writeLine("The count of word '" + wordToSearch + "' (case-sensitive search)  is: " + countSearchedWord)
    }
}

CountOccurenceWord(text,wordToSearch, true);
CountOccurenceWord(text,wordToSearch);
