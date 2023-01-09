<script lang="ts">
    import Tag from './elements/tag.vue'

    export default {
        props: {
            project: Object
        },
        components: {
            Tag
        }
    }
</script>

<template>
    <div v-if="!!project" class="project-box">
        <div class="project-title-image">
            <img :src="`./src/assets/images/title_${project.id}.png`" />
            <div class="project-tags">
                <Tag v-for="tag of project.tags" :label="tag" :type="tag"/>
            </div>
        </div>
        <div class="project-info flex">
            <div>
                <h1>{{ project.title }}</h1>
                <h2>{{ project.subTitle }}</h2>
            </div>
            <button class="btn btn-primary">
                Details
            </button>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    @import '../assets/config.styl'

    h1
        margin 0 0 .25em 0

        &:after 
            display none

    h2
        opacity .8
        font-size 1em
        font-weight 500
        margin 0

    .project-box
        background #0D0D0D
        border 1px solid rgba(#fff, .2)
        border-radius 2em
        box-sizing border-box
        flex 0 0 calc(33.333333% - 2em)
        display flex
        flex-direction column
        justify-content end
        height 20em
        overflow hidden
        box-shadow 0 14px 28px rgba(0,0,0,0.2), 0 10px 10px rgba(0,0,0,0.16)

        .project-title-image
            background defaultGradient
            height 100%
            position relative
            overflow hidden

            img
                position absolute
                top 0
                left 0
                width 100%

            .project-tags
                position absolute
                bottom .5em
                right .5em

        .project-info
            padding 1.5em 1.5em

        button
            margin-left auto
            max-height 3.5em
</style>