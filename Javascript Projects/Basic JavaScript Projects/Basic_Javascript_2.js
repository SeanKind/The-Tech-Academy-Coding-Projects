function test3() {
    var string = "This is blue text";
    var color = string.fontcolor("blue");
    document.getElementById("blueText").innerHTML = color
}

function a() {
    var sentence = "1 plus 2 is "; sentence += "three!";
    document.getElementById("concat").innerHTML = sentence;
}