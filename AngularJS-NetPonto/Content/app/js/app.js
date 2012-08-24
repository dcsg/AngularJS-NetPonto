'use strict';

var partialsDir = 'Content/app/partials/';
angular.module('netpontoApp', ['netpontoApp.filters'])
        .config(function ($routeProvider, $locationProvider) {

            //Adds the prefix '!' to the url
            $locationProvider.hashPrefix('!');
            //$locationProvider.html5Mode(true);

            //routes
            $routeProvider
              .when('/',            { controller: HomeCtrl,         templateUrl: partialsDir + 'home.html' })
              .when('/expressoes',  { controller: ExpressoesCtrl,   templateUrl: partialsDir + 'expressoes.html' })
              .when('/validacoes',  { controller: ValidacoesCtrl,   templateUrl: partialsDir + 'validacoes.html' })
              .when('/filtros',     { controller: FiltrosCtrl,      templateUrl: partialsDir + 'filtros.html' })
              .otherwise({ redirectTo: '/' });
        });