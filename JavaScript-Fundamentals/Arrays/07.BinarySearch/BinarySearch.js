// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var jsConsole,
    arr = [0, 5, 17, 26, 38, 45, 90],
    button = document.getElementById('check'),
    targetNumber,
    startIndex = 0,
    endIndex = arr.length,
    currIndex;

button.onclick = getIndex;

jsConsole.writeLine("Sample array is: [" + arr + "]");
console.log("Sample array is: [" + arr + "]");

function getIndex() {
    targetNumber = jsConsole.readInteger('#target_number');

    while ((endIndex - startIndex) >= 1) {
        currIndex = startIndex + (((endIndex - startIndex) / 2) | 0);

        if (arr[currIndex] === targetNumber) {
            jsConsole.writeLine(targetNumber + ' is at position ' + currIndex);
            console.log(targetNumber + ' is at position ' + currIndex);
            return;
        } else if (arr[currIndex] > targetNumber) {
            endIndex = currIndex;
        } else if (arr[currIndex] < targetNumber) {
            startIndex = currIndex;
        }
    }

    jsConsole.writeLine("Number was not found!");
    console.log("Number was not found!");
}
