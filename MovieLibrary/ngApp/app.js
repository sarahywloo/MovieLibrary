var MovieLibrary;
(function (MovieLibrary) {
    angular.module("MovieLibrary", ['ngRoute'])
        .config(function ($routeProvider) {
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
})(MovieLibrary || (MovieLibrary = {}));
//# sourceMappingURL=app.js.map