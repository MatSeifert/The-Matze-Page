<script lang="ts">
import ProjectStatItem from "../elements/ProjectStatItem.vue";
import Masonry from "../elements/Masonry.vue";
import { TAG_DESIGN } from "@/helper/const";
import { RouterLink } from "vue-router";

export default {
  data() {
    return {
      tags: [TAG_DESIGN],
      projectName: "podicons",
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
        <h2>Design eines Iconsets</h2>
        <h3>Praxis für Podologie</h3>
        <p>
          Eine podologische Praxis kümmert sich voll und ganz um das Wohl der Füße, wobei
          neben der medizinischen Behandlungen auch die Fußpflege eine große Rolle spielt. 
          Für das Redesign der eigenen Homepage entstand dieses sehr spezifische Iconset,
          welches sich ebenfalls voll und ganz den Füßen und deren Gesundheit widmet.
        </p>
      </article>
      <div class="project-stats">
        <ProjectStatItem :value="'2 Wochen'" :label="'Projektzeitraum'" />
        <ProjectStatItem :value="2018" :label="'Jahr'" />
      </div>
      <div class="project-showcase">
        <ProjectStatItem :value="tags" />
      </div>
    </div>
  </div>

  <Masonry :projectName="projectName" :imageCount="10" :fileType="'png'" :classes="'small'"/>

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

    .project-showcase
        display flex
        align-items flex-end

        .stat-item
            margin-left auto
</style>
