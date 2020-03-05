// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = getMultiplicationSign;

function getMultiplicationSign() {
	var firstNumber = jsConsole.readFloat('#firstNumber');
	var secondNumber = jsConsole.readFloat('#secondNumber');
	var thirdNumber = jsConsole.readFloat('#thirdNumber');
	var product = firstNumber * secondNumber * thirdNumber;

	if (product < 0) {
		jsConsole.writeLine("Multiplication sign is -");
		console.log("Multiplication sign is -");
	} else if (product > 0) {
		jsConsole.writeLine("Multiplication sign is +");
		console.log("Multiplication sign is +");
	} else {
		jsConsole.writeLine("Multiplication sign is 0");
		console.log("Multiplication sign is 0");
	}	
}