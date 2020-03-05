// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

var jsConsole;
var btn = document.getElementById('showDigit');
btn.onclick = showDigit;

function showDigit() {
	var digit = jsConsole.readFloat('#digit');
	switch (digit) {
		case 1:
			jsConsole.writeLine("one");
			console.log("one");
			break;
		case 2:
			jsConsole.writeLine("two");
			console.log("two");
			break;
		case 3:
			jsConsole.writeLine("three");
			console.log("three");
			break;
		case 4:
			jsConsole.writeLine("four");
			console.log("four");
			break;
		case 5:
			jsConsole.writeLine("five");
			console.log("five");
			break;
		case 6:
			jsConsole.writeLine("six");
			console.log("six");
			break;
		case 7:
			jsConsole.writeLine("seven");
			console.log("seven");
			break;
		case 8:
			jsConsole.writeLine("eight");
			console.log("eight");
			break;
		case 9:
			jsConsole.writeLine("nine");
			console.log("nine");
			break;
		default:
			jsConsole.writeLine("not a digit");
			console.log("not a digit");
	}
}
