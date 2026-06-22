<script lang="ts">
import ProjectBox from "@/components/elements/ProjectBox.vue";
import projekte from "@/data/projekte.json"

export default {
  data() {
    return {
      projekte
    };
  },
  components: {
    ProjectBox
  }
};
</script>

<template>
  <h1 id="projects">projekte</h1>
  <div :class="'flex gap-top-m project-wrapper'">
    <ProjectBox
      v-for="project in projekte"
      :key="project.id"
      :project="project"
    />
  </div>
</template>

<style lang="stylus" scoped>
@import '../../styles/config.styl'

h1
  margin-bottom -.5em
  margin-top .75em

.project-wrapper
  gap 3em
  flex-wrap wrap
  position relative


  &:before, &:after
    content ''
    display block
    position absolute
    z-index -1
    border-radius 50%

  &:after
    width 150vw
    height 60em
    background primaryBlur
    transform translateX(-80vw) translateY(-10vh) rotate(10deg)
    top 5em
    opacity .4
</style>
