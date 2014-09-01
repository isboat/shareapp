'use strict';

uiApp.controller('videoController', function ($scope, $location, webService, userService) {

    if (!userService.IsLoggedIn()) {
        $location.path('/login');
    }

    $scope.menuItems = appSettings.MenuItems;
    var path = $location.$$path.split('/');
    $scope.curPage = path[2];


})