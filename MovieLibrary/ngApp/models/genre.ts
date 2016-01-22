namespace MovieLibrary.Models {

    export class Genre {

        public id: number;

        public name: string;

        //if we want to reference movie, we need to import movie (see above)
        public movies: Movie[];
    }
}