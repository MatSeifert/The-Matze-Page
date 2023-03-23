<template>
  <footer>
    <div class="disclaimer">
      &copy; {{ new Date().getFullYear() }} - Matthias Seifert <a href="https://www.matze.dev/" alt="Matze.dev Homepage">matze.dev</a>
    </div>
    <a href="/impressum">impressum</a>
    <a href="/datenschutz">datenschutz</a>
  </footer>
</template>

<style lang="stylus" scoped>
  @import '../assets/config.styl'

  footer
      text-align center
      margin 8em auto  0 auto
      position relative
      overflow hidden
      padding-bottom 2em

      &:before
          content ''
          display block
          width 100%
          height 1px
          background linear-gradient(to right, rgba(0,0,0,0), rgba(#fff, .2), rgba(0,0,0,0))
          margin-bottom 2em

      &:after
          content ''
          display block
          position absolute
          width 75%
          padding 0 5em
          height 8em
          top -4em
          left 0
          right 0
          margin auto
          border-radius 50%
          background primaryBlur
          z-index -1
          opacity .1

      a
          display inline-block
          margin 1em 1em 0 1em
          position relative
          opacity .8
          transition opacity .3s ease-in-out

          &:hover
              opacity 1

  @media screen and (max-width: 1440px)            
    footer
      width calc(100% + 10em)
      margin-left -5em
</style>
