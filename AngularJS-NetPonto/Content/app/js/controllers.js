'use strict';

function HomeCtrl($scope) {
}

function ExpressoesCtrl($scope) {
    $scope.utilizador = { nome: "NetPonto" };
}

function ValidacoesCtrl($scope) {
    $scope.save = function () {
        console.log($scope.process);
    }

    $scope.reset = function () {
        $scope.process = {};
    }
}

function FiltrosCtrl($scope) {
    $scope.texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec massa est, adipiscing quis feugiat quis.";
}

function EscopoCtrl($scope) {
    $scope.texto = "Olá ";
    $scope.$on('Event', function (scope, texto) {
        $scope.texto = texto;
    });
}