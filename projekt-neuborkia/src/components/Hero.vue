<template>
  <div class="hero">
    <img src="../assets/images/logo.svg" id="logo" alt="matze.dev Logo"/>
    <div class="text-color-primary hero-text-large" id="hero-text-develop">
      develop
    </div>
    <div class="text-color-secondary hero-text-large" id="hero-text-design">
      de<span>sign</span>
    </div>
    <div class="hero-text-small" id="hero-subtext">
      <span class="text-color-primary text-glow-primary">develop</span>ment
      meets <span class="text-color-secondary text-glow-secondary">design</span>
    </div>
    <a href="mailto:hallo@matze.dev?subject=Projektanfrage via matze.dev&body=Hi Matze%0D%0Dich möchte mit dir über folgendes Projekt von mir sprechen:%0D%0D" class="no-hover-effect">
      <button class="btn btn-primary">Projektanfrage</button>
    </a>
  </div>
</template>

<style lang="stylus" scoped>
@import '../assets/config.styl'

.hero
    text-align center

    #logo
        width 8em
        margin 4em 0

    .hero-text-large
        font-size 7.5em
        font-weight 900

    .hero-text-small
        font-size 1.5em

    #hero-text-design
        margin -1em 0 .25em .17em
        mix-blend-mode color-dodge
        white-space nowrap

        span
            letter-spacing .19em

    #hero-subtext
        margin-top 2em
        color tintedWhite

        span
            font-weight 900

    button
        margin 5em 0 10em 0

@media screen and (max-width: 820px)
  .hero
    #logo
      width 6em
      margin 3em 0

    .hero-text-large
      font-size 5em
      font-weight 900

    .hero-text-small
        font-size 1em
</style>
