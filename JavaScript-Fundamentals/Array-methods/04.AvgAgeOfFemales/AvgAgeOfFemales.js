/* Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while) */

var jsConsole;
var avgAge = 0;
var totalAge = 0;

var people = [
{ firstName: 'Petar', lastName: 'Petrov', age: 17, gender: 'male'},
{ firstName: 'Gosho', lastName: 'Petrov', age: 32, gender: 'male'},
{ firstName: 'Penka', lastName: 'Petkova', age: 16, gender: 'female'},
{ firstName: 'Stoika', lastName: 'Penkova', age: 18, gender: 'female'}];

jsConsole.writeLine('We have array with people:');
people.forEach(function(person){
	jsConsole.writeLine(JSON.stringify(person));
});

var women = people.filter (function (person) {
	return person.gender === 'female';
});

jsConsole.writeLine('Females:');
women.forEach(function(person){
	totalAge += person.age;
	jsConsole.writeLine(JSON.stringify(person));
});

avgAge = totalAge / women.length;

jsConsole.writeLine('Average age of females is: '+avgAge);