// Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

var jsConsole;

function printArray () {
	var array = [],
		i;

	for (i = 0; i < 20; i++) {
		array[i] = i * 5;
	}

	jsConsole.writeLine ("Array elements: " + array.join(", "));
	console.log("Array elements: " + array.join(", "));
}

printArray();