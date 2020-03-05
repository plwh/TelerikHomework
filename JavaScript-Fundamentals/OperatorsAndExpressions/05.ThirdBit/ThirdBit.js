/* Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0. */

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = findThirdBit;

function findThirdBit () {
	var n = jsConsole.readInteger('#input');
	var mask = 1 << 3;
    var nAndMask = n & mask;
    var thirdBit = nAndMask >> 3;
    
    jsConsole.writeLine("Bit #3 is "+thirdBit);
    console.log("Bit #3 is "+ thirdBit);
}