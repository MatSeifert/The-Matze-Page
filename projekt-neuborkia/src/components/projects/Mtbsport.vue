<script lang="ts">
import ProjectHeader from '@/components/elements/ProjectHeader.vue'
import Masonry from "@/components/elements/Masonry.vue";
import { TAG_DESIGN, TAG_DEV } from "@/helper/const";
import { RouterLink } from "vue-router";

export default {
  data() {
    return {
      tags: [TAG_DESIGN, TAG_DEV],
      projectName: "mtbsport",
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
                 :headline="'Website Design und Umsetzung'"
                 :subHeadline="'Mountainbike Sport Axel Hänel'"
                 :abstract="'Bei Axel bekommt man einen persönlich zugeschnittenen Service rund um sein Bike. Während man beim Fachhändler nur sehr selten eine wirklich personalisierte Beratung erhält, ist das Thema Mountainbiking für Axel eine absolute Herzensangelegenheit.'"
                 :timespan="'4 Monate'"
                 :year="'2022'"
                 :tags="tags"
                 :linkTarget="'https://mtbsport-haenel.de/'" />

  <Masonry :projectName="projectName" :imageCount="7" />

  <RouterLink
    :to="{  path: '/', hash: '#projects' }"
    class="no-hover-effect block text-center">
    <button class="btn btn-primary">Zurück zur Übersicht</button>
  </RouterLink>
</template>