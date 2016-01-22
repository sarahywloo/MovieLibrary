namespace MovieLibrary {

    angular.module("MovieLibrary", ['ngRoute'])
        .config(function ($routeProvider: ng.route.IRouteProvider) {
            //$routeProvider.when('/', {
            // templateUrl: '/path/to/view',
            // controller: MovieLibrary.Controllers.ControllerClass,
            // controllerAs: 'views variable name for controller'
            //});
            $routeProvider.when('/', {
                templateUrl: '/ngApp/views/genreList.html',
                controller: MovieLibrary.Controllers.GenreListController,
                controllerAs: 'controller'
            });

        });
}