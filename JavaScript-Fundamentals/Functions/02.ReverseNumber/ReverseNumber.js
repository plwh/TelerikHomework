// Write a function that returns the last digit of given integer as an English word.

var jsConsole;
var btn = document.getElementById('reverseNumber');
btn.onclick = reverseNumber;

function reverseNumber () {
	var input = jsConsole.readInteger('#n');
	var inputAsString = input.toString();
	var reversedNumber = [inputAsString.length];
	for (var i = 0, k = inputAsString.length-1; k>=0 ; i++,k--) {
		reversedNumber[i] = inputAsString [k];
	}
	
	jsConsole.writeLine("Reversed number is "+reversedNumber);
}

