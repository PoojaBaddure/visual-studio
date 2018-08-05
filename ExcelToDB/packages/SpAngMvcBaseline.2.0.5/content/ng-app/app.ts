﻿
angular.module('SpAngMvcTemplate', ['ngResource', 'ngRoute', 'ui.bootstrap']);

// config
angular.module('SpAngMvcTemplate')
    .config(['$routeProvider', ($routeProvider: ng.route.IRouteProvider) => {
            $routeProvider.
                when('/home',
                    {
                        templateUrl: '/App/Home',
                        controller: 'HomeController',
                        controllerAs: 'HomeVM'
                    }
                    ).
                when('/menuitem1',
                    {
                        templateUrl: '/App/MenuItem1',
                        controller: 'MenuItem1Controller',
                        controllerAs: 'MenuItem1VM'
                    }
                    ).
                otherwise(
                    { redirectTo: '/home' }
                    );
        }
    ]); 