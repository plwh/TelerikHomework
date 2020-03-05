/* Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders */

var jsConsole;

function makePerson(firstName, lastName, age, gender) {
		return {
			firstName: firstName,
			lastName: lastName,
			age: age,
			gender: gender
		};
	}

function createPeople(count) {
	count = count || 20;
	var menFNames = ['Gosho', 'Pesho', 'Gaco'];
	var menLNames = ['Geshev', 'Peshev', 'Bacov'];
	var womenFNames = ['Radka', 'Alena', 'Kitka'];
	var womenLNames = ['Georgieva', 'Penkova', 'Temenujkova'];

	var people = [];
	var firstName,
		lastName,
		age,
		gender;

	for (var j = 0; j < count; j += 1) {
		if (Math.round(Math.random())) {
			firstName = menFNames[(Math.random() * menFNames.length) | 0];
			lastName = menLNames[(Math.random() * menLNames.length) | 0];
			gender = 'm';
		} else {
			firstName = womenFNames[(Math.random() * womenFNames.length) | 0];
			lastName = womenLNames[(Math.random() * womenLNames.length) | 0];
			gender = 'f';
		}
		age = Math.random() * 100 | 0;
		people.push(makePerson(firstName,lastName,age,gender));
	}

	return people;
}

var arrayOfPeople = createPeople(10);
arrayOfPeople.forEach(function(person){
	jsConsole.writeLine(JSON.stringify(person));
});