'use strict';

uiApp.controller('audioController', function ($scope, $location, webService, userService) {

    $scope.cmsId = userService.GetCmsId();

    if (!userService.IsLoggedIn()) {
        $location.path('/login');
    }
})