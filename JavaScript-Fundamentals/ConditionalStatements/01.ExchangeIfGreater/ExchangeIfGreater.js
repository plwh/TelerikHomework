// Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = exchangeIfGreater;

function exchangeIfGreater() {
	var firstNumber = jsConsole.readFloat('#firstNumber');
	var secondNumber = jsConsole.readFloat('#secondNumber');

	if (firstNumber > secondNumber){
		var temp = firstNumber;
		firstNumber = secondNumber;
		secondNumber = temp;
	}

	jsConsole.writeLine(firstNumber + " " + secondNumber);
	console.log(firstNumber + " " + secondNumber);
}
