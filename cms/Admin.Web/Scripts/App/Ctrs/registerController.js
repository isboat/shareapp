'use strict';

uiApp.controller('registerController', function ($scope, $location, webService, userService) {

    if (userService.IsLoggedIn()) {
        $location.path('/abcd1234/home');
        return;
    }

    $scope.registerStatus = '';
    $scope.registerMessage = 'Please register';
    var postUrl = 'api/Admin/Register/';

    $scope.ViewData = {};

    $scope.SubmitRegister = function () {

        if (!$scope.ViewData || !$scope.ViewData.Orgname || !$scope.ViewData.Username || !$scope.ViewData.Password) {
            return;
        }

        if ($scope.ViewData.Password != $scope.ConfirmPassword) {
            $scope.registerMessage = 'Password doesn\'t match the confirmation.';
            return;
        }
        
        if ($scope.ViewData) {
            webService.PostData($scope.ViewData, postUrl).then(
                function (data) {
                    if (data && data.Success) {
                        $location.path('/:' + data.OrgId + '/home');
                    } else {
                        $scope.registerMessage = data.Message;
                    }
                },
                function(status) {
                }
            );
        }
    };
});