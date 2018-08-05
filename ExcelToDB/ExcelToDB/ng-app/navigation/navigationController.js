'use strict';
var SpAngMvcTemplate;
(function (SpAngMvcTemplate) {
    var NavigationController = (function () {
        function NavigationController($location, $window) {
            this.localLocation = $location;
            this.localWindow = $window;
        }
        NavigationController.prototype.doNavigate = function (page) {
            var currentRoute = this.localLocation.path().substring(1);
            if (page === currentRoute) {
            }
            ;
            //sets the menu item to active
            return page === currentRoute ? 'active' : '';
        };
        NavigationController.$inject = ['$location', '$window'];
        return NavigationController;
    })();
    SpAngMvcTemplate.NavigationController = NavigationController;
})(SpAngMvcTemplate || (SpAngMvcTemplate = {}));
angular.module("SpAngMvcTemplate").controller("NavigationController", SpAngMvcTemplate.NavigationController);
//# sourceMappingURL=navigationController.js.map