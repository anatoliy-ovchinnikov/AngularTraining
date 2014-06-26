var appRoot = angular.module('main', ['ngRoute', 'ngResource', 'angularStart.services', 'angularStart.directives']);

appRoot
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/category/:selectedId', { templateUrl: '/home/category', controller: CategoryController })
            .when('/edit/:itemId/redirect/:redirectId', { templateUrl: '/home/edit', controller: BrandController })
            .otherwise({ redirectTo: '/category/:selectedId' });
    }]);

var appRootWithoutMVC = angular.module('mainIndex', ['ngRoute', 'ngResource', 'angularStart.services', 'angularStart.directives']);

appRootWithoutMVC
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/category/:selectedId', { templateUrl: 'category.html', controller: CategoryController })
            .when('/edit/:itemId/redirect/:redirectId', { templateUrl: 'brand.html', controller: BrandController })
            .otherwise({ redirectTo: '/category/:selectedId' });
    }]);