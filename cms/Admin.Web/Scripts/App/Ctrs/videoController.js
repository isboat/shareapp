'use strict';

uiApp.controller('videoController', function ($scope, $location, webService, userService) {

    if (!userService.IsLoggedIn()) {
        $location.path('/login');
    }
    
    // intialise
    $scope.videoList = [
        { imgSrc: '', name: 'Test'}
    ];
    $scope.alertMsg = '';

    if (!$scope.videoList.length) {
        $scope.alertMsg = 'No video uploaded!';
    }
    
    // scope functions
    $scope.closeAlert = function() {
        $scope.alertMsg = '';
    };
})