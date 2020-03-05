// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle
// R(top=1, left=-1, width=6, height=2).

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = chkPointInCircleOutRectangle;

function chkPointInCircleOutRectangle() {
	var x = jsConsole.readFloat('#x');
	var y = jsConsole.readFloat('#y');
		
    var inCircle = Math.sqrt((x*x) + (y*y)) <= 3;
    var outARectangle = ((x>-1 || x>5) && (y>-1 || y>1));

    var inCircleOutRectangle = inCircle && outARectangle;

    jsConsole.writeLine("Is point P("+ x + "," + y + ") in circle and out of the rectangle:"+ inCircleOutRectangle);
    console.log("Is point P("+ x + "," + y + ") in circle and out of the rectangle:"+ inCircleOutRectangle);
}


