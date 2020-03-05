/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {
	var total = 0;
	if(arr.length === 0) {
		return null;
	} else {
        if (!arr.every(function(item) {
                return !isNaN(item);
            })) {
            throw 'Array elements must be convertible to numbers.';
        }
    }
	for(var i = 0 ; i < arr.length; i++) {
		total += parseInt(arr[i]);
	}
	return total;
}
module.exports = sum;

console.log(sum(['1','2']));