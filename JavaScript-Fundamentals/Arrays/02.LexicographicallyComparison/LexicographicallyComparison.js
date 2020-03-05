// Write a script that compares two char arrays lexicographically (letter by letter).

var jsConsole;
var btn = document.getElementById('compareArrays');
btn.onclick = compareArrays;

function compareArrays () {
	var firstArray = jsConsole.read('#firstArray').split(" ");
	var secondArray = jsConsole.read('#secondArray').split(" ");

	var isEqual = true;
	if (firstArray.length == secondArray.length) {
		for (var i = 0; i < firstArray.length; i++) {
			if (firstArray[i] != secondArray[i]) {
				isEqual = false;
				break;
			}
		}
	} else {
		isEqual = true;
	}

	jsConsole.writeLine("Are two char arrays equal? " + (isEqual ? "Yes" : "No"));
	console.log("Are two char arrays equal? " + (isEqual ? "Yes" : "No"));
}
