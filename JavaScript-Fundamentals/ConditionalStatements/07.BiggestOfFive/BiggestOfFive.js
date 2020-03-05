// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = findBiggestOfThree;

function findBiggestOfThree() {
	var firstNumber = jsConsole.readFloat('#firstNumber');
	var secondNumber = jsConsole.readFloat('#secondNumber');
	var thirdNumber = jsConsole.readFloat('#thirdNumber');
    var fourthNumber = jsConsole.readFloat('#fourthNumber');
    var fifthNumber = jsConsole.readFloat('#fifthNumber');
	var biggest = 0;

	if (firstNumber >= secondNumber) {
		biggest = firstNumber;
        if (firstNumber < thirdNumber) {
            biggest = thirdNumber;
            biggest = (fourthNumber > thirdNumber) ? fourthNumber : thirdNumber;
            biggest = (biggest > fifthNumber) ? biggest : fifthNumber;
        } else {
            if (fourthNumber > firstNumber){
                biggest = fourthNumber;
                biggest = (biggest > fifthNumber) ? biggest : fifthNumber;
            } else {
                biggest = (fifthNumber > firstNumber) ? fifthNumber : firstNumber;
            }
        }
    } else {
        biggest = secondNumber;
        if (thirdNumber > secondNumber) {
            biggest = thirdNumber;
            biggest = (fourthNumber > thirdNumber) ? fourthNumber : thirdNumber;
            biggest = (biggest > fifthNumber) ? biggest : fifthNumber;
        } else {
            if (fourthNumber > secondNumber) {
                biggest = fourthNumber;
                biggest = (biggest > fifthNumber) ? biggest : fifthNumber;
            } else {
                biggest = (fifthNumber > secondNumber) ? fifthNumber : secondNumber;
            }
        }
    }

    jsConsole.writeLine("The biggest number is " + biggest);
    console.log("The biggest number is " + biggest);
}