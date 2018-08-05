var SpAngMvcTemplate;
(function (SpAngMvcTemplate) {
    var MenuItem1Controller = (function () {
        // construct using dependencies and allocate to local members
        function MenuItem1Controller() {
            this.panelItem = {
                bodyMessage: "The Parliament's systems have been built using a variety of wide ranging and third party systems and so there could be times when some of our data appears to be inconsistent. For example there might be multiple entries in the same dataset or very occasionally there may be some content that is incorrect. Another project is running that will correct these issues and we will update any errors as soon as we can.",
                titleMessage: "SP Menu Item 1:"
            };
        }
        MenuItem1Controller.$inject = [];
        return MenuItem1Controller;
    })();
    SpAngMvcTemplate.MenuItem1Controller = MenuItem1Controller;
})(SpAngMvcTemplate || (SpAngMvcTemplate = {}));
;
angular.module('SpAngMvcTemplate').controller('MenuItem1Controller', SpAngMvcTemplate.MenuItem1Controller);
//# sourceMappingURL=menuItem1Controller.js.map