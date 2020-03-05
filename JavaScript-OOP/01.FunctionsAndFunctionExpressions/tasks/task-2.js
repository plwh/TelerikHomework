/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes() {
	return function (n,k) {
	function isPrime(n) {
		if (isNaN(n) || !isFinite(n) || n%1 || n<2) return false;
		if (n%2===0) return (n==2);
		if (n%3===0) return (n==3);
		var m=Math.sqrt(n);
		for (var i=5;i<=m;i+=6) {
		if (n%i===0)     return false;
		if (n%(i+2)===0) return false;
		}
		return true;
	}
	if(arguments.length < 2) {
		throw 'Argument is missing';
	}
	var primes = [];
	for (var i = n ; i <= k; i++) {
		if (isPrime(i)) {
			primes.push(i);
		}
	}
	return primes;
};
}

module.exports = findPrimes;

console.log(findPrimes(1,5));
