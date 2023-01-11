<script lang="ts">
import Hero from "./Hero.vue";
import AboutMe from "./AboutMe.vue";
import Projects from "./Projects.vue";

export default {
  components: {
    Hero,
    AboutMe,
    Projects,
  },
};
</script>

<template>
  <Hero />

  <AboutMe />
  <Projects />
</template>
