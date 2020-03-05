// Write a script that finds the maximal increasing sequence in an array.

var jsConsole;
var btn = document.getElementById('findMaxIncreasingSequence');
btn.onclick = findMaxIncreasingSequence;

function findMaxIncreasingSequence () {
	var array = jsConsole.read('#array').split(" ");

	var maxstart = 0;
	var max = 1;
	var start = 0;

	for (var i = 0; i < array.length; i++) {
		if (array[i] > array[i - 1]) {
			if (i - start + 1 > max) {
				max = i - start + 1;
				maxstart = start;
			}
		} else {
			start = i;
		}
	}

	for (var j = 0; j < max; j++) {
		jsConsole.write(array[maxstart + j] + " ");
		console.log(array[maxstart + j] + " ");
	}
}