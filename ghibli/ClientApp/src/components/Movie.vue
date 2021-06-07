<template>
<h1>{{movie.title}}</h1>
</template>
<script>
import axios from 'axios'

export default {
    name: "Movie",
    created(){
        console.log('route', this.$route)
        console.log(this.$route.params.movieId)
    },
    data(){
        return{
            movie: [],
            movieId: this.$route.params.movieId
        }
    },
    methods: {
        getMovie(){
            axios.get('/api/film/'+this.movieId)
            .then((response) => {
                this.movie = response.data;
            })
            .catch(function (error){
                console.log(error);
            });
        }
    },
    mounted(){
        this.getMovie();
    }
}
</script>
<style scoped>

</style>