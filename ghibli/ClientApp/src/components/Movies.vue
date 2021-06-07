<template>
    <div class="container">
        <h1 id="movieLabel">Movies</h1>
        <p v-if="!movies"><em>Loading...</em></p>        
        <div class="card-columns">
            <article v-for="movie of movies" v-bind:key="movie.id" class="card p-3">
                <header class="card-header">
                    <div class="card-meta"></div>
                    <a href="">
                        <h4 class="card-title">
                            {{ movie.title }}
                        </h4>
                    </a>
                </header>
                <a href="">
                    <img :src="this.appendImage(movie.id)" class="card-img" />
                </a>
                <div class="card-body">
                    <p class="card-text">
                        {{movie.description}}
                    </p>
                </div>
            </article>
        </div>
    </div>
</template>
<script>
    import axios from 'axios'
    import { Images } from '../images'

export default {
    name: "Movies",
    data(){
        return{
            movies: [],
            images: Images,
            noImg: '/img/resetImg.73bc2902.png'
        }
    },
    methods: {
        getMovies(){
            axios.get('/api/film')
            .then((response) => {
                this.movies = response.data;
            })
            .catch(function (error){
                console.log(error);
            });
        },
        appendImage(id){        
            var img = Images.filter(function (item){
                if(item.movie_id == id){
                    return item;
                }
            });
            console.log(img);

            if(img[0] != undefined)
                return img[0].img;
            
            else return this.noImg;
        }
    },
    mounted(){
        this.getMovies();
    }
}
</script>
<style>
.card{
    background-clip: border-box;
    border: 0 solid rgba(0,0,0,.125);
    border-radius: 0;
    border-bottom:1px solid rgba(0,0,0,.1);
}
.card-img{
    width: 100%;
    border-radius: 0;
}
.card-header{
    padding: .75rem 1.5rem;
    margin-bottom: 0;
    background-color: #fff;
    border-bottom: 0 solid rgba(0,0,0,.125);
}
</style>
