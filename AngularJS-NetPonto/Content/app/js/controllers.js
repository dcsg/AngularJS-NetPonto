'use strict';

function HomeCtrl($scope, $routeParams, API) {
    if ($scope.processes == undefined || !($scope.processes.length > 0))
        $scope.processes = API.GetProcesses();

    $scope.show = function (process) {
        $scope.process = process;
    }
}

function ProcessCtrl($scope, $routeParams, API, $location) {
    $scope.process = API.GetProcess({ id: $routeParams.id });

    $scope.delete = function (process) {
        var ok = API.DeleteProcess({ id: $routeParams.id }, function (success) {
            $location.path('/');
        })
    }
}

function ProcessNewCtrl($scope, $routeParams, API, $location) {
    $scope.process = new API();

    $scope.save = function () {
        API.AddProcess({}, $scope.process, function (res,a,b) {
            if (res.Id > 0) {
                $location.path('/');
            }
        })
    }
}