// Problem 1: Assign all the possible JavaScript literals to different variables
// Problem 3: Try typeof on all variables you created
// Problem 4: Create null, undefined variables and try typeof on them.

var jsConsole;
var string = 'Hello, World!';
var integer = 135;
var floatType = 13.5;
var array = [3,5,8];
var object = {manufacturer: 'BMW', model: 'M3'};
var func = function(){return;};
var valueTypeNull = null;
var valueTypeUndefined;

var diffVariables = [string,floatType,integer,array,object,func,valueTypeNull,valueTypeUndefined];

for(var variable in diffVariables){
  console.log('Type is:', typeof (diffVariables[variable]));
}

for(var variable in diffVariables){
	jsConsole.write('Type of ' + JSON.stringify(diffVariables[variable]) + ' is: ');
    jsConsole.writeLine((typeof(diffVariables[variable])));
}


