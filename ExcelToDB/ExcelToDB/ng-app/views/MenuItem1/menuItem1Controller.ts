
module SpAngMvcTemplate {
    export class MenuItem1Controller {
        panelItem: IPanel;

        static $inject = [];

        // construct using dependencies and allocate to local members
        constructor() {
            this.panelItem = {
                bodyMessage: "The Parliament's systems have been built using a variety of wide ranging and third party systems and so there could be times when some of our data appears to be inconsistent. For example there might be multiple entries in the same dataset or very occasionally there may be some content that is incorrect. Another project is running that will correct these issues and we will update any errors as soon as we can.",
                titleMessage: "SP Menu Item 1:"
            }
        }
    }
};

angular.module('SpAngMvcTemplate').controller('MenuItem1Controller', SpAngMvcTemplate.MenuItem1Controller);