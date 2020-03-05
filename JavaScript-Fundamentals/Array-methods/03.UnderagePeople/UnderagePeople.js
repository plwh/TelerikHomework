/* Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while) */

var jsConsole;

var people = [
{ firstName: 'Petar', lastName: 'Petrov', age: 17},
{ firstName: 'Gosho', lastName: 'Petrov', age: 32},
{ firstName: 'Penka', lastName: 'Petkova', age: 16},
{ firstName: 'Stoika', lastName: 'Penkova', age: 18}];

jsConsole.writeLine('We have array with people:');
people.forEach(function(person){
	jsConsole.writeLine(JSON.stringify(person));
});

var underagedPeople = people.filter(function (person){
	return person.age < 18;
});

jsConsole.writeLine('Underaged people:');
underagedPeople.forEach(function (person){
	jsConsole.writeLine(JSON.stringify(person));
});
