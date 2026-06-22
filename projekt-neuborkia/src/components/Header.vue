<script setup lang="ts">
import { onMounted, onUnmounted, ref } from 'vue'
import { RouterLink } from "vue-router"
import data from '@/data/mainMenu.json'
import IconDribbble from "./icons/IconDribbble.vue"
import IconStackoverflow from "./icons/IconStackoverflow.vue"
import IconGithub from "./icons/IconGithub.vue"
import IconMastodon from "./icons/IconMastodon.vue"
import IconProjects from "./icons/IconProjects.vue"
import IconAboutMe from './icons/IconAboutMe.vue'
import IconCaretUp from './icons/IconCaretUp.vue'
import HeroiconAboutMe from './icons/heroicons/HeroiconAboutMe.vue'
import HeroiconProjects from './icons/heroicons/HeroiconProjects.vue'
import HeroiconInsights from './icons/heroicons/HeroiconInsights.vue'

const sticky = ref(false)
const { navBarClass, navItemClass, links, socialMedia } = data;

function handleScroll() {
  if (window.scrollY > 50 && window.innerWidth > 900) {
    sticky.value = true
  } else {
    sticky.value = false
  }
}

onMounted(() => {
  window.addEventListener('scroll', handleScroll)
})

onUnmounted(() => {
  window.removeEventListener('scroll', handleScroll)
})
</script>

<template>
  <div id="header" :class="sticky ? 'sticky' : ''">
    <h1 class="name-headline">
      <RouterLink tag="span" :to="{ path: '/', hash: '#intro' }"> matthias wünsch </RouterLink>
    </h1>
    <ul :class="navBarClass" id="navigation-desktop">
      <li v-for="link in links" :key="link.id" :class="navItemClass">
        <RouterLink tag="a" class="page-link" :to="{ path: '/', hash: `#${link.id}` }">
          <HeroiconAboutMe v-if="link.id === 'aboutMe'"/>
          <HeroiconProjects v-else-if="link.id === 'projects'" />
          <HeroiconInsights v-else-if="link.id === 'insights'" />
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
  @import '../styles/config.styl'

  h1 
    white-space nowrap

  a
      opacity .8
      position relative
      transition opacity .3s ease-in-out

      &:hover
          opacity 1

  #header
    position sticky
    top 2em
    margin-top -2em
    z-index 3
    width calc(100vw - 13em)
    transform translateX(-2em)
    padding .75em 3em
    border 1px solid transparent
    transition all .4s

    &.sticky
      background rgba(#000, .33)
      backdrop-filter blur(3em)
      border-radius 100vh
      border-bottom solid 1px rgba(#fff, .15)
      border-left solid 1px rgba(#fff, .2)
      border-right solid 1px rgba(#fff, .2)
      border-top solid 1px rgba(#fff, .3)
    
    .navigation-bar#social
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
      border 1px solid rgba(#fff, .25)
      border-top 1px solid rgba(#fff, .44)
      border-bottom 1px solid rgba(#fff, .15)

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
