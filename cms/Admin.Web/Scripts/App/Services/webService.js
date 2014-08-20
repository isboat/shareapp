'use strict';

uiApp.factory('webService', function ($http, $q) {

    var service = {
        
        PostData: function(viewData, url) {

            var deferred = $q.defer();

            $http({ method: 'POST', url: url, data: JSON.stringify(viewData), dataType: 'json' })
                .success(function (data, status) {
                    deferred.resolve(data);
                })
                .error(function (data, status) {
                    deferred.reject(status);
                });

            return deferred.promise;
        },
        
        GetData: function(url) {
            var deferred = $q.defer();

            $http({ method: 'GET', url: url, dataType: 'json' })
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (status) {
                    deferred.reject(status);
                });
        }
    };

    return service;

});