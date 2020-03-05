// Write a function that checks if a given object contains a given property.

var jsConsole,
    sampleObj = [5,7,9,4],
    sampleProperty = 'length';

function hasProperty (obj, property) {
	if(obj.hasOwnProperty(property)){
		return true;
	}
}

jsConsole.writeLine('Does object contain property "' + sampleProperty + '": ' + (hasProperty(sampleObj,sampleProperty)? 'Yes' : 'No'));