/* Sorting an array means to arrange its elements in increasing order.
Write a script to sort an array.
Use the selection sort algorithm: Find the smallest element, move it at the first 
position, find the smallest from the rest, move it at the second position, etc */

var jsConsole;
var btn = document.getElementById('sortArray');
btn.onclick = sortArray;

function sortArray () {
	var i, j , min , temp;
	var array = jsConsole.read('#array').split(" ");

	for (i = 0; i < array.length - 1; i++) {
		min = i;
		for (j = i + 1; j < array.length; j++) {
			if (array[j] < array [min]) {
				min = j;
			}
		}
		temp = array[i];
		array[i] = array[min];
		array[min] = temp;
	}

	jsConsole.writeLine("Array elements sorted using selection sort:");
	console.log("Array elements sorted using selection sort:");

	for (var k = 0; k < array.length ; k++) {
		jsConsole.write(array[k] + " ");
		console.log(array[k] + " ");
	}
}