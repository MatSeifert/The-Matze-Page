<script lang="ts">
import ProjectHeader from "@/components/elements/ProjectHeader.vue";
import Masonry from "@/components/elements/Masonry.vue";
import { TAG_DESIGN } from "@/helper/const";

export default {
  data() {
    return {
      tags: [TAG_DESIGN],
      projectName: "plainquire"
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
                 :headline="'Design der Landing Page und Website'"
                 :subHeadline="'Plainquire – C# Software Bibliothek'"
                 :abstract="'Mit Plainquire wird die Datenabfrage aus angebundenen Datenbanken spielend einfach. Statt mühsam Code in Datenabfragen zu übersetzen kann mit Plainquire direkt im Code eine Query zusammengebaut werden, in der beispielsweise auch direkt gefiltert oder sortiert werden kann.'"
                 :timespan="'2 Monate'"
                 :year="'2024'"
                 :tags="tags"
                 :linkTarget="'https://www.plainquire.com/'"
                 :linkTargetSecondary="'https://github.com/plainquire/plainquire'"
                 :buttonLabelSecondary="'Github'" />
               
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