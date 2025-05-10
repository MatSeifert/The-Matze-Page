<script lang="ts">
import { RouterLink } from "vue-router"
import IconDribbble from "./icons/IconDribbble.vue"
import IconStackoverflow from "./icons/IconStackoverflow.vue"
import IconGithub from "./icons/IconGithub.vue"
import IconMastodon from "./icons/IconMastodon.vue"
import IconProjects from "./icons/IconProjects.vue"
import IconAboutMe from './icons/IconAboutMe.vue'
import IconCaretUp from './icons/IconCaretUp.vue'

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
          altText: "Link zum dribbble Profil von Matthias",
          ariaLabel: "Besuche mein UI und UX Portfolio auf dribbble"
        },
        github: {
          id: "github",
          linkTarget: "https://github.com/MatSeifert",
          altText: "Link zum GitHub Profil von Matthias",
          ariaLabel: "Stöbere auf GitHub in meinen Projekten"
        },
        stackoverflow: {
          id: "stackoverflow",
          linkTarget:
            "https://stackoverflow.com/users/3775858/matthias-seifert",
          altText: "Link zum StackOverflow Profil von Matthias",
          ariaLabel: "Schau auf meiner StackOverflow Seite, wie andere mir geholfen haben oder aber ich anderen helfen konnte"
        },
        mastodon: {
          id: "mastodon",
          linkTarget: "https://mastodon.social/@einMATZEmalig",
          altText: "Link zum Mastodon Profil von Matthias",
          ariaLabel: "Plaudere mit mir auf Mastodon oder stöbere in meinen Beiträgen"
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
    IconAboutMe,
    IconCaretUp
  },
};
</script>

<template>
  <div id="header">
    <h1>
      <RouterLink tag="span" :to="{ path: '/', hash: '#intro' }"> matthias wünsch </RouterLink>
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
        <a :href="platform.linkTarget" target="_blank" :aria-label="platform.ariaLabel">
          <IconDribbble v-if="platform.id == 'dribbble'" :alt="platform.altText"/>
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
        <RouterLink tag="a" :to="{ path: '/', hash: '#intro' }" aria-label="Link zur Startseite">
          <div>
            <img src="../assets/images/logo_black.svg" alt="matze.dev Logo" />
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

  <div class="to-top">
    <RouterLink tag="a" :to="{ hash: '#intro' }">
      <IconCaretUp />
      <div>nach oben</div>
    </RouterLink>
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

  .to-top
    position fixed
    z-index 3
    bottom 1em
    right 1.5em
    font-size 2em

    &:hover div
      opacity .8

    div
      opacity 0
      position absolute
      width 6em
      font-size .4em
      left 50%
      bottom -.4em
      transform translateX(-50%)
      text-align center
      transition all .3s

  @media screen and (max-width: 1080px)
    .to-top
      bottom 4em

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
        padding 0

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

      #social
        font-size 1.5em

      h1 
        margin 0

      .navigation-bar#social
        margin 0
        padding 0  

</style>
