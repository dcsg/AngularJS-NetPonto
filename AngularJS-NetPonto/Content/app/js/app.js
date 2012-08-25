'use strict';

var partialsDir = 'Content/app/partials/';
angular.module('netpontoApp', ['netpontoApp.filters', 'netpontoApp.API'])
        .config(function ($routeProvider, $locationProvider) {

            //Adds the prefix '!' to the url
            $locationProvider.hashPrefix('!');
            //$locationProvider.html5Mode(true);

            //routes
            $routeProvider
                .when('/', { controller: HomeCtrl, templateUrl: partialsDir + 'home.html' })
                .when('/process/edit/:id', { controller: ProcessEditCtrl, templateUrl: partialsDir + 'process/edit.html' })
                .when('/process/new', { controller: ProcessNewCtrl, templateUrl: partialsDir + 'process/create.html' })
                .when('/process/:id', { controller: ProcessCtrl, templateUrl: partialsDir + 'process/show.html' })
                .otherwise({ redirectTo: '/' });
        });
//templateUrl: partialsDir+'process/show.html'