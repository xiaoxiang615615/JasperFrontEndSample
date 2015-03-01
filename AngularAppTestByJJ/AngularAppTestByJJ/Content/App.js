var JasperAngularTest = angular.module('JasperAngularTest', [
    'ngRoute',
    'PhoneListCtrl',
    'jasperFilter'
]);

JasperAngularTest.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/home', {
            templateUrl: 'home/citylist',
            controller: 'PhoneListCtrl'
        }).
        otherwise({
            redirectTo: '/home/index'
        });
  }]);

