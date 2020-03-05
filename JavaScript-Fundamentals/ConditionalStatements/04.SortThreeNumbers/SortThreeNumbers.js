// Sort 3 real values in descending order.
// Use nested if statements.

var jsConsole;
var btn = document.getElementById('sort');
btn.onclick = findBiggestOfThree;

function findBiggestOfThree() {
	var firstNumber = jsConsole.readFloat('#firstNumber');
	var secondNumber = jsConsole.readFloat('#secondNumber');
	var thirdNumber = jsConsole.readFloat('#thirdNumber');
	var temp = 0;

    if (firstNumber >= secondNumber) {
        if (thirdNumber > firstNumber) {
            temp = thirdNumber;
            thirdNumber = firstNumber;
            firstNumber = temp;
            if (thirdNumber > secondNumber) {
                temp = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = temp;
            }
        } else if (thirdNumber > secondNumber) {
            temp = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = temp;
        }
    } else {
        temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
        if (thirdNumber > firstNumber) {
            temp = thirdNumber;
            thirdNumber = firstNumber;
            firstNumber = temp;
            if (thirdNumber > secondNumber) {
                temp = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = temp;
            }
        } else if (thirdNumber > secondNumber) {
            temp = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = temp;
        }
    }

    jsConsole.writeLine("Numbers sorted: " + firstNumber + " " + secondNumber + " " + thirdNumber);
    console.log("Numbers sorted: " + firstNumber + " " + secondNumber + " " + thirdNumber);
}