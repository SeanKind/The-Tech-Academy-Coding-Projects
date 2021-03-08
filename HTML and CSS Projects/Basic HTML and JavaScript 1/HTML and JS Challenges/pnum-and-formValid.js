function validForm() {
    var x = document.forms["myForm"]["fname"].value;
    var y = document.forms["myForm"]["lname"].value;
    var z = document.forms["myForm"]["phone"].value;
    if (x == "") {
        alert("First name must be filled out");
        return false;
    }
    if (y == "") {
        alert("Last name must be filled out");
        return false;
    }
    if (z == "") {
        alert("Phone number must be filled out");
        return false;
    }
}


$("#slideshow > div:gt(0)").hide();
setInterval(function() {
    $('#slideshow > div:first')
    .fadeOut(1000)
    .next()
    .fadeIn(1000)
    .end()
    .appendTo('#slideshow');
}, 3000);



function openForm() {
    document.getElementById("myForm").style.display = "block";
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
}