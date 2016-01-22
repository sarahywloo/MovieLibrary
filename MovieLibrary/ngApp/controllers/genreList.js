var MovieLibrary;
(function (MovieLibrary) {
    var Controllers;
    (function (Controllers) {
        var GenreListController = (function () {
            //public genres: Models.Genre[];
            function GenreListController($http) {
                var _this = this;
                this.$http = $http;
                //To ensure that the user sees ALL the movie posters in the genre list
                $http.get('/api/genres')
                    .then(function (response) {
                    //to put data into the genre variable
                    _this.genres = response.data;
                });
            }
            return GenreListController;
        })();
        Controllers.GenreListController = GenreListController;
    })(Controllers = MovieLibrary.Controllers || (MovieLibrary.Controllers = {}));
})(MovieLibrary || (MovieLibrary = {}));
//# sourceMappingURL=genreList.js.map