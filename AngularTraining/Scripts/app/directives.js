var angularStartDirectives = angular.module('angularStart.directives', []);

angularStartDirectives.directive('backButton', ['$location', 'Widget', '$routeParams', function ($location, Widget, $routeParams) {
    return {
        restrict: 'A',
        link: function ($scope, element, attrs) {
            element.bind('click', function () {

                $scope.$apply(function () {
                    Widget.showLoad();
                    $location.path('/category/' + $routeParams.redirectId);
                });
            });
        },

    };
}]);

angularStartDirectives.directive('editBrandInfo', function () {
    return {
        restrict: 'E',
        template: '<div class="control-group"><label class="control-label" for="ImageUrl">Image</label><div class="controls"><img ng-src="{{item.ImageUrl}}" width="150" height="150" id="ImageUrl" /></div><br /><label class="control-label" for="Title">Title</label><div class="controls"><input type="text" ng-model="item.Title" id="Title" required="" name="title"></div></div>'
    };
});

angularStartDirectives.directive('editBrandControls', function () {
    return {
        restrict: 'E',
        template: '<div class="form-actions"><button class="btn btn-primary" ng-click="form.title.$valid && save()">Update</button> <input type="button" id="btnCancel" class="btn btn-danger" value="Cancel" data-back-button /></div>'
    };
});

angularStartDirectives.directive('brandListView', function () {
    return {
        restrict: 'E',
        template: '<a href="#/edit/{{ brand.Id }}/redirect/{{ redirectTo }}" class="thumbnail" id="brandItem">' +
                        '<img src="{{brand.ImageUrl}}" />' +
                        '<div class="caption">' +
                            '{{ brand.Title }}' +
                        '</div>' +
                  '</a>'
    };
});

angularStartDirectives.directive('categoryListView', function () {
    return {
        restrict: 'E',
        template: '<div class="row-fluid"><img ng-src="{{category.ImageUrl}}" width="50" height="50" style="padding-right: 7px" />{{ category.Title }}</div>'
    };
});