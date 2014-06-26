var BrandController = function($scope, $routeParams, $location, BrandService, Widget) {
    Widget.showLoad();
    var id = $routeParams.itemId;
    BrandService.get({ id: id }, function(data) {
        $scope.item = data;
        Widget.hideLoad();
    });
    $scope.save = function() {
        Widget.showLoad();
        BrandService.update({ id: id }, $scope.item, function() {
            $location.path('/category/' + $routeParams.redirectId);
        });
    };

};