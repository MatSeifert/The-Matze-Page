<script lang="ts">
import ProjectBox from "./ProjectBox.vue";
import { TAG_DESIGN, TAG_DEV } from "../helper/const.js";

export default {
  data() {
    return {
      projects: {
        florianschick: {
          id: "florianschick",
          year: "2023",
          tags: [TAG_DESIGN],
          title: "Redesign",
          subTitle: "Website für Schick Software"
        },
        mtbsport: {
          id: "mtbsport",
          year: "2022",
          tags: [TAG_DESIGN, TAG_DEV],
          title: "Design und Umsetzung",
          subTitle: "Website für MTB Sport Hänel",
        },
        timetracking: {
          id: "timetracking",
          year: "2022",
          tags: [TAG_DESIGN],
          title: "Redesign",
          subTitle: "Zeiterfassungs Tool",
        },
        podicons: {
          id: "podicons",
          year: "2019",
          tags: [TAG_DESIGN],
          title: "Icon Design",
          subTitle: "Iconset für eine podologische Praxis",
        },
      },
    };
  },
  components: {
    ProjectBox,
  },
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
        filter blur(3em)

    &:before
        width 60vw
        height 30em
        background secondaryColor
        right -20vw
        top -5em
        opacity .3
        transform rotate(-15deg)

    &:after
        width 90vw
        height 30em
        background primaryColor
        right -40vw
        top 10em
        opacity .3
        transform rotate(10deg)
</style>
