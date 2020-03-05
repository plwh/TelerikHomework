// Write a script that finds the max and min number from a sequence of numbers.

var jsConsole;
var btn = document.getElementById('findMinMax');
btn.onclick = findMinAndMax;


function sequenceNumbers() {
	var sequence = jsConsole.read('#input').split(" ");
	return sequence;
}

function findMinAndMax() {
	var numbers = sequenceNumbers();
	var min = numbers[0];
	var max = numbers[0];

	for (var i = 0; i < numbers.length; i++) {

		if(min > numbers[i] * 1) {
			min = number[i] * 1;
		}

		if (max < numbers[i] * 1) {
			max = numbers[i] * 1;
		}
	}

	jsConsole.writeLine("Min:" + min);
	console.log("Min:" + min);
	jsConsole.writeLine("Max:" + max);
	console.log("Max" + max);
}

