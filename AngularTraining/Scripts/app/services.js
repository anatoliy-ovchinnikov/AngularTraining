var angularStartServices = angular.module('angularStart.services', ['ngResource']);     //Define the services module

angularStartServices.factory('CategoryService', function ($resource) {
    return $resource('/api/category/:id', { id: '@id' });
});
angularStartServices.factory('BrandService', function ($resource) {
    return $resource('/api/brand/:id', { id: '@id' }, { update: { method: 'PUT' } });
});

angularStartServices.service('Widget', function () {
    this.showLoad = function showLoad() {
        $('#myModal').show();
    };

    this.hideLoad = function hideLoad() {
        $('#myModal').hide();
    };
});