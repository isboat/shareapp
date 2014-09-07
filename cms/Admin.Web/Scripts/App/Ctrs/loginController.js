'use strict';

uiApp.controller('loginController', function ($scope, $location, webService, userService) {

    $scope.cmsId = userService.GetCmsId();

    if (userService.IsLoggedIn()) {
        $location.path('/' + $scope.cmsId+ '/home');
    }

    $scope.loginStatus = '';
    $scope.loginMessage = 'Please sign in';
    var url = 'api/Admin/Login/';

    $scope.LoginViewData = {};

    $scope.Login = function () {
        
        if ($scope.LoginViewData && $scope.LoginViewData.Username && $scope.LoginViewData.Password) {
            uiHelper.ShowLoading();
            webService.PostData($scope.LoginViewData, url).then(
                function (data) {
                    uiHelper.HideLoading();
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
                function (status) {
                    uiHelper.HideLoading();
                    alert(status);
                });
        } else {
            $scope.loginMessage = 'Please fill in username and password';
        }
    };
});
