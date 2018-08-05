var SpAngMvcTemplate;
(function (SpAngMvcTemplate) {
    var HomeController = (function () {
        // construct using dependencies and allocate to local members
        function HomeController() {
            this.panelItem = {
                bodyMessage: "The Parliament has a strong reputation for openness and accessibility, based on its founding principles and its policies and practices. We want to use developments in digital technology to continue to deliver on these core values.",
                titleMessage: "Home Title:"
            };
        }
        HomeController.$inject = [];
        return HomeController;
    })();
    SpAngMvcTemplate.HomeController = HomeController;
})(SpAngMvcTemplate || (SpAngMvcTemplate = {}));
;
angular.module('SpAngMvcTemplate').controller('HomeController', SpAngMvcTemplate.HomeController);
//# sourceMappingURL=homeController.js.map