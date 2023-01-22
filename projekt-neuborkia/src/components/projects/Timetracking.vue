<script lang="ts">
import ProjectHeader from '../elements/ProjectHeader.vue'
import Masonry from "../elements/Masonry.vue";
import { TAG_DESIGN } from "@/helper/const";
import { RouterLink } from "vue-router";

export default {
  data() {
    return {
      tags: [TAG_DESIGN],
      projectName: "timetracking"
    };
  },
  components: {
    ProjectHeader,
    Masonry,
  },
};
</script>

<template>
  <ProjectHeader :projectName="projectName"
                 :headline="'Redesign inklusive Design System'"
                 :subHeadline="'TimeTracking Zeiterfassungstool'"
                 :abstract="'Wer seine Arbeitszeiten erfassen muss weiß wie mühselig das sein kann. Das Zeiterfassungstool von Florian Schick schafft hier Abhilfe, denn damit ist die Zeiterfassung nicht nur kinderleicht, sondern auch übersichtlich und klar. Die Software ist Open Source und kann von jedem konstenfrei verwendet werden.'"
                 :timespan="'5 Monate'"
                 :year="'2022'"
                 :tags="tags"
                 :linkTarget="'https://demo.timetracking.schick-software.de/'"
                 :linkTargetSecondary="'https://github.com/fschick/TimeTracking'"
                 :buttonLabel="'Demo anschauen'"
                 :buttonLabelSecondary="'Github Projekt'" />

  <Masonry :projectName="projectName" :imageCount="7" />
  <Masonry :projectName="projectName" :imageCount="4" :title="'design system'" :fileNamePrefix="'ds_'" />

  <RouterLink
    :to="{  path: '/', hash: '#projects' }"
    class="no-hover-effect block text-center"
  >
    <button class="btn btn-primary">Zurück zur Übersicht</button>
  </RouterLink>
</template>

<style lang="stylus" scoped>
    .flex
        justify-content space-between
        position relative
</style>
