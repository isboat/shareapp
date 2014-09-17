'use strict';

app.controller('searchController', function ($scope) {

    // init
    $scope.SearchText = '';

    $scope.search = function () {
        if ($scope.SearchText.length > 4);
        {
            console.log(3);
        }
    };
});