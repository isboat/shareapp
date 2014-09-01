'use strict';

uiApp.controller('loginController', function ($scope, $location, webService, userService) {

    if (userService.IsLoggedIn()) {
        $location.path('/bccd1234/home');
    }

    $scope.loginStatus = '';
    $scope.loginMessage = 'Please sign in';
    var url = 'api/Admin/Login/';

    $scope.LoginViewData = {};

    $scope.Login = function () {
        
        if ($scope.LoginViewData && $scope.LoginViewData.Username && $scope.LoginViewData.Password) {
            webService.PostData($scope.LoginViewData, url).then(
                function(data) {
                    if (data.Success) {
                        userService.SetLogin(data);
                        userService.SetAppSettings(data);
                        $location.path('/');
                    } else {
                        $scope.loginMessage = data.Message;
                        $scope.loginStatus = 'error';
                        //uiHelper.ShowMessage({ Type: 'error', Message: data.Message });
                    }
                },
                function(status) {
                    alert(status);
                });
        } else {
            $scope.loginMessage = 'Please fill in username and password';
        }
    };
});
