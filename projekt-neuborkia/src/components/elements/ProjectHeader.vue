<script lang="ts">
    import ProjectStatItem from "../elements/ProjectStatItem.vue";

    export default {
        props: {
            projectName: String,
            headline: String,
            subHeadline: String,
            abstract: String,
            linkTarget: String,
            buttonLabel: String,
            linkTargetSecondary: String,
            buttonLabelSecondary: String,
            timespan: String,
            year: String,
            tags: Array,
            noShowcase: Boolean
        },
        components: {
            ProjectStatItem
        }
    }
</script>

<template>
  <div class="project-overview gap-top-l">
    <div class="flex">
      <article class="project-abstract">
        <h2>{{ headline }}</h2>
        <h3>{{ subHeadline }}</h3>
        <p>
          {{ abstract }}
        </p>
      </article>
      <div class="project-stats">
        <ProjectStatItem :value="timespan" :label="'Projektzeitraum'" />
        <ProjectStatItem :value="year" :label="'Jahr'" />
      </div>
      <div class="project-showcase">
        <img v-if="!noShowcase" :src="`../images/projects/${projectName}/showcase.png`" />
      </div>
      <div class="project-box-m">
        <div class="project-stats-m flex flex-col">
            <ProjectStatItem :value="timespan" :label="'Projektzeitraum'" />
            <ProjectStatItem :value="year" :label="'Jahr'" />
        </div>
        <div class="project-showcase-m">
            <img v-if="!noShowcase" :src="`../images/projects/${projectName}/showcase.png`" />
        </div>
      </div>
    </div>
    <div class="flex gap-top-s link-tags" v-if="!!linkTarget">
      <div class="flex gap-3 wrap link-target-wrapper">
        <a
          :href="linkTarget"
          target="_blank"
          class="no-hover-effect"
        >
          <button class="btn btn-primary">{{ buttonLabel || 'Zur Website' }}</button>
        </a>
        <a v-if="!!linkTargetSecondary"
            :href="linkTargetSecondary"
            target="_blank"
            class="no-hover-effect"
          >
          <button class="btn btn-secondary">{{ buttonLabelSecondary }}</button>
        </a>
      </div>
      <ProjectStatItem :value="tags" />
    </div>
  </div>
</template>

<style lang="stylus" scoped>
    .flex
        justify-content space-between
        position relative
</style>