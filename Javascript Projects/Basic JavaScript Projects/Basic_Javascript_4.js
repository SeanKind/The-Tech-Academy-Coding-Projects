function dict() {
    var plane = {
        model: "Air",
        color: "Yellow",
        landingGear: "Has landing gears",
        make: "Boeing",
        sound: "neeerrrooooo",
        color: "Green"
        
    };
    delete plane.model;
    document.getElementById('Dictionary').innerHTML = plane.model;
}

