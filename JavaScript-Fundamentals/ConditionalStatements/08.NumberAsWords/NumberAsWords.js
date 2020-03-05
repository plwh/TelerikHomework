// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var jsConsole;
var btn = document.getElementById('showNumber');
btn.onclick = showNumber;

function showNumber() {
    var input = jsConsole.readInteger('#input');

    if (input < 0 || input > 999) {
        alert('Number should be between 0 and 999!');
        return;
    }

    var hundreds = Math.floor( input / 100);
    var tens = Math.floor(input / 10)% 10;
    var units = input % 10;
    var teens = 10 + units;
    var teensText = "";
    var hundredsText = "";
    var tensText = "";
    var unitsText = "";

    switch (teens) {
        case 11:
            teensText = "eleven";
            break;
        case 12:
            teensText = "twelve";
            break;
        case 13:
            teensText = "thirteen";
            break;
        case 14:
            teensText = "fourteen";
            break;
        case 15:
            teensText = "fifteen";
            break;
        case 16:
            teensText = "sixteen";
            break;
        case 17:
            teensText = "seventeen";
            break;
        case 18:
            teensText = "eighteen";
            break;
        case 19:
            teensText = "nineteen";
            break;
    }

    switch (hundreds) {
        case 1:
            hundredsText = 'one hundred';
            break;
        case 2:
            hundredsText = 'two hundred';
            break;
        case 3:
            hundredsText = 'three hundred';
            break;
        case 4:
            hundredsText = 'four hundred';
            break;
        case 5:
            hundredsText = 'five hundred';
            break;
        case 6:
            hundredsText = 'six hundred';
            break;
        case 7:
            hundredsText = 'seven hundred';
            break;
        case 8:
            hundredsText = 'eight hundred';
            break;
        case 9:
            hundredsText = 'nine hundred';
            break;
        case 0:
            hundredsText = '';
            break;
    }

    if (input % 100 !== 0 && input >= 100) {
        hundredsText = hundredsText + ' and ';
    }

    if (tens === 1 && units > 0) {
        jsConsole.writeLine(hundredsText + teensText);
        console.log(hundredsText + teensText);
        hundredsText = '';
        tensText = '';
    }

    switch (tens) {
        case 1:
            tensText = 'ten';
            break;
        case 2:
            tensText = 'twenty';
            break;
        case 3:
            tensText = 'thirty';
            break;
        case 4:
            tensText = 'forty';
            break;
        case 5:
            tensText = 'fifty';
            break;
        case 6:
            tensText = 'sixty';
            break;
        case 7:
            tensText = 'seventy';
            break;
        case 8:
            tensText = 'eighty';
            break;
        case 9:
            tensText = 'ninety';
            break;
        case 0:
            tensText = '';
            break;
    }

    switch (units) {
        case 1:
            unitsText = 'one';
            break;
        case 2:
            unitsText = 'two';
            break;
        case 3:
            unitsText = 'three';
            break;
        case 4:
            unitsText = 'four';
            break;
        case 5:
            unitsText = 'five';
            break;
        case 6:
            unitsText = 'six';
            break;
        case 7:
            unitsText = 'seven';
            break;
        case 8:
            unitsText = 'eight';
            break;
        case 9:
            unitsText = 'nine';
            break;
        default:
            unitsText = '';
            break;
    }

    if (input === 0) {
        jsConsole.writeLine('zero');
        console.log('zero');
        hundredsText = '';
        tensText = '';
        unitsText = '';
    }
    if (input <= 10 || input >= 20) {
        jsConsole.writeLine(hundredsText + tensText + ' ' + unitsText);
        console.log(hundredsText + tensText + ' ' + unitsText);
    }
}