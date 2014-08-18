'use strict';

uiApp.controller('loginController', function ($scope, webService, userService) {

    var url = 'api/Admin/Login/';

    $scope.LoginViewData = {};

    $scope.Login = function() {
        if ($scope.LoginViewData) {
            webService.PostData($scope.LoginViewData, url).then(
                function (data) {
                    if (data.Success) {
                        userService.SetLogin(data);
                    }
                },
                function(status) {
                });
        }
    }
});
