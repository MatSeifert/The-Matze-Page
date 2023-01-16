<script lang="ts">
import ProjectStatItem from "../elements/ProjectStatItem.vue";
import Masonry from "../elements/Masonry.vue";
import { TAG_DESIGN, TAG_DEV } from "@/helper/const";
import { RouterLink } from "vue-router";

export default {
  data() {
    return {
      tags: [TAG_DESIGN, TAG_DEV],
      projectName: "schicksoftware",
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
        <h2>Redesign der Homepage</h2>
        <h3>Florian Schick Softwareentwicklung</h3>
        <p>
          Florian Schick ist Berater und Softwareentwickler mit vielen Jahren Erfahrung in 
          verschiedenen Projekten. Er unterstützt seine Kunden hierbei nicht nur bei der
          Umsetzung spannender neuer Software-Ideen, sondern hilft auch dabei, bestehende
          Herausforderungen erfolgreich zu meistern. 
        </p>
      </article>
      <div class="project-stats">
        <ProjectStatItem :value="'4 Wochen'" :label="'Projektzeitraum'" />
        <ProjectStatItem :value="2023" :label="'Jahr'" />
      </div>
      <div class="project-showcase">
        <img :src="`/src/assets/images/projects/${projectName}/showcase.png`" />
      </div>
    </div>
    <div class="flex gap-top-s">
      <a
        href="https://www.schick-software.de/"
        target="_blank"
        class="no-hover-effect"
      >
        <button class="btn btn-primary">zur website</button>
      </a>
      <ProjectStatItem :value="tags" />
    </div>
  </div>

  <Masonry :projectName="projectName" :imageCount="7" />

  <RouterLink
    tag="button"
    :to="{ path: `/#projects` }"
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
