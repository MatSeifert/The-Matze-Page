<script lang="ts">
export default {
  computed: {
    calcYears() {
      const currentYear = new Date().getFullYear()
      return currentYear - 2017;
    }
  }
};
</script>

<template>
  <h1 id="aboutMe">über mich</h1>
  <div class="flex gap-top-m gap-bottom-xl" id="aboutMeContent">
    <div>
      <img src="../assets/images/profilePicture.webp" alt="Profilbild von Matthias"/>
    </div>
    <div id="aboutMeText">
      <div id="aboutMeQuote">
        Gutes <span>design</span> fällt besonders dann auf, wenn es fehlt.
      </div>
      <p>Hi, ich heiße Matthias, aber nennt mich gern Matze! Ich arbeite seit {{ calcYears }}
      Jahren als Software Entwickler mit Schwerpunkt Frontend in Dresden. Neben
      meiner Leidenschaft für Programmierung, der ich Vollzeit nachgehe, bin ich
      auch (gar nicht so) insgeheim Feuer und Flamme für alles Rund ums Thema UI
      Design. Daher habe ich mich 2018 nebenberuflich mit dieser zweiten Passion
      selbstständig gemacht und biete vor allem meine Fähigkeiten als Designer
      an. Hast Du Interesse daran, mit mir zu arbeiten? Ich freue mich schon
      darauf zu hören, wie ich auch Deinem Projekt helfen kann!</p>
      <a href="mailto:hallo@matze.dev?subject=Projektanfrage via matze.dev&body=Hi Matze%0D%0Dich möchte mit dir über folgendes Projekt von mir sprechen:%0D%0D" class="no-hover-effect gap-top-m inline-block">
        <button class="btn btn-primary">projektanfrage</button>
      </a>
    </div>
  </div>
</template>

<style lang="stylus" scoped>
  @import '../assets/config.styl'

  h1
      padding-top 1em

  #aboutMeContent
      max-width 70em
      position relative
      align-items center

      &:before, &:after
          content ''
          position absolute
          border-radius 50%

      &:before
          z-index -1
          width 150em
          height 50em
          background secondaryBlur
          top -20em
          left -45em
          transform rotate(15deg)
          opacity .4

      &:after
          width 100em
          height 40em
          background primaryBlur
          transform rotate(-25deg)
          opacity .4
          z-index -2
          top 0
          left -40em

  img
      width 30em

  #aboutMeQuote
      font-family DM Serif Display
      font-size 3em
      line-height 1em
      margin-bottom 1em
      max-width 10em
      position relative
      text-align left
      letter-spacing .03em

      span
          font-family Figtree, sans-serif
          color secondaryColor
          font-weight 900

      &:before
          content '„'
          color primaryColor
          font-size 5em
          position absolute
          z-index -1
          top -.35em
          left -.15em
          opacity .3
          filter blur(.005em)

      &:after
          content '“'
          color secondaryColor
          font-size 5em
          position absolute
          z-index -1
          top .7em
          left 1em
          opacity .4
          filter blur(.005em)

  #aboutMeText
      line-height 1.5em
      margin-left 6em
      text-align justify


  @media screen and (max-width: 1440px)
    #aboutMeContent
        flex-direction column-reverse
        max-width 30em
        margin-top 6em

        #aboutMeText
          margin-left 0

        img
            margin-top 4em

  @media screen and (max-width: 720px)
    #aboutMeQuote
      font-size 2em        
</style>
