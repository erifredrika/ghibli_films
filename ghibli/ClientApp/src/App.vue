<template>
  <nav-menu></nav-menu>
    <main class="main pt-4">
      <transition name="fade">
        <router-view />
      </transition>
    </main>
</template>

<script>
    import NavMenu from './components/NavMenu.vue'

export default {
  name: 'App',
  components: {
      NavMenu
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Lora&family=Montserrat:wght@100;300&display=swap');

#app {
  font-family: 'Montserrat', Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
.card-title, h4{
font-family: 'Lora', serif;
font-weight: 500;
}
a {
  color: black;
}
a:hover{
  text-decoration: none;
  color:grey;
}
</style>
