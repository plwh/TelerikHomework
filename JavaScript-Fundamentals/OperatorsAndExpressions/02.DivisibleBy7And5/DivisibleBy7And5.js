// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = chkNumber;

function chkNumber() {
	var number = jsConsole.readInteger('#input');
	if (number % 35 === 0){
		jsConsole.writeLine("Number " + number + " can be divided by 7 and 5 at the same time.");
		console.log("Number " + number + " can be divided by 7 and 5 at the same time.");
	}
	else{
		jsConsole.writeLine("Number " + number + " can\'t be divided by 7 and 5 at the same time.");
		console.log("Number " + number + " can\'t be divided by 7 and 5 at the same time.");
	}
}

