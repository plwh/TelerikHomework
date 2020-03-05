/* Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
Use only array methods and no regular loops (for, while) */

var jsConsole;

var people = [
{ firstName: 'Petar', lastName: 'Petrov', age: 17, gender: 'male'},
{ firstName: 'Petko', lastName: 'Penkov', age: 19, gender: 'male'},
{ firstName: 'Gosho', lastName: 'Petrov', age: 32, gender: 'male'},
{ firstName: 'Penka', lastName: 'Petkova', age: 16, gender: 'female'},
{ firstName: 'Stoika', lastName: 'Penkova', age: 18, gender: 'female'},
{ firstName: 'Stoyan', lastName: 'Georgiev', age: 30, gender: 'male'}];

jsConsole.writeLine('We have array with people:');
people.forEach(function(person){
	jsConsole.writeLine(JSON.stringify(person));
});

var groupedPeople = groupByFirstLetter(people);

jsConsole.writeLine('People grouped by first letter of first name:');
jsConsole.writeLine(JSON.stringify(groupedPeople));

function groupByFirstLetter (people) {
	var result = people.reduce (function (grouped, person){
		var firstLetter = person.firstName[0].toLowerCase();
		if (!grouped.hasOwnProperty(firstLetter)) {
			grouped[firstLetter] = [];
		}
		grouped[firstLetter].push(person);
		return grouped;
	}, {});

	return result;
}