function Vehicle(Make, Model, Year, Color) {
    this.vehicleMake = Make;
    this.vehicleModel = Model;
    this.vehicleYear = Year;
    this.vehicleColor = Color;
}
var Jack = new Vehicle("Dodge", "Viper", 2020, "Red");
var Emily = new Vehicle("Jeep", "Trail Hawk", 2019, "White and Black");
var Erik = new Vehicle("Ford", "Pinto", 1971, "Mustard");
function myVehicle() {
    document.getElementById('kwandcon').innerHTML = 
    "Erik drives a " + Erik.vehicleColor + "-colored " + Erik.vehicleModel +
    " manufactured in " + Erik.vehicleYear
}