// Write a script that finds the most frequent number in an array.

var jsConsole;
var btn = document.getElementById('findNumber');
btn.onclick = findNumber;

function findNumber () {
	var array = jsConsole.read('#array').split(" ");
	array.sort();
	var currIndex = 0;
	var currLength = 0;
	var bestLength = 0;
	var bestElement = 0;

	for (var i = 0; i < array.length; i++) {
		if (array[i] == array[currIndex]) {
			currLength++;
		} else {
			currIndex = i;
			currLength = 1;
		}
		if (currLength > bestLength) {
			bestLength = currLength;
			bestElement = array[i];
		}
	}

	jsConsole.writeLine(bestElement + "(" + bestLength + " times)");
	console.log(bestElement + "(" + bestLength + " times)");
}