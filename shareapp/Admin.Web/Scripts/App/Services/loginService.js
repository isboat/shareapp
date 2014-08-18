'use strict';

uiApp.factory('loginService', function ($http, $q) {

    var service = {

        Login: function () {

            var deferred = $q.defer();
            
            var post = {
                Username: "fdsf",
                Password: "dfdfs"
            };
            
            $http({ method: 'POST', url: 'api/Admin/Login/', data: JSON.stringify(post), dataType: 'json' })
                .success(function (data, status) {
                    console.log(data);
                })
                .error(function (data, status) {
                    deferred.reject(status);
                });

            return deferred.promise;
        }
    }

    return service;

});