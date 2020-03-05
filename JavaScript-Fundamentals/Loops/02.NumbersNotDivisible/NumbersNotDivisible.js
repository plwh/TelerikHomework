// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var jsConsole;
var btn = document.getElementById('printNumbers');
btn.onclick = printNumbers;

function printNumbers () {
	var n = jsConsole.readInteger('#n');
	jsConsole.writeLine("Numbers from 1 to " + n + ", not divisble by 3 and 7 at the same time:");
	for (var i = 1; i <= n; i++) {
		if (i % 3 === 0 && i % 7 === 0) {
			continue;
		} else {
			jsConsole.writeLine(i);
		}
	}
}