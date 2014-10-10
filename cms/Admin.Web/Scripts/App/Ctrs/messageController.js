'use strict';

uiApp.controller('messageController', function ($scope, $location, webService, userService) {

    $scope.cmsId = userService.GetCmsId();

    if (!userService.IsLoggedIn()) {
        $location.path('/login');
    }
})