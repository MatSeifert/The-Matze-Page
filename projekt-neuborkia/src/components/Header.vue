<script lang="ts">
import { RouterLink } from "vue-router"
import IconDribbble from "./icons/IconDribbble.vue"
import IconStackoverflow from "./icons/IconStackoverflow.vue"
import IconGithub from "./icons/IconGithub.vue"
import IconMastodon from "./icons/IconMastodon.vue"
import IconProjects from "./icons/IconProjects.vue"
import IconAboutMe from './icons/IconAboutMe.vue'

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
    IconProjects,
    IconAboutMe
  },
};
</script>

<template>
  <div id="header">
    <h1>
      <RouterLink tag="span" :to="{ path: '/' }"> matthias seifert </RouterLink>
    </h1>
    <ul :class="navBarClass" id="navigation-desktop">
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
  </div>

  <div class="navigation-mobile">
    <ul>
      <li :class="navItemClass">
        <RouterLink tag="a" :to="{ path: '/', hash: `#aboutMe` }">
          <div class="flex flex-col center-h">
            <IconAboutMe />
            <span>über mich</span>
          </div>
        </RouterLink>
      </li>
      <li class="navigation-mobile_center">
        <RouterLink tag="a" :to="{ path: '/' }">
          <div>
            <img src="../assets/images/logo_black.svg" />
          </div>
        </RouterLink>
      </li>
      <li :class="navItemClass">
        <RouterLink tag="a" :to="{ path: '/', hash: `#projects` }">
          <div class="flex flex-col center-h">
            <IconProjects />
            <span>projekte</span>
          </div>
        </RouterLink>
      </li>
    </ul>
  </div>
</template>

<style lang="stylus" scoped>
@import '../assets/config.styl'

h1 
  white-space nowrap

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

.navigation-mobile
  display none

@media screen and (max-width: 1080px)
  #header #navigation-desktop
    display none

  .navigation-mobile
    display block
    position fixed
    bottom 1em
    left 1em
    z-index 2
    background linear-gradient(176deg, #292929 0%, #0c0c0c 60%)
    box-shadow 0px 0px 45px 5px rgba(secondaryColor ,0.2)
    width calc(100% - 2em)
    border-top-left-radius 1.5em
    border-top-right-radius 1.5em
    border-bottom-right-radius 1.5em

    &:before
      content ''
      display block
      height 1px
      background linear-gradient(to right, transparent, rgba(#fff, .2), transparent)

    &:after
      content ''
      display block
      height 1px
      background linear-gradient(to right, transparent, rgba(#fff, .15), transparent)      

    ul
      list-style-type none
      display flex
      justify-content space-evenly

      svg
        width 1.25em
        opacity .5
        margin-bottom .15em

      li.navigation-mobile_center
        position relative
        width 5em

        a
          opacity 1

          &:hover div
            box-shadow 0px 0px 25px 5px rgba(primaryColor ,0.7)

          div
            width 100%
            position absolute
            left 0
            right 0
            top -1.5em
            background primaryColor
            border-radius 50%
            width 5em
            height 5em
            display flex
            justify-content center
            align-items flex-start
            transition box-shadow .3s ease-in-out
            box-shadow 0px 0px 25px 5px rgba(primaryColor ,0.3)

          img
            width 3.5em
            padding-top 1.2em

@media screen and (max-width: 820px)
  #header
    flex-direction column
    gap 2em

    h1 
      margin 0

    .navigation-bar#social
      margin 0
      padding 0  

</style>
