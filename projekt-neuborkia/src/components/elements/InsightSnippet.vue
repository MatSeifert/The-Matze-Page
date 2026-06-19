<script lang="ts">
import _ from "lodash";
import { RouterLink } from "vue-router";

export default {
    props: {
        insight: Object
    },
    computed: {
        getImage() {
            return `./images/insights/${_.get(this.insight, ["id"])}.webp`;
        }
  },
}
</script>

<template>
    <div :class="`insight flex ${insight?.isReversed ? 'reversed' : ''}`" v-if="!!insight">
        <div class="insight-image">
            <img :src="getImage" :alt="`Titelbild zum Insight ${insight.title}`" />
        </div>
        <div class="insight-info">
            <h2>{{ insight.title }}</h2>
            <h3>{{ insight.subTitle }}</h3>
            <p>{{ insight.abstract }}</p>
            <div class="flex">
                <RouterLink tag="button" :to="{path: `/insights/${insight.id}`}">
                    <button class="btn btn-primary">Weiterlesen</button>
                </RouterLink>
            </div>
        </div>
        <div class="insight-background"></div>
    </div>
</template>

<style lang="stylus" scoped>
@import '../../styles/config.styl'

.insight
    border 1px solid rgba(#fff, .2)
    border-top 1px solid rgba(200, 200, 200, 0.4)
    border-radius 2em
    box-sizing border-box
    padding 1em 3em
    margin-top 3em
    gap 3em
    background #000
    position relative

    &.reversed
        flex-direction row-reverse

        > div.insight-background:before
            background secondaryColor
            left unset
            top -33%
            right -33%

    > div.insight-background
        position absolute
        width 100%
        height 100%
        top 0
        left 0
        border-radius 2em
        z-index 0
        overflow hidden

        &:before
            content ''
            display block
            position absolute
            left -33%
            top 33%
            width 120%
            height 150%
            background primaryColor
            border-radius 50%
            filter blur(15em)
            opacity .33



    > div.insight-image, > div.insight-info
        width 50%
        z-index 1

        &.insight-image
            position relative

        img
            height 125%
            position absolute
            bottom -1em
            left -1em
            filter drop-shadow(0 0 5em rgba(secondaryColor, .33))

        h2
            font-size 3em
            font-weight 800
            letter-spacing .025em
            margin .5em 0 .25em 0

        h3
            opacity .66
            font-weight 600
            margin 0 0 1.5em 0

    p
        line-height 1.5em
        text-align justify
        hyphens auto

  a
    display inline-block
    margin 3em auto 3em auto

    &:before, &:after
      display none
</style>