// Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.

var jsConsole;
var array = [4, 12, 33, 19, 4, 9, 44, 29];

function compareNeighbours (array, position) {
	var isLarger = false;
	if (position < array.length && position > 0) {
		if (array[position] > array[position-1] && array[position] > array[position+1]){
			isLarger = true;
		}
	}
	return isLarger;
}

jsConsole.writeLine('We have array with elements:' + array);
for(var i = 0;i < array.length; i+=1) {
	if(compareNeighbours(array, i)){
		jsConsole.writeLine('Element ' + array[i] + ' is is the 1st element larger than its neighbours. It has index = ' + i);
		break;
	}
}