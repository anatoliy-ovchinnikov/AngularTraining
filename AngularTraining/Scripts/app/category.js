var CategoryController = function($scope, $location, CategoryService, $routeParams, Widget) {
    $scope.listCategory = CategoryService.query();
    $scope.redirectTo = $routeParams.selectedId || 1;

    $scope.show_brands = function(id) {
        Widget.showLoad();
        CategoryService.get({ id: id }, function(data) {

            $scope.listBrands = data.Brands;
            $scope.selectCategory = data.Title;
            $scope.redirectTo = data.Id;
            Widget.hideLoad();
        }, function() {
            Widget.hideLoad();
        });
    };

    $scope.show_brands($scope.redirectTo);
};