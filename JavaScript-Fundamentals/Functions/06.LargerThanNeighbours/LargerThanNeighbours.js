// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

var jsConsole;
var array = [5, 13, 34, 20, 4 ,10, 45, 30];
var position = 2;

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
jsConsole.writeLine('The test position is:' + position);
jsConsole.writeLine('Is element at positon ' + position +' larger than its neighbours? ' + (compareNeighbours(array,position) ? 'Yes' : 'No'));