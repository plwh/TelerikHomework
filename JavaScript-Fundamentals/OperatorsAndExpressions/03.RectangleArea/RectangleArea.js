// Write an expression that calculates rectangle’s area by given width and height.

var jsConsole;
var btn = document.getElementById('calc');
btn.onclick = calcArea;

function calcArea() {
	var height = jsConsole.readFloat('#height');
	var width = jsConsole.readFloat('#width');

	jsConsole.writeLine("Area of rectangle is:" + width*height);
	console.log("Area of rectangle is:" + width*height);
}

