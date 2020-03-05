// Write a function that checks if an array of person contains only people of age (with age 18 or greater)
// Use only array methods and no regular loops (for, while)

var jsConsole;

var people = [
{ firstName: 'Petar', lastName: 'Petrov', age: 18},
{ firstName: 'Gosho', lastName: 'Petrov', age: 32},
{ firstName: 'Michael', lastName: 'Bay', age: 50}];

jsConsole.writeLine('We have array with people:');
people.forEach(function(person){
	jsConsole.writeLine(JSON.stringify(person));
});

jsConsole.write('All people have age 18 or greater? ');
jsConsole.writeLine(people.every(function(person){
	return (person.age >= 18);
}));

