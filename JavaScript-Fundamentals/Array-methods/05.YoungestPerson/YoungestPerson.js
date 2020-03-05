/* Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find */

var jsConsole;

if (!Array.prototype.find) {
	Array.prototype.find = function(callback) {
		var i, len = this.length;
		for (i = 0; i < len; i += 1) {
			if (callback(this[i], i, this)) {
				return this[i];
			}
		}
	};
}

var people = [
{ firstName: 'Petar', lastName: 'Petrov', age: 17, gender: 'male'},
{ firstName: 'Gosho', lastName: 'Petrov', age: 32, gender: 'male'},
{ firstName: 'Penka', lastName: 'Petkova', age: 16, gender: 'female'},
{ firstName: 'Stoika', lastName: 'Penkova', age: 18, gender: 'female'}];


jsConsole.writeLine('We have array with people:');
jsConsole.writeLine(JSON.stringify(people));

var youngestPerson = findYoungest(people, 'male');

jsConsole.writeLine('Youngest male person is:');
jsConsole.writeLine(JSON.stringify(youngestPerson.firstName +' '+ youngestPerson.lastName));

function findYoungest(people, gender) {
	var minAge = people.reduce(function(previousValue, currentValue) {
		if (gender === 'male' || gender === 'female') {
			if (previousValue > currentValue.age && currentValue.gender === gender) {
				return currentValue.age;
			} else {
				return previousValue;
			}
		} else {
			if (previousValue > currentValue.age) {
				return currentValue.age;
			} else {
				return previousValue;
			}
		}
	}, 200);
	var youngest = people.find(function(person) {
		if (person.age === minAge) {
			return true;
		} else {
			return false;
		}

	});
	return youngest;
}