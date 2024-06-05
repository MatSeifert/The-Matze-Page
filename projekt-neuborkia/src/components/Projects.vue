<script lang="ts">
import ProjectBox from "./ProjectBox.vue";
import { TAG_DESIGN, TAG_DEV } from "../helper/const.js";

export default {
  data() {
    return {
      projects: {
        plainquire: {
          id: "plainquire",
          year: "2024",
          tags: [TAG_DESIGN],
          title: "Plainquire",
          subTitle: "Design der Landing Page"
        },
        schicksoftware: {
          id: "schicksoftware",
          year: "2023",
          tags: [TAG_DESIGN],
          title: "Schick Software",
          subTitle: "Design der Website"
        },
        mtbsport: {
          id: "mtbsport",
          year: "2022",
          tags: [TAG_DESIGN, TAG_DEV],
          title: "MTB Sport Hänel",
          subTitle: "Design und Umsetzung der Website"
        },
        timetracking: {
          id: "timetracking",
          year: "2022",
          tags: [TAG_DESIGN],
          title: "Time Tracking",
          subTitle: "Redesign der Webapp"
        },
        podicons: {
          id: "podicons",
          year: "2019",
          tags: [TAG_DESIGN],
          title: "Podicons",
          subTitle: "Iconset für eine podologische Praxis"
        }
      }
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
      v-for="project in projects"
      :key="project.id"
      :project="project"
    />
  </div>
</template>

<style lang="stylus" scoped>
@import '../assets/config.styl'

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
