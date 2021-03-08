function addition() {
    var addition = 2 + 2;
    document.getElementById("add").innerHTML = "2 + 2 = " + addition;
}

function subtraction() {
    var subtraction = 5 - 2;
    document.getElementById("sub").innerHTML = "5 - 2 = " + subtraction;
}

function multiplication() {
    var math = 6 * 8;
    document.getElementById("multi").innerHTML = "6 * 8 = " + math;
}

function division() {
    var math = 48 / 6;
    document.getElementById("divi").innerHTML = "48 * 6 = " + math;
}

function exaggmath() {
    var Math = (1 + 2) * 10 / 2 - 5;
    document.getElementById("Math").innerHTML = "1 plus 2, multiplied by 10, divided in half and then subtracted by 5 equals " + Math;
}

function remainder() {
    var math = 25 % 6
    document.getElementById('remainder').innerHTML = "When you divide 25 by 6 you have a remainder of: " + math
}

function negative() {
    var x = 10;
    document.getElementById('negative').innerHTML = -x;
}

var x = 5; 
x++;
document.write(x)

var y = 5;
y--;
document.write(y);

window.alert(Math.random() * 100)

document.write(Math.round(4.4))