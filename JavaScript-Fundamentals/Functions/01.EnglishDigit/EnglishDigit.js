// Write a function that returns the last digit of given integer as an English word.

var jsConsole;
var btn = document.getElementById('returnDigit');
btn.onclick = returnDigit;

function returnDigit () {
	var input = jsConsole.readInteger('#n');
	var lastDigit = input % 10;
	switch (lastDigit) {
		case 0:
			jsConsole.writeLine("zero");
			console.log("zero");
			break;
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

