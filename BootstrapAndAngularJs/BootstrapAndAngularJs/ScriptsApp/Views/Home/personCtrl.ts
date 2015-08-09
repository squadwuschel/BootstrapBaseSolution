

function personCtrl() {

    this.Name = "Johannes";

}


angular.module("personCtrl", [])
    .controller("personCtrl", [personCtrl]);