document.write(typeof "word");
document.write(" | ")

function math() {
    document.getElementById("Test").innerHTML = 0/0;
}

function math2() {
    document.getElementById('test').innerHTML = isNaN('This is a string');
}

function math3() {
    document.getElementById('test2').innerHTML = isNaN('007');
}

document.write(2e310)
document.write(" | ")

document.write(-2e310)
document.write(" | ")

document.write(10 > 2);
document.write(" | ")

document.write(10 < 2);
document.write(" | ")

console.log(2 + 2);

document.write("10" + 5);
document.write(" | ")

console.log(10 < 2);

document.write(10 == 10);
document.write(" | ")

document.write(3 == 11);
document.write(" | ")

x = 10;
y = 10;
document.write(x === y);
document.write(" | ")

z = 82;
zz = "82";
document.write(z === zz);
document.write(" | ")

a = "Magnus";
b = "Magnos";
document.write(a === b);
document.write(" | ")

c = "James";
d = 34;
document.write(c === d);
document.write(" | ")

document.write(5 > 2 && 10 > 4);
document.write(" | ")

document.write(5 > 10 && 10 > 4);
document.write(" | ")

document.write(5 > 10 || 10 > 4);
document.write(" | ")

document.write(5 > 10 || 10 > 20);
document.write(" | ")

function not() {
    document.getElementById("Not").innerHTML = ! (5 > 10);
}

function doublenot() {
    document.getElementById("doublenot").innerHTML = ! (20 > 10);
}