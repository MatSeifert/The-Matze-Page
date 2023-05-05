<script lang="ts">
import ProjectHeader from "@/components/elements/ProjectHeader.vue";
import Masonry from "@/components/elements/Masonry.vue";
import { TAG_DESIGN } from "@/helper/const";
import { RouterLink } from "vue-router";

export default {
  data() {
    return {
      tags: [TAG_DESIGN],
      projectName: "schicksoftware",
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
                 :headline="'Redesign der Homepage'"
                 :subHeadline="'Florian Schick Softwareentwicklung'"
                 :abstract="'Florian Schick ist Berater und Softwareentwickler mit vielen Jahren Erfahrung in verschiedenen Projekten. Er unterstützt seine Kunden hierbei nicht nur bei der Umsetzung spannender neuer Software-Ideen, sondern hilft auch dabei, bestehende Herausforderungen erfolgreich zu meistern. '"
                 :timespan="'3 Monate'"
                 :year="'2023'"
                 :tags="tags"
                 :linkTarget="'https://www.schick-software.de/'" />

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
