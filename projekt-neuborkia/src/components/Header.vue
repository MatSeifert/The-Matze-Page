<script lang="ts">
import { RouterLink } from "vue-router";
import IconDribbble from "./icons/IconDribbble.vue";
import IconStackoverflow from "./icons/IconStackoverflow.vue";
import IconGithub from "./icons/IconGithub.vue";
import IconMastodon from "./icons/IconMastodon.vue";

export default {
  props: {
    isLandingpage: Boolean,
  },
  data() {
    return {
      scrollPosition: 0,
      navBarClass: "navigation-bar",
      navItemClass: "navigation-item",
      links: {
        aboutMe: {
          id: "aboutMe",
          i18n: {
            de: "über mich",
            en: "about me",
          },
        },
        projects: {
          id: "projects",
          i18n: {
            de: "projekte",
            en: "projects",
          },
        },
      },
      socialMedia: {
        dribbble: {
          id: "dribbble",
          linkTarget: "https://dribbble.com/thematze",
        },
        github: {
          id: "github",
          linkTarget: "https://github.com/MatSeifert",
        },
        stackoverflow: {
          id: "stackoverflow",
          linkTarget:
            "https://stackoverflow.com/users/3775858/matthias-seifert",
        },
        mastodon: {
          id: "mastodon",
          linkTarget: "https://mastodon.social/@einMATZEmalig",
        },
      },
    };
  },
  components: {
    IconDribbble,
    IconStackoverflow,
    IconGithub,
    IconMastodon,
  },
};
</script>

<template>
  <div id="header">
    <h1>
      <RouterLink tag="span" :to="{ path: '/' }"> matthias seifert </RouterLink>
    </h1>
    <ul :class="navBarClass">
      <li v-for="link in links" :key="link.id" :class="navItemClass">
        <RouterLink tag="a" :to="{ path: '/', hash: `#${link.id}` }">
          {{ link.i18n.de }}
        </RouterLink>
      </li>
    </ul>
    <ul :class="navBarClass" id="social">
      <li
        v-for="platform in socialMedia"
        :key="platform.id"
        :class="navItemClass"
      >
        <a :href="platform.linkTarget" target="_blank">
          <IconDribbble v-if="platform.id == 'dribbble'" />
          <IconStackoverflow v-if="platform.id == 'stackoverflow'" />
          <IconGithub v-if="platform.id == 'github'" />
          <IconMastodon v-if="platform.id == 'mastodon'" />
        </a>
      </li>
    </ul>

    <!-- <div class="floating-menu" style="background: red" v-if="scrollPosition > 100">
      Menü 2
    </div> -->
  </div>
</template>

<style lang="stylus" scoped>
a
    opacity .8
    position relative
    transition opacity .3s ease-in-out

    &:hover
        opacity 1

#header .navigation-bar#social
    margin-left auto

svg
    width 1em
    opacity .8

    &:hover
        opacity 1

#social li
    position relative

    &:before
        content ''
        display block
        position absolute
        width 2em
        height 2em
        top -.5em
        left -.5em
        border-radius 50%
        background-color transparent
        filter blur(1em)
        transition background-color .3s ease-in-out

    &:last-child
      margin-right 0 !important

    &:hover:before
        background-color #0ACD76

.floating-menu
  position fixed
  top 0        
</style>
