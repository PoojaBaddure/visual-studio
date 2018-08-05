'use strict';

module SpAngMvcTemplate {
    export class NavigationController {
        localLocation: any;
        localWindow: any;

        static $inject = ['$location', '$window'];

        constructor($location: ng.ILocationService, $window) {
            this.localLocation = $location;
            this.localWindow = $window;
        }

        doNavigate(page) {
            var currentRoute = this.localLocation.path().substring(1);
            if (page === currentRoute) {
                //google analytics if implemented
                //this.localWindow.ga('send', 'pageview', { 'page': this.localLocation.path() });
            };
            //sets the menu item to active
            return page === currentRoute ? 'active' : '';
        }
    }
}

angular.module("SpAngMvcTemplate").controller("NavigationController", SpAngMvcTemplate.NavigationController);