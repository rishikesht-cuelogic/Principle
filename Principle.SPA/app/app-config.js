angular.module("dpDesign")
       .config(function ($routeProvider) {

           $routeProvider
               .when("/home", {
                   templateUrl: "app/components/home/home.html",
                   controller: "HomeController",
                   controllerAs: 'vm'
               })
               .when("/info", {
                   templateUrl: "app/components/info/info.html",
                   controller: "InfoController",
                   controllerAs: 'vm'
               })
               .otherwise({
                   // default page
                   redirectTo: "/home"
               })
       });