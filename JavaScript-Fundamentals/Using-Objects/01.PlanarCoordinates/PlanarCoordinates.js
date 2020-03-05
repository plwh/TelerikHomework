/* Write functions for working with shapes in standard Planar coordinate system.
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points.
Check if three segment lines can form a triangle. */

var jsConsole;

function makePoint (x,y) {
	return {
		x: x,
		y: y
	};
}

function makeLine (firstPoint, secondPoint) {
	return {
		p1: firstPoint,
		p2: secondPoint,
		length: calcPointDistance(firstPoint,secondPoint)
	};
}

function calcPointDistance (p1, p2) {
	var dx = p1.x - p2.x;
	var dy = p1.y - p2.y;
	return Math.sqrt(dx * dx + dy * dy);
}

function isTriangle (firstLine, secondLine , thirdLine) {
	if (firstLine.length >= secondLine.length + thirdLine.length || secondLine.length >= firstLine.length + thirdLine.length || thirdLine.length >= secondLine.length + firstLine.length) {
		return false;
	} else {
		return true;
	}
	return undefined;
}

var firstPoint = makePoint(2,5),
	secondPoint = makePoint(16,13),
	thirdPoint = makePoint(-2,7),
	fourthPoint = makePoint(1,1),
	fifthPoint = makePoint(9,4),
	sixthPoint = makePoint(-9,20);

var firstLine = makeLine(firstPoint,secondPoint),
	secondLine = makeLine(thirdPoint,fourthPoint),
	thirdLine = makeLine(fifthPoint,sixthPoint);

jsConsole.writeLine('First line length (firstPoint, secondPoint distance):' + firstLine.length);
jsConsole.writeLine('Second line length (thirdPoint, fourthPoint distance):' + secondLine.length);
jsConsole.writeLine('Third line length (fifthPoint, sixthPoint distance):' + thirdLine.length);

jsConsole.writeLine("Can first, second and third line form a triangle: " + (isTriangle(firstLine,secondLine,thirdLine)? 'Yes' : 'No'));
