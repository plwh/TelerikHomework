// Write a function to count the number of div elements on the web page

var jsConsole;

function numberOfDivs() {
var count = document.getElementsByTagName('div').length;
    return count;
}
jsConsole.writeLine('Number of divs in "index.html":' + numberOfDivs());
console.log('Number of divs in "index.html":' + numberOfDivs());