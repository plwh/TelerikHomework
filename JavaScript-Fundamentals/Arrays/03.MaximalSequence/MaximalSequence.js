// Write a script that finds the maximal sequence of equal elements in an array.

var jsConsole;
var btn = document.getElementById('findMaxSequence');
btn.onclick = findMaximalSequence;

function findMaximalSequence () {
	var array = jsConsole.read('#array').split(" ");

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

	for (var j = 0; j < bestLength; j++){
		jsConsole.write(bestElement + " ");
		console.log(bestElement + " ");
	}

}