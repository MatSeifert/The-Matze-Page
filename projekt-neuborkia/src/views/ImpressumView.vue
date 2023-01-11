<template>
  <h1>Impressum</h1>
  <div class="impressum">
    <div class="disclaimer">Angaben nach §5 TMG</div>
    <div class="website">www.matze.dev</div>
    <div class="name">Matthias Seifert</div>
    <div class="address" id="firstline">Reisewitzer Straße 5</div>
    <div class="address" id="secondline">01159 Dresden</div>
    <div class="mail">matthe.seifert@gmail.com</div>
    <div class="phone">01525 5911161</div>
  </div>
</template>

<style lang="stylus" scoped>
  h1
    border-top 1px solid rgba(#fff, .2)
    margin-top 1em
    padding-top 4em
    margin-bottom 3em

  .impressum

    > div
      margin-bottom .5em
      display flex
      align-items center
      gap 1em
      
      &:not(.disclaimer):before
        display inline-block
        width 1em
        margin-top .3em
        opacity .5

    .disclaimer
      opacity .8
      font-weight 600
      margin-bottom 2em

    .website:before
      content url('src/assets/images/heroicons/globe.svg')

    .name:before
      content url('src/assets/images/heroicons/person.svg')

    .address#firstline:before
      content url('src/assets/images/heroicons/home.svg')  

    .address#secondline:before  
      content: ''

    .mail:before
      content url('src/assets/images/heroicons/mail.svg')  

    .phone:before
      content url('src/assets/images/heroicons/phone.svg')        
</style>
