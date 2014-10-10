'use strict';

uiApp.controller('menuBarController', function ($scope, $location, userService) {

    $scope.cmsId = userService.GetCmsId();

    if (!userService.IsLoggedIn()) {
        $location.path('/login');
    }

    $scope.menuItems = appSettings.MenuItems;
    var path = $location.$$path.split('/');
    $scope.curPage = path[2];


})