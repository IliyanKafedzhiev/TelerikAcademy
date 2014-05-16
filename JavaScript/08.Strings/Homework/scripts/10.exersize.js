//get palindromes
function extractPalindromes(text)
{
    //split to words
    var words = text.split(' ');
    var palindromes = new Array();

    var i = 0;
    //check every word
    for (i = 0; i < words.length; i++)
    {
        // if curr word === reversed curr word
        if (words[i] === words[i].split('').reverse().join(''))
        {
            palindromes.push(words[i]);
        }
    }

    return palindromes;
}

var text = " Hello AbbA and some weekkeew";

jsConsole.writeLine(extractPalindromes(text).join(" ,"));