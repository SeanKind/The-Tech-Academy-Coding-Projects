function colorFunction() {
    var colorOutput;
    var colors = document.getElementById("colorInput").value;
    var colorString = " is a great color!";
    switch(colors) {
        case "Red":
            colorOutput = "Red" + colorString;
        break;
        case "Yellow":
            colorOutput = "Yellow" + colorString;
        break;
        case "Green":
            colorOutput = "Green" + colorString;
        break;
        case "Blue":
            colorOutput = "Blue" + colorString;
        break;

        case "Pink":
            colorOutput = "Pink" + colorString;
        break;
        case "Purple":
            colorOutput = "Purple" + colorString;
        break;
        default:
        colorOutput = "Please enter a color exactly as written on the above list.";
    }
    document.getElementById("output").innerHTML = colorOutput;
}

function helloWorld() {
    var A = document.getElementsByClassName("Click");
    A[0].innerHTML = "The text has changed!";
}
function testCan() {
    var c = document.getElementById("testCanvas");
    var ctx = c.getContext("2d");
    ctx.moveTo(0, 0);
    ctx.lineTo(500, 250);
    ctx.stroke();
}
function testGrad() {
    var c = document.getElementById("testCanvasGrad");
    var ctx = c.getContext("2d");
    var grd = ctx.createLinearGradient(0, 0, 500, 0);
    grd.addColorStop(0, "black");
    grd.addColorStop(1, "white");
    ctx.fillStyle = grd;
    ctx.fillRect(0, 0, 500, 250);
}