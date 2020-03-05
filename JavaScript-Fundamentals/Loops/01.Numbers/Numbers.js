// Write a script that prints all the numbers from 1 to N.

var jsConsole;
var btn = document.getElementById('printNumbers');
btn.onclick = printNumbers;

function printNumbers () {
	var n = jsConsole.readInteger('#n');
	jsConsole.writeLine("Numbers from 1 to " + n + ":");
	for (var i = 1; i <= n; i++) {
		jsConsole.writeLine(i);
	}
}