<script lang="ts">
import ProjectHeader from '../elements/ProjectHeader.vue'
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
    ProjectHeader,
    Masonry,
  },
};
</script>

<template>

  <ProjectHeader :projectName="projectName"
                 :headline="'Design eines Iconsets'"
                 :subHeadline="'Praxis für Podologie'"
                 :abstract="'Eine podologische Praxis kümmert sich voll und ganz um das Wohl der Füße, wobei neben der medizinischen Behandlungen auch die Fußpflege eine große Rolle spielt. Für das Redesign der eigenen Homepage entstand dieses sehr spezifische Iconset, welches sich ebenfalls voll und ganz den Füßen und deren Gesundheit widmet.'"
                 :timespan="'2 Wochen'"
                 :year="'2018'"
                 :tags="tags"
                 :noShowcase="true" />

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
