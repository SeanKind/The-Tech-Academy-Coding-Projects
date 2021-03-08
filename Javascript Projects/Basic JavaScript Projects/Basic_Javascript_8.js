function fullSentence() {
    var part1 = "I have ";
    var part2 = "made this ";
    var part3 = "into a complete ";
    var part4 = "sentence.";
    var wholeSentence = part1.concat(part2, part3, part4);
    document.getElementById('concat').innerHTML = wholeSentence;
}

function sliceMethod() {
    var Sentence = "All work and no play makes Johnny a dull boy.";
    var Section = Sentence.slice(27,33);
    document.getElementById("Slice").innerHTML = Section;
}

function toUpper() {
    var string = "hello world!";
    var upper = string.toUpperCase();
    document.getElementById("test").innerHTML = upper;
}

function searchFunction () {
    var hello = "hello world";
    var search = hello.search("world");
    document.getElementById("search").innerHTML = search;
}

function stringMethod() {
    var x = 182;
    document.getElementById("numbers").innerHTML = x.toString();
}

function precisionMethod() {
    var y = 12938.3012987376112;
    document.getElementById("precision").innerHTML = y.toPrecision(10);
}

function getMoney() {
    var money = 2934.5594;
    document.getElementById("money").innerHTML = money.toFixed(2);
}

function valOf() {
    var hello = "Hello World!";
    var val = hello.valueOf();
    document.getElementById("value").innerHTML = val;
}