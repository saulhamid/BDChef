(function () {
    'use strict';

    angular
        .module('app')
        .config( config);

    config.$inject = ['$stateProvider', '$httpProvider', '$locationProvider', '$urlRouterProvider'];

    function config( $stateProvider, $httpProvider, $locationProvider, $urlRouterProvider) {
        $locationProvider.hashPrefix('!').html5Mode(true);
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
        $stateProvider
            .state('home',
            {
                url: '/home',
                templateUrl: '/Max/home',
                controller: 'homeController'
            }).state('Category',
            {
                url: '/Category',
                templateUrl: '/Max/Category',
                controller: 'CategoryController'
            }).state('Vendor',
            {
                url: '/Vendor',
                templateUrl: '/Max/Vendor',
                controller: 'VendorController'
            }).state('Customer',
            {
                url: '/Customer',
                templateUrl: '/Max/Customer',
                controller: 'homeController'
            })
        $urlRouterProvider.otherwise("home");
    }
})();