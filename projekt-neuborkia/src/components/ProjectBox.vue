<script lang="ts">
import _ from "lodash";
import Tag from "./elements/Tag.vue";
import { RouterLink } from "vue-router";

export default {
  props: {
    project: Object
  },
  computed: {
    getImage() {
      return `./images/projects/${_.get(this.project, ["id"])}/title.webp`;
    }
  },
  components: {
    Tag
  }
};
</script>

<template>
  <div v-if="!!project && !project.hide" class="project-box">
    <div class="project-title-image">
      <img
        :src="getImage"
        :alt="`Titelbild zum Projekt ${project.title} - ${project.subTitle}`"
      />
      <div class="project-tags">
        <Tag v-for="tag of project.tags" :label="tag" :type="tag" />
      </div>
    </div>
    <div class="project-info flex">
      <div>
        <h1>
          {{ project.title }}
          <span class="year-tag">{{ project.year }}</span>
        </h1>
        <h2>{{ project.subTitle }}</h2>
      </div>
      <RouterLink tag="button" :to="{ path: `/project/${project.id}` }">
        <button class="btn btn-primary">Details</button>
      </RouterLink>
    </div>
  </div>
</template>

<style lang="stylus" scoped>
@import '../assets/config.styl'

h1
  margin .25em 0 .25em 0
  display flex
  gap .5em
  white-space nowrap
  letter-spacing -.035em
  font-size 1.1em

  &:after
    display none

  span.year-tag
    background linear-gradient(rgba(#fff, .3), rgba(#fff, .15))
    border-top 1px solid rgba(#fff, .4)
    border-left 1px solid rgba(#fff, .25)
    border-right 1px solid rgba(#fff, .25)
    padding .1em .5em
    margin-top .1em
    border-radius 1em
    color #fff
    font-weight 600
    font-size .66em
    display flex
    align-items center
    letter-spacing 0

h2
  opacity .8
  font-size .9em
  font-weight 500
  margin 0

.project-box
  border 1px solid rgba(#fff, .2)
  border-top 1px solid rgba(200, 200, 200, 0.4)
  border-radius 2em
  box-sizing border-box
  flex 0 0 calc(33.333333% - 2em)
  display flex
  flex-direction column
  justify-content end
  height 20em
  overflow hidden
  box-shadow 0 14px 28px rgba(0, 0, 0, 0.2), 0 10px 10px rgba(0, 0, 0, 0.16)
  border-bottom-left-radius .25em

  .project-title-image
    background defaultGradient
    height 100%
    position relative
    z-index 0

    img
      position absolute
      top 0
      left 0
      width 100%
      z-index -1

    .project-tags
      position absolute
      bottom .5em
      right .5em

  .project-info
    padding 1.25em 1.5em
    margin 0 .5em .5em .5em
    opacity 1
    position relative
    background linear-gradient(rgba(#333, .6), rgba(#0D0D0D, .8))
    box-shadow 0 14px 28px rgba(0, 0, 0, 0.2), 0 10px 10px rgba(0, 0, 0, 0.16)
    border 1px solid rgba(#fff, .33)
    border-top 1px solid rgba(#fff, .66)
    border-bottom 1px solid rgba(#fff, .15)
    backdrop-filter blur(1em)
    border-radius 1.66em
    z-index 1
    border-bottom-left-radius .25em

    button
      letter-spacing .03em

  a
    margin-left auto
    max-height 3.5em

    &:before, &:after
      display none

@media screen and (max-width: 1919px)
  .project-box
    flex 0 0 calc(50% - 2em)

@media screen and (max-width: 1440px)
  .project-box
    flex 0 0 100%

@media screen and (max-width: 820px)
  .project-box
    .project-info
      font-size .8em

      a
        font-size .9em

@media screen and (max-width: 620px)
  .project-box
    .project-info
      font-size 1em

      a button
        padding .75em
</style>
