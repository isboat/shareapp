'use strict';

var app = angular.module('app', ['ngRoute', 'ngSanitize']);

app.config(function ($routeProvider) {
    $routeProvider.when('/:id/home', {
        templateUrl: 'Templates/Home.html',
        controller: 'homeController'
    });
    
    $routeProvider.when('/search', {
        templateUrl: 'Templates/Search.html',
        controller: 'searchController'
    });

    $routeProvider.otherwise({ redirectTo: '/search' });
});

app.run(function($rootScope) {
    console.log($rootScope);
});