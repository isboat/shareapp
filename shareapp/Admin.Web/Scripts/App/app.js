'use strict';

var uiApp = angular.module('app', ['ngRoute'])

uiApp.config(function ($routeProvider) {

    $routeProvider.when('/',
        {
            templateUrl: 'Templates/Login.html',
            controller: 'loginController'
        });

    $routeProvider.when('/register',
        {
            templateUrl: 'Templates/Register.html',
            controller: 'registerController'
        });

    $routeProvider.otherwise({ redirectTo: '/' });

});

uiApp.run(function () { });