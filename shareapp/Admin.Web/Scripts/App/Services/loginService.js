'use strict';

uiApp.factory('loginService', function ($http, $q) {

    var service = {

        Login: function () {

            //var deferred = $q.defer();
            var post = "dsfsf";
            $http({
                method: 'GET',
                url: 'api/Admin/Login/'
            }).success(function (data, status) {
                //deferred.resolve(data);
            })
            .error(function (data, status) {
                //defferred.reject(status);
            });

            return //deferred.promise;
        }
    }

    return service;

});