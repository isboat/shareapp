'use strict';

uiApp.controller('indexController', function ($scope, $location, webService, userService) {

    $scope.cmsId = userService.GetCmsId();

    if (!userService.IsLoggedIn()) {
        $location.path( '/login');
    }

    $scope.save = function () {
        console.log($scope.OrgViewData);
    };

    $scope.change = function() {
        console.log("sfsdf");
    };
})