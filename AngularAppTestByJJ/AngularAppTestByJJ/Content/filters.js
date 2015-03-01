angular.module('jasperFilters', []).filter('checkmark', function () {
    return function (text) {
        return text ? '\u2713' : '\u2718';
    };
});