namespace MovieLibrary.Controllers {

    import Genre = MovieLibrary.Models.Genre;
    //import Models = MovieLibrary.Models;

    import Movie = MovieLibrary.Models.Movie;

    export class GenreListController {

        //list of genres
        public genres: Genre[]; 
        //public genres: Models.Genre[];

        constructor(private $http: ng.IHttpService) {
            
            //To ensure that the user sees ALL the movie posters in the genre list
            $http.get('/api/genres')
                .then((response) => {   //response will be a list of genres
                    //to put data into the genre variable
                    this.genres = <Genre[]>response.data;
                });
        }

    }
}