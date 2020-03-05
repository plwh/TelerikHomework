// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

var jsConsole;

function getProperties(object) {
    var objects = Object.getOwnPropertyNames(object);
    objects.sort();

    jsConsole.writeLine("Object " + object.toString());
    jsConsole.writeLine("Lexicographically first: " + objects[0] +" | Lexicographically last: " + objects[objects.length - 1]);
}

getProperties(document);
getProperties(window);
getProperties(navigator);