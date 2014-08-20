'use strict';

uiApp.controller('registerController', function ($scope, webService, userService) {

    if (userService.IsLoggedIn()) {
        $location.path('/');
    }
    
    var postUrl = 'api/Admin/Register/';

    $scope.ViewData = {};

    $scope.SubmitRegister = function () {
        if ($scope.ViewData.Password != $scope.ConfirmPassword) {
            uiHelper.ShowMessage({ Type: 'error', Message: 'Password doesn\'t match the confirmation.' });
            return;
        }
        
        if ($scope.ViewData) {
            webService.PostData($scope.ViewData, postUrl).then(
                function(data) {
                },
                function(status) {
                }
            );
        }
    };
});