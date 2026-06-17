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
  padding-top 1em

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

  &:before
    width 120vw
    height 60em
    background secondaryBlur
    right -40vw
    top -20em
    opacity .4
    transform rotate(-15deg)

  &:after
    width 150vw
    height 40em
    background primaryBlur
    right -80vw
    top 5em
    opacity .4
    transform rotate(10deg)
</style>
