// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.

var jsConsole,
	objToClone = [3,4,6,8,[4,9]],
	clonedObject;

function makeClone (obj) {
	var clone = obj instanceof Array ? [] : {};
	for(var j in obj) {
		if (obj.hasOwnProperty(j)){
			if(typeof(obj[j]) == "object" && obj[j] !== null){
				clone[j] = makeClone(obj[j]);
			} else {
				clone[j] = obj[j];
			}
		}
	}
	return clone;
}

clonedObject = makeClone(objToClone);
jsConsole.writeLine('Test array elements:' + JSON.stringify(objToClone));
jsConsole.writeLine('Cloned array elements:' + JSON.stringify(clonedObject));



