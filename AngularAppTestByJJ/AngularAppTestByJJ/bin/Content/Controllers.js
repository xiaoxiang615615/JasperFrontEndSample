var JasperAngularTest = angular.module('JasperAngularTest', [
    'ngRoute',
]).directive('draggable', function ($document) {
    return function (scope, element, attr) {
        var startX = 0, startY = 0, x = 0, y = 0;
        element.css({
            position: 'relative',
            border: '1px solid red',
            backgroundColor: 'lightgrey',
            cursor: 'pointer'
        });
        element.on('mousedown', function (event) {
            // Prevent default dragging of selected content
            event.preventDefault();
            startX = event.screenX - x;
            startY = event.screenY - y;
            $document.on('mousemove', mousemove);
            $document.on('mouseup', mouseup);
        });

        function mousemove(event) {
            y = event.screenY - startY;
            x = event.screenX - startX;
            element.css({
                top: y + 'px',
                left: x + 'px'
            });
        }

        function mouseup() {
            $document.off('mousemove', mousemove);
            $document.off('mouseup', mouseup);
        }
    };
});

JasperAngularTest.controller('PhoneCtrl', function ($scope) {
    $scope.phones = [{ name: 'Jasper\'s IPHONE', snippet: "Iphone is good" }, { name: "NEXUS5", snippet: "NEXUS5 is good as well" }];

    $scope.testFunction = function () {
        alert("Working!!");
    };

});

JasperAngularTest.controller('SearchCtrl', function ($scope) {

    $scope.phones = [{ name: 'IPHONE', snippet: "Iphone is good" }, { name: "NEXUS5", snippet: "NEXUS5 is good as well" }];

    $scope.testFunction = function () {
        alert("Search is working!!!")
    }
});

JasperAngularTest.controller('OrderControlCtrl', function ($scope) {

    $scope.phones = [{ name: 'IPHONE', snippet: "Tphone is good", 'age': 1 }, { name: "NEXUS5", snippet: "NEXUS5 is good as well", 'age': 2 }];

    $scope.orderProp = 'age';
    
})

JasperAngularTest.controller('PhoneListCtrl', function ($scope, $http) {
    $http.get('http://10.200.0.202:7070/JasperJqueryMobile/WebServices/JqueryMobileWebService.asmx/getAllCities', { params: { page: 3, rows: 20 } }).success(function (data) {
        var dataToShow = [];
        var counter = 0;
        var xmlDoc = $.parseXML(data),
        $xml = $(xmlDoc),  
        $test = $xml.find('City').each(function () {
            $name = $(this).find("Name");
            $country = $(this).find("Country");
            $district = $(this).find("District");
            $population = $(this).find("Population");
               
                dataToShow.push({name: $name.text(), country: $country.text(), population: $population.text(), pic: "http://10.200.0.202:7070/AngularTest/Pic/logo.jpg"});
  
        })
        //dataToShow = dataToShow.substring(0, dataToShow.length - 1);
       
        //console.log(JSON.stringify(dataToShow));
        var finalData = JSON.stringify(dataToShow);
        finalData = JSON.parse(finalData);
        //alert(finalData);
        //if (finalData == [{ "name": "Kabul", "country": "AFG", "population": "1780000" }])
        //{
        //    console.log(finalData);
        //    console.log("Line breaker");
        //    console.log([{ "name": "Kabul", "country": "AFG", "population": "1780000" }]);
        //    alert("They are the same");
        //}
        //else
        //{
        //    console.log(finalData);
        //    console.log("Line breaker");
        //    console.log([{ "name": "Kabul", "country": "AFG", "population": "1780000" }]);
        //    alert("No!!!!!!!!!!!!!");
        //}
        $scope.cities = finalData;
      
    }).
    error(function (data, status) {
        alert(data);
    })

    

})


JasperAngularTest.filter('checkmark', function () {
    return function (text) {
        return text ? '\u2713' : '\u2718';
    };
});


JasperAngularTest.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/home', {
            templateUrl: 'home/citylist',
            controller: 'PhoneListCtrl'
        }).
        otherwise({
            redirectTo: '/home/jasper'
        });
  }]);

JasperAngularTest.controller('LocationControler', function ($scope, $location) {
    console.log($location);
    //alert($location.absUrl() + ", port: " + $location.port());
})

JasperAngularTest.controller('DoubleCtrl', ['$scope', function ($scope) {
    $scope.double = function (value) { return value*2 };

}]);

JasperAngularTest.controller('JasperCtrl', ['$scope', function ($scope) {
    $scope.result = "Nothing yet";

    $scope.JJTest1 = function () {
        $scope.result = "JJ Test 1";
    }
    $scope.JJTest2 = function () {
        $scope.result = "JJ Test 2";
    }
}])

JasperAngularTest.controller('JasperCtrl2', ['$scope', function ($scope) {
    $scope.result = "Nothing yet";

    $scope.JJTest1 = function () {
        $scope.result = "JJ Test 1";
    }
    $scope.JJTest2 = function (value) {
        $scope.result = value;
    }
}])

JasperAngularTest.filter('Hello', function () {
    return function (name) {
        if (name != null && name.length > 0) {
            return "Hello " + name;
        }
        else
        {
            return "";
        }
    }
})

JasperAngularTest.value('JasperValueTest', '123 Looks good');

JasperAngularTest.controller('JasperValueCtrl', ['JasperValueTest', function JasperValueCtrl(JasperValueTest) {
     this.JasperValueTest = JasperValueTest;
}])

JasperAngularTest.factory('FactoryTest',['$window', function(win){
    return function () {
        alert("Working!!!!!!!!!!!!");
    }
}])

JasperAngularTest.controller('FactoryTestCtrl', ['$scope', 'FactoryTest', function ($scope, FactoryTest) {
    $scope.factoryTest = function () {
        FactoryTest();
    }
}])


