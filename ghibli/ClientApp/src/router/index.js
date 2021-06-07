﻿import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import Movies from "@/components/Movies.vue";
import Movie from "@/components/Movie.vue";

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Counter",
        name: "Counter",
        component: Counter,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
    {
        path: "/Movies",
        name: "Movies",
        component: Movies
    },
    {
        path: "/Movies/:movieId",
        name: "Movie",
        component: Movie
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;