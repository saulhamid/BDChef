(function () {
    'use strict';

    angular
        .module('app')
        .controller('VendorController', VendorController);

    VendorController.$inject = ['$scope'];

    function VendorController($scope) {
        $scope.title = 'VendorController';

        activate();

        function activate() { }
    }
})();
