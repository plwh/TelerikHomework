// Write an expression that calculates trapezoid's area by given sides a and b and height h.

var jsConsole;
var btn = document.getElementById('calc');
btn.onclick = calcArea;

function calcArea() {
	var sideA = jsConsole.readFloat('#a');
	var sideB = jsConsole.readFloat('#b');
	var height = jsConsole.readFloat('#height');
	
	jsConsole.writeLine("Area of trapezoid is:" + (sideA+sideB)/2*height);
	console.log("Area of trapezoid is:" +  (sideA+sideB)/2*height);
}

