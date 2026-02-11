<script lang="ts">
import ProjectHeader from "@/components/elements/ProjectHeader.vue";
import Masonry from "@/components/elements/Masonry.vue";
import { TAG_DESIGN, TAG_DEV } from "@/helper/const";

export default {
  data() {
    return {
      tags: [TAG_DESIGN, TAG_DEV],
      projectName: "pommereningconsulting"
    };
  },
  components: {
    ProjectHeader,
    Masonry
  }
};
</script>

<template>
    <ProjectHeader :projectName="projectName"
                :headline="'Konzeption und Umsetzung Website'"
                :subHeadline="'Praxisnahe DevOps-Lösungen für Ihr Unternehmen – modern, innovativ und nachhaltig.'"
                :abstract="'Frank Pommerening unterstützt auch Ihr Unternehmen professionell rund um das Thema DevOps. Mit Technologien wie Kubernetes zur effizienten Orchestrierung von Containern bis hin zu Blazor-Anwendungen für schnelle und stabile Umsetzungen ist alles dabei.'"
                :timespan="'aktiv'"
                :year="'ab 2025'"
                :tags="tags"
                :linkTarget="'https://pommerening-consulting.de/'" />

               
  <Masonry :projectName="projectName" :imageCount="4" :fileType="'webp'"/>

  <RouterLink
    :to="{  path: '/', hash: '#projects' }"
    class="no-hover-effect block text-center"
  >
    <button class="btn btn-primary">Zurück zur Übersicht</button>
  </RouterLink>
</template>

<style scoped lang="stylus">

</style>