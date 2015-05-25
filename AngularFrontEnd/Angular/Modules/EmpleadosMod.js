(function () {
    var EmpleadoModule = angular.module('Empleados', ['ngRoute']);

    EmpleadoModule.controller('EmpleadosActualizar', ['$http', function ($http) {
        var contEmpleado = this;
        contEmpleado.Empleado = [];
        contEmpleado.asd = 2
        $http.get('http://localhost:49401/api/empleado/1').success(function (data) {
            contEmpleado.Empleado = data;
        });
    }]);


    EmpleadoModule.controller('EmpleadosListar', ['$http', function ($http) {
        var contEmpleado = this;
        contEmpleado.Empleados = [];
        $http.get('http://localhost:49401/api/empleado/').success(function (data) {
            contEmpleado.Empleados = data;
        });
    }]);

})();


