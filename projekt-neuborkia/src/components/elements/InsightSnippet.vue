<script setup lang="ts">
import _ from "lodash";
import { RouterLink } from "vue-router";

const props = defineProps({
    insight: Object,
    hideImage: Boolean
})

const imageUrl = new URL(`../../assets/images/insights/${_.get(props.insight, ["id"])}.webp`, import.meta.url).href
</script>

<template>
    <div class="insight-container">
        <div :class="['insight flex', insight?.id, insight?.isReversed ? 'reversed' : '']" v-if="!!insight">
            <div class="insight-image" v-if="!hideImage">
                <img :src="imageUrl" :alt="`Titelbild zum Insight ${insight.title}`" />
            </div>
            <div :class="`insight-info ${hideImage ? 'full-width' : ''}`">
                <h2>{{ insight.title }}</h2>
                <h3>{{ insight.subTitle }}</h3>
                <p>{{ insight.abstract }}</p>
                <div class="flex">
                    <RouterLink tag="button" :to="{ path: `/insights/${insight.id}` }">
                        <button class="btn btn-primary">Weiterlesen</button>
                    </RouterLink>
                </div>
            </div>
            <div class="insight-background"></div>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
@import '../../styles/config.styl'

.insight-container
    container-type inline-size

.insight
    border 1px solid rgba(#fff, .2)
    border-top 1px solid rgba(200, 200, 200, 0.4)
    border-radius 2em
    box-sizing border-box
    padding 1em 3em
    margin-top 3em
    gap 3em
    background rgba(#000, .5)
    position relative
    backdrop-filter blur(.25em)

    &.reversed
        flex-direction row-reverse

        > div.insight-background:before
            background secondaryColor
            left unset
            top -33%
            right -33%
            opacity .2

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
            opacity .25

    > div.insight-image, > div.insight-info
        width 50%
        z-index 1

        &.full-width
            width 100%

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
            line-height 1.4em
            margin 0 0 1.5em 0

    p
        line-height 1.5em
        text-align justify
        hyphens auto

    &.accessibility > div.insight-image > img
        height 105%
        left -2em

  a
    display inline-block
    margin 3em auto 3em auto

    &:before, &:after
      display none

@container (width < 1200px)
    .insight, 
    .insight.reversed
        flex-direction column
        gap 0

        > div.insight-image
            width 100%
            position relative

            > img
                position absolute
                width 100%
                height auto
                top -4em

        > div.insight-info
            width 100%
            margin-top 14em

            > h2
                text-shadow 0px 0px .25em #131616

    // Insight-spezifische Styles
    .insight.designsysteme
        > div.insight-image > img
            width 140%
            left -3em
            top -3em

    .insight.uipsychology
        > div.insight-image > img
            width 120%
            left -2em

    .insight.color-theory
        > div.insight-image > img
            width 100%
            left 0

    .insight.typography
        > div.insight-image > img
            width 125%
            left -2em

    .insight.accessibility
        > div.insight-image > img
            height auto
            width 125%
            left -2.5em
</style>