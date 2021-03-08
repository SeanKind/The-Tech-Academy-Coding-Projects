//this function will display an incriment of 1 starting at 1 until it hits 10
function callLoop() {
    var digit = "";
    var x = 1;
    while (x < 11) {
        digit += "<br>" + x;
        x++;
    }
    document.getElementById("loop").innerHTML = digit;
}


var instruments = ["Guitar", "Drums","Piano", "Bass", "Violin", "Trumpet", "Flute"];
var content = "";
var y;
function instrum() {
    for (y = 0; y < instruments.length; y++) {
        content += instruments[y] + "<br>";
    }
    document.getElementById("for").innerHTML = content;
}

function catPic() {
    var catPicture = [];
    catPicture[0] = "sleeping";
    catPicture[1] = "playing";
    catPicture[2] = "eating";
    catPicture[3] = "purring";
    document.getElementById("cat").innerHTML = "In this picture, the cat is " + catPicture[2] + ".";
}

function guitar() {
    const musicalInstrument = {type:"Guitar", brand:"Fender", color:"Black"};
    musicalInstrument.color = "Blue";
    musicalInstrument.price = "$900";
    document.getElementById("constant").innerHTML = "The cost of the " + 
    musicalInstrument.type + " was " + musicalInstrument.price;
}

var x = 82;
document.write(x);
{
    let x = 33;
    document.write("<br>" + x);
}
document.write("<br>" + x);

function test2() {
    function helloName() {
        return Math.PI;
    }
    document.getElementById("test").innerHTML = helloName();
}
function vic() {
    let car = {
        make: "Jeep ",
        model: "Wrangler ",
        description : function() {
            return "The car is a " + this.make + this.model;
        }
    }
    document.getElementById("vehicle").innerHTML = car.description();
}

function test1() {
    var text = "";
    var i;
    for (i = 0; i < 10; i++) {
        if (i === 3) { break; }
        text += "The number is " + i + "<br>";
    }
    document.getElementById("test1").innerHTML = text;
}    

function numbers1() {
    var go = "";
    var i;
    for (i = 0; i < 10; i++) {
        if (i === 3) { continue; }
        go += "The number is " + i + "<br>";
    }
    document.getElementById("counting").innerHTML = go;
}