// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

var jsConsole;

var people = [
{ firstName: 'Gosho', lastName: 'Petrov', age: 32},
{ firstName: 'Michael', lastName: 'Bay', age: 50}];

function findYoungestPerson (peopleArray) {
	var person = {},
		youngestPerson = 0;

	for (var j = 0; j < peopleArray.length-1; j+=1) {
		if (peopleArray[j].age < peopleArray[j+1].age) {
			youngestPerson = peopleArray[j].age;
			person = peopleArray[j];
		}
	}
	return person;
}

jsConsole.writeLine('Youngest person is:' + JSON.stringify(findYoungestPerson(people)));