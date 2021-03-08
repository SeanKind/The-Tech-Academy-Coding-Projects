var x = 10;
function one() {
    document.write(20 + x + "<br>");
}
function two(){
    document.write(x + 100);
}
one();
two();

function three(){
    var y = 10;
    console.log(15 + y);
}
function four() {
    console.log(y + 100);
}
three();
four();

function getDate() {
    if (new Date().getHours() < 18) {
        document.getElementById("greeting").innerHTML = "How are you today?";
    }
}
function five() {
    if (5 > 2) {
        document.getElementById('test').innerHTML = "Truee";
    }
}

function ageVote() {
    age = document.getElementById("enterAge").value;
    if (age >= 18) {
        Vote = "You are old enough to vote!";
    }
    else {
        Vote = "You are not old enough to vote!";
    }
    document.getElementById("howOld").innerHTML = Vote;
}

function timeFunction() {
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It is morning time!";
    }
    else if (Time > 12 == Time < 18) {
        Reply = "It is the afternoon.";
    }
    else {
        Reply = "It is evening time.";
    }
    document.getElementById('timeDay').innerHTML = Reply;
}