function ride() {
    var Height, canRide;
    Height = document.getElementById('Height').Value;
    canRide = (Height < 52) ? "You are too short":"You are tall enough";
    document.getElementById("Ride").innerHTML = canRide + " to ride.";
}

function vehicle(Make, Model) {
    this.vehicleMake = Make;
    this.vehicleModel = Model;

}
var Sean = new vehicle("Jeep", "Wrangler")
function myVehicle() {
    document.getElementById('newAndThis').innerHTML = 
    "Sean drives a " + Sean.vehicleMake + " " + Sean.vehicleModel + "."
}



function cnt() {
    document.getElementById('counting').innerHTML = count();
    function count() {
        var startingPoint = 9;
        function plusOne() {startingPoint += 1;}
        plusOne();
        return startingPoint;
    }
}

 