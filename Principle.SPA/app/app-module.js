// 
// The angular.module is a global place for creating, registering and retrieving 
// Angular modules. All modules (angular core or 3rd party) that should be 
// available to an application must be registered using this mechanism.
// 
// Passing one argument retrieves an existing angular.Module, whereas passing 
// more than one argument creates a new angular.Module
// 
// Interface for configuring angular modules.

// <information>
// Main design module.
// </information>
angular.module("dpDesign",
                    [
                        // Angular modules 
                        "ngRoute",
                        //"ngMessages",

                        //// Custom modules 
                        "dpServices",
                        "dpFactories"

                        // 3rd Party Modules
                    ]);

// <information>
// Services module.
// </information>
angular.module("dpServices", []);

// <information>
// Factories module.
// </information>
angular.module("dpFactories", ["ngResource"]);

