/* Write a function that groups an array of people by age, first or last name.
The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function) */

var jsConsole;

var people = [
        { firstName: 'Mike', lastName: 'Tyson', age: 74 },
        { firstName: 'Carl', lastName: 'Weathers', age: 64 },
        { firstName: 'Quentin', lastName: 'Bambino', age: 55 }];
var groupedPeople = groupBy(people,"age");

jsConsole.writeLine('People:');
for(var i =0; i< people.length; i+=1){
	jsConsole.writeLine(JSON.stringify(people[i]));
}

jsConsole.writeLine('People grouped by age:');
for (var group in groupedPeople) {
    for (i = 0; i < groupedPeople[group].length; i++) {
        jsConsole.writeLine("First name: " + groupedPeople[group][i].firstName + "; Last name: " + groupedPeople[group][i].lastName + "; Age: " + groupedPeople[group][i].age);
    }
}

function groupBy(arr, prop) {
	var groupedArr = [];

	for(var i = 0, len = arr.length; i < len; i++){
		if(!groupedArr[arr[i][prop]]) {
			groupedArr[arr[i][prop]] = [];
		}
		groupedArr[arr[i][prop]].push(arr[i]);
	}

	return groupedArr;
}
