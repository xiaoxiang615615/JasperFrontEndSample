function PhoneCtrl($scope) {
    $scope.phones = [{ name: 'IPHONE', snippet: "Iphone is good" }, { name: "NEXUS5", snippet: "NEXUS5 is good as well" }];

    $scope.testFunction = function () {
        alert("Working!!");
    };

};

