<template>
    <div class="hero">
        <img src="../assets/images/logo.svg" id="logo">
        <div class="text-color-primary hero-text-large" id="hero-text-develop">develop</div>
        <div class="text-color-secondary hero-text-large" id="hero-text-design">de<span>sign</span></div>
        <div id="hero-text-url">matze.dev</div>
        <div class="hero-text-small" id="hero-subtext">where <span class="text-color-primary text-glow-primary">develop</span>ment meets <span class="text-color-secondary text-glow-secondary">design</span></div>
        <button class="btn btn-primary">
            Projektanfrage
        </button>
    </div>
</template>

<style lang="stylus" scoped>
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

        #hero-text-url
            opacity .8
            margin-bottom 1em
            font-weight 100

        #hero-subtext 
            color #C1CBC6

            span
                font-weight 900

        button
            margin 5em 0 10em 0
</style>