'use strict';

uiApp.controller('loginController', function ($scope, $location, webService, userService) {

    if (userService.IsLoggedIn()) {
        $location.path('/');
    }

    var url = 'api/Admin/Login/';

    $scope.LoginViewData = {};

    $scope.Login = function() {
        if ($scope.LoginViewData) {
            webService.PostData($scope.LoginViewData, url).then(
                function(data) {
                    if (data.Success) {
                        userService.SetLogin(data);
                        $location.path('/');
                    } else {
                        uiHelper.ShowMessage({ Type: 'error', Message: data.Message });
                    }
                },
                function(status) {
                    alert(status);
                });
        }
    };
});
