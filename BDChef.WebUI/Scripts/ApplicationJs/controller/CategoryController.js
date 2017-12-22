(function () {
    'use strict';

    angular
        .module('app')
        .controller('CategoryController', CategoryController);

    CategoryController.$inject = ['$scope'];

    function CategoryController($scope) {
        $scope.title = 'CategoryController';

        activate();

        function activate() { }
    }
})();
