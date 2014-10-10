'use strict';

uiApp.controller('videoController', function ($scope, $location, webService, userService) {

    if (!userService.IsLoggedIn()) {
        $location.path('/login');
    }
})