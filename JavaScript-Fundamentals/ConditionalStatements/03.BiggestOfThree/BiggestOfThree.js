// Write a script that finds the biggest of three numbers.
// Use nested if statements.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = findBiggestOfThree;

function findBiggestOfThree() {
	var firstNumber = jsConsole.readFloat('#firstNumber');
	var secondNumber = jsConsole.readFloat('#secondNumber');
	var thirdNumber = jsConsole.readFloat('#thirdNumber');
	var biggest = 0;

	if (firstNumber >= secondNumber) {
		biggest = firstNumber;
        if (firstNumber < thirdNumber) {
        	biggest = thirdNumber;
        }
    } else if (firstNumber < secondNumber) {
    	biggest = secondNumber;
    	if (thirdNumber > secondNumber) {
    		biggest = thirdNumber;
    	}
    }

    jsConsole.writeLine("The biggest number is " + biggest);
    console.log("The biggest number is " + biggest);
}