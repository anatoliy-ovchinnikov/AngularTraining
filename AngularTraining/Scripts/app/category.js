var CategoryController = function($scope, $location, CategoryService, $routeParams, Widget) {
    $scope.listCategory = CategoryService.query({ categoryId: 2 });
    $scope.redirectTo = $routeParams.selectedId || 0;

    $scope.show_brands = function(id) {
        Widget.showLoad();
        CategoryService.get({ id: id }, function(data) {

            $scope.listBrands = data.Brands;
            $scope.selectCategory = data.Title;
            $scope.redirectTo = data.Id;
            Widget.hideLoad();
        });
    };

    $scope.show_brands($scope.redirectTo);
};