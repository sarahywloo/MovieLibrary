namespace MovieLibrary.Models {

    export class Movie {

        public id: number;

        public title: string;

        public duration: number;

        public rating: string;

        public releaseDate: Date;

        public description: string;

        public posterUrl: string;

        public genre: Genre;
    }
}