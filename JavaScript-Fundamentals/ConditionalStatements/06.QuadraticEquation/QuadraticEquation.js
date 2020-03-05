// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.

var jsConsole;
var btn = document.getElementById('solve');
btn.onclick = solveEquation;

function solveEquation () {
	var a = jsConsole.readFloat('#firstNumber');
	var b= jsConsole.readFloat('#secondNumber');
	var c = jsConsole.readFloat('#thirdNumber');
	var D = b * b - 4 * a * c;

	if (a === 0){
		alert(" \"a cannot be zero");
		return;
	}

	if(D < 0){
		jsConsole.writeLine("Equation has no real roots");
	} else if (D === 0) {
		jsConsole.writeLine("There are two equal roots - x1=x2="+ (-b) / (2 * a));
	} else {
		jsConsole.writeLine("There are two roots - x1=" + (-b + Math.sqrt(D))/(2 * a) + "; x2=" + (-b - Math.sqrt(D))/(2*a));
	}
}