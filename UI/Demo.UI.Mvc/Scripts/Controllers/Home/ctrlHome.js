define(['angularAMD'],
    function (angularAMD) {
        angularAMD.controller('ctrlHome',
            function ($scope, $http, $filter, $state) {
                var ng = $scope;

            ng.showFormLogin = true;

            ///
            /// Initialize function
            ///
            ng.init = function () {
                ng.msgAngular = "Welcome the system!";
            };


            ng.login = function () {
                // TODO: Validation of user here!

                $state.go('maps');
            };

            ///
            ///Initialize controller
            ///
            ng.init();
        });
    });

