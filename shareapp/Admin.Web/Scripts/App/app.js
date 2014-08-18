'use strict';

var uiApp = angular.module('uiApp', ['ngRoute']);

uiApp.config(function ($routeProvider) {

    $routeProvider.when('/',
        {
            templateUrl: 'Templates/Index.html',
            controller: 'indexController'
        });

    $routeProvider.when('/login',
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