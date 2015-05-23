(function () {
    var app = angular.module('Symelco',[]);

    app.controller('EmpleadoActualizar', ['$http', function ($http) {
        var contEmpleado = this;
        contEmpleado.Empleado = [];
        contEmpleado.asd = 2
        $http.get('http://localhost:49401/api/empleado/1').success(function (data) {
            contEmpleado.Empleado = data;
        });
    }]);

})();
