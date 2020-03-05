// Write an expression that checks if given point P(x, y) is within a circle K(O, 5).

var jsConsole;
var btn = document.getElementById('check');
var radius = 5;
btn.onclick = chkPointInCircle;

function chkPointInCircle() {
	var x = jsConsole.readFloat('#x');
	var y = jsConsole.readFloat('#y');
		
    if (Math.sqrt((x*x + y*y)) <= radius) {
        jsConsole.writeLine("The point is inside circle k(0,5)");
        console.log("The point is inside circle k(0,5)");
    } else {
        jsConsole.writeLine("The point is not inside circle k(0,5)");
        console.log("The point is not inside circle k(0,5)");
    }
}

