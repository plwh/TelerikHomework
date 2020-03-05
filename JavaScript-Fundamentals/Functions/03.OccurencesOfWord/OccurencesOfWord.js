/* Write a function that finds all the occurrences of word in a text.
The search can be case sensitive or case insensitive.
Use function overloading. */

var jsConsole;
var text = 'The quick brown fox jumps over the lazy dog. Fox jumped over the lazy dog.', targetWord = 'fox';

jsConsole.writeLine('Sample text is:'+ text);
jsConsole.writeLine('Case sensitive search for word ' + '"' + targetWord + '"' + ':' + findOccurrences(text, targetWord) + ' occurrence(s).');
jsConsole.writeLine('Case insensitive search for word ' + '"' + targetWord + '"' + ':' + findOccurrences(text, targetWord, true) + ' occurrence(s).');

function findOccurrences(text, word, caseInsensitive) {
    var index = 0,
        count = 0;

    if (caseInsensitive) {
        word = word.toLowerCase();
        text = text.toLowerCase();
    }

    while (index != -1) {
        index = text.indexOf(word, index);

        if (index != -1) {
            index++;
            count++;
        }
    }
    return count;
}
