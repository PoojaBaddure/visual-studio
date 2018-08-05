
module SpAngMvcTemplate {
    export class HomeController {
        panelItem: IPanel;

        static $inject = [];

        // construct using dependencies and allocate to local members
        constructor() {
            this.panelItem = {
                bodyMessage: "The Parliament has a strong reputation for openness and accessibility, based on its founding principles and its policies and practices. We want to use developments in digital technology to continue to deliver on these core values.",
                titleMessage: "Home Title:"
            }
        }
    }
};

angular.module('SpAngMvcTemplate').controller('HomeController', SpAngMvcTemplate.HomeController);