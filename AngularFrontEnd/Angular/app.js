(function () {
    var app = angular.module('Symelco', ['ngRoute','Empleados']);

    app.config(function ($routeProvider) {
        $routeProvider
            .when('/home', {
                templateUrl: 'MenuMetro.html',
                controller: 'MainController'
            })
            .when('/Empleados/1', {
                templateUrl: 'EmpleadosActualizar.html',
                controller: 'EmpleadosActualizar'
            })
            .when('/Empleados', {
                templateUrl: 'EmpleadosListado.html',
                controller: 'EmpleadosListar'
              })
            .otherwise({
                redirectTo: '/home'
            });
    });

      
    app.controller('MainController', ['$http', function ($http) {
        var contEmpleado = this;
        contEmpleado.Empleado = [];
        contEmpleado.asd = 2
        $http.get('http://localhost:49401/api/empleado/1').success(function (data) {
            contEmpleado.Empleado = data;
        });
    }]);


})();



