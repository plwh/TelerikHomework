// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

var jsConsole;

var arr = [4,5,6,2,9,5,7,0,3,2,4,5,6,7];

function findCount (target, array) {
	var count = 0;
	for(var i = 0; i < array.length; i+=1) {
		if(array[i] == target){
			count+=1;
		}
	}
	if (count === 0){
		return 'number has no occurences';
	} else {
		return 'Number:'+target+' Ocurrences:'+count;
	}
}

function test () {
	var firstTest = findCount(4,arr);
	var secondTest = findCount(3,arr);
	var thirdTest = findCount(6,arr);
	return firstTest + '\n' + secondTest + '\n' + thirdTest;
}

jsConsole.writeLine(findCount(5,arr));
jsConsole.writeLine('Test function results:');
jsConsole.writeLine(test());
