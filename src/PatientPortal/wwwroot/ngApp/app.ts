namespace PatientPortal {

    angular.module('PatientPortal', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/home.html',
                controller: PatientPortal.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('mdLogin', {
                url: '/mdLogin',
                templateUrl: '/ngApp/mdLogin.html',
                controller: PatientPortal.Controllers.MDLoginController,
                controllerAs: 'controller'
            })
            .state('dashboard', {
                url: '/dashboard/:id',
                templateUrl: '/ngApp/dashboard.html',
                controller: PatientPortal.Controllers.DashController,
                controllerAs: 'controller'
            })
            .state('patientRegistration', {
                url: '/patientRegistration',
                templateUrl: '/ngApp/patientRegistrationForm.html',
                controller: PatientPortal.Controllers.PatientRegistrationController,
                controllerAs: 'controller'
            })
            .state('medRecords', {
                url: '/medRecords',
                templateUrl: '/ngApp/medRecords.html',
                controller: PatientPortal.Controllers.MedRecordsController,
                controllerAs: 'controller'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

}
