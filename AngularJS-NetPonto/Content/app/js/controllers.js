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
        API.DeleteProcess({ id: $routeParams.id }, function (success) {
            $location.path('/');
        })
    }

    $scope.edit = function (process) {
        $location.path('/process/edit/'+process.Id);
    }
}

function ProcessNewCtrl($scope, $routeParams, API, $location, $rootScope) {
    $scope.save = function () {
        API.AddProcess({}, $scope.process, function (res) {
            if (res.Id > 0) {
                $location.path('/');
            }
        })
    }
}

function ProcessEditCtrl($scope, $routeParams, API, $location) {
    $scope.process = API.GetProcess({ id: $routeParams.id }, function (process) {
        $scope.master = angular.copy(process);
    });

    $scope.reset = function () {
        $scope.process = angular.copy($scope.master);
    }

    $scope.update = function (process) {
        API.UpdateProcess({ id: process.Id }, $scope.process, function (res) {
            if (res.Id > 0) {
                $location.path('/process/' + process.Id);
            }
        })
    }

    $scope.delete = function (process) {
        API.DeleteProcess({ id: $routeParams.id }, function (success) {
            $location.path('/');
        })
    }
}