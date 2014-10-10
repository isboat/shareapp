'use strict';

var uiApp = angular.module('uiApp', ['ui.bootstrap', 'ngRoute', 'ngSanitize', 'ngAnimate']);

uiApp.config(function ($routeProvider) {

    $routeProvider.when('/:id/home',
        {
            templateUrl: 'Templates/Index.html',
            controller: 'indexController'
        });

    $routeProvider.when('/:id/video',
        {
            templateUrl: 'Templates/Video.html',
            controller: 'videoController'
        });

    $routeProvider.when('/:id/audio',
        {
            templateUrl: 'Templates/Audio.html',
            controller: 'audioController'
        });

    $routeProvider.when('/:id/message',
        {
            templateUrl: 'Templates/Message.html',
            controller: 'messageController'
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

    $routeProvider.otherwise({ redirectTo: '/login' });

});

uiApp.run(function () { });