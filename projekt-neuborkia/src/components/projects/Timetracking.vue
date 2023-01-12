<script lang="ts">
import ProjectStatItem from "../elements/ProjectStatItem.vue";
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
    ProjectStatItem,
    Masonry,
  },
};
</script>

<template>
  <div class="project-overview gap-top-l">
    <div class="flex">
      <article class="project-abstract">
        <h2>Redesign inklusive Design System</h2>
        <h3>TimeTracking Zeiterfassungstool</h3>
        <p>
          Wer seine Arbeitszeiten erfassen muss weiß wie mühselig das sein kann. Das 
          Zeiterfassungstool von Florian Schick schafft hier Abhilfe, denn damit ist die
          Zeiterfassung nicht nur kinderleicht, sondern auch übersichtlich und klar. Die
          Software ist Open Source und kann von jedem konstenfrei verwendet werden.
        </p>
      </article>
      <div class="project-stats">
        <ProjectStatItem :value="'5 Monate'" :label="'Projektzeitraum'" />
        <ProjectStatItem :value="2022" :label="'Jahr'" />
      </div>
      <div class="project-showcase">
        <img :src="`/src/assets/images/projects/${projectName}/showcase.png`" />
      </div>
    </div>
    <div class="flex gap-top-s">
      <div>
        <a
          href="https://demo.timetracking.schick-software.de/"
          target="_blank"
          alt="Zur Demo der Zeiterfassung"
          class="no-hover-effect"
        >
          <button class="btn btn-primary">Demo anschauen</button>
        </a>
        <a
          href="https://github.com/fschick/TimeTracking"
          target="_blank"
          alt="Zum Source Code des Tools bei Github"
          class="no-hover-effect gap-horizontal-m "
        >
          <button class="btn btn-secondary">Github Projekt</button>
        </a>
      </div>
      <ProjectStatItem :value="tags" />
    </div>
  </div>

  <Masonry :projectName="projectName" :imageCount="7" />
  <Masonry :projectName="projectName" :imageCount="4" :title="'Design System'" :fileNamePrefix="'ds_'" />

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
