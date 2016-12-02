(function () {
    var app = angular.module('store', []);

    app.controller('StoreController', function ($scope, $http) {
        $http.get("getGems").then(function (response) {
            $scope.newProducts = response.data;
        });
    });

})();