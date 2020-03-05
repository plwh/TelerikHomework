// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = chkNumber;

function chkNumber() {
	var number = jsConsole.readInteger('#input');
	var thirdDigit = Math.floor(number/100) % 10;
	var isSeven = (thirdDigit === 7);

	jsConsole.writeLine("Is third digit from right to left 7? " + isSeven );
	console.log("Is third digit from right to left 7? " + isSeven );
}

