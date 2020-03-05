// Write a function that removes all elements with a given value.
// Attach it to the array type.

var jsConsole,
	arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'],
	numberToRemove = 1;

Array.prototype.remove = function (array, numberToRemove){
	for (var j = 0; j < array.length; j+=1) {
		if (array[j] === numberToRemove) {
			array.splice(j,1);
		}
	}
	return array;
};

jsConsole.writeLine('Test array elements:' + arr);
jsConsole.writeLine('Array elements after removing element with value "1":' + arr.remove(arr,1));

