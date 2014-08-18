'use strict';

uiApp.controller('indexController', function ($scope, $location, webService, userService) {

    if (!userService.IsLoggedIn()) {
        $location.path('/login');
    }
})