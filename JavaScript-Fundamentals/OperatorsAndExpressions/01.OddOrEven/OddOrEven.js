// Write an expression that checks if given integer is odd or even.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = chkNumber;

function chkNumber() {
	var number = jsConsole.readInteger('#input');
	if (number % 2 === 0){
		jsConsole.writeLine("Number is even");
	}
	else{
		jsConsole.writeLine("Number is odd");
	}
}
