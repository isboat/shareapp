﻿'use strict';

uiApp.controller('indexController', function ($scope, $location, webService, userService) {

    $scope.cmsId = userService.GetCmsId();

    if (!userService.IsLoggedIn()) {
        $location.path( '/login');
    }

    $scope.menuItems = appSettings.MenuItems;
    var path = $location.$$path.split('/');
    $scope.curPage = path[2];


})