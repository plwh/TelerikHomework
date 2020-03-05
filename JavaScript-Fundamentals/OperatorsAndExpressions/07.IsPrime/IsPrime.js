// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

var jsConsole;
var btn = document.getElementById('check');
btn.onclick = chkIsPrime;

function chkIsPrime () {
	var number = jsConsole.readInteger('#input');
	var isPrime = true;

	if (number > 100 || isNaN(number)) {
		alert('number should be in range [n <= 100]');
		return;
    }

	if(number <= 1) {
		isPrime = false;
	} else {
		for (var i = 2; i < number; i++) {
			if(number % i === 0) {
				isPrime = false;
				break;
			}
		}
	}

	if (isPrime)
    {
        jsConsole.writeLine("Number is prime");
        console.log("Number is prime");
    } else {
        jsConsole.writeLine("Number is not prime");
        console.log("Number is not prime");
    }
}