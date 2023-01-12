<script lang="ts">
import ProjectStatItem from "../elements/ProjectStatItem.vue";
import Masonry from "../elements/Masonry.vue";
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
    ProjectStatItem,
    Masonry,
  },
};
</script>

<template>
  <div class="project-overview gap-top-l">
    <div class="flex">
      <article class="project-abstract">
        <h2>Website Design und Umsetzung</h2>
        <h3>Mountainbike Sport Axel Hänel</h3>
        <p>
          Bei Axel bekommt man einen persönlich zugeschnittenen Service rund um
          sein Bike. Während man beim Fachhändler nur sehr selten eine wirklich
          personalisierte Beratung erhält, ist das Thema Mountainbiking für Axel
          eine absolute Herzensangelegenheit.
        </p>
      </article>
      <div class="project-stats">
        <ProjectStatItem :value="'4 Monate'" :label="'Projektzeitraum'" />
        <ProjectStatItem :value="2022" :label="'Jahr'" />
      </div>
      <div class="project-showcase">
        <img :src="`/src/assets/images/projects/${projectName}/showcase.png`" />
      </div>
    </div>
    <div class="flex gap-top-s">
      <a
        href="https://mtbsport-haenel.de/"
        target="_blank"
        alt="Zur Website von MTB Sport Hänel"
        class="no-hover-effect"
      >
        <button class="btn btn-primary">zur website</button>
      </a>
      <ProjectStatItem :value="tags" />
    </div>
  </div>

  <Masonry :projectName="projectName" :imageCount="7" />

  <RouterLink
    :to="{  path: '/', hash: '#projects' }"
    class="no-hover-effect block text-center">
    <button class="btn btn-primary">Zurück zur Übersicht</button>
  </RouterLink>
</template>

<style lang="stylus" scoped>
    .flex
        justify-content space-between
        position relative
</style>
