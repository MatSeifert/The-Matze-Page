<script lang="ts">
    import ProjectStatItem from '../elements/ProjectStatItem.vue'
    import { TAG_DESIGN, TAG_DEV } from '@/helper/const';

    export default {
        data() {
            return {
                tags: [
                    TAG_DESIGN, TAG_DEV
                ]
            }
        },
        components: {
            ProjectStatItem
        }
    }
</script>

<template>
    <div class="flex gap-top-l">
        <article class="project-abstract">
            <h2>Website Design und Umsetzung</h2>
            <h3>Mountainbike Sport Axel Hänel</h3>
            <p>
                Bei Axel bekommt man einen persönlich zugeschnittenen Service rund um sein 
                Bike. Während man beim Fachhändler nur selten einen wirklich personalisierten 
                Service erhält, ist der Service rund ums Thema Mountaibiking für Axel eine 
                Herzensangelegenheit.

                <div class="gap-top-m">
                    <a href="https://mtbsport-haenel.de/" target="_blank" alt="Zur Website von MTB Sport Hänel" class="no-hover-effect">
                        <button class="btn btn-primary">
                            zur website
                        </button>
                    </a>
                </div>

            </p>
        </article>
        <div class="project-stats">
            <ProjectStatItem :value="'Wordpress'" :label="'Technologie'" />
            <ProjectStatItem :value="'4 Monate'" :label="'Projektzeitraum'" />
            <ProjectStatItem :value="2022" :label="'Jahr'" />
            <ProjectStatItem :value="tags" :label="'Tags'" />
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    .flex
        gap 5em
        position relative
        overflow hidden
        border-radius 1em
        border 1px solid rgba(#fff, .1)

        &:after
            content ''
            display block
            position absolute
            z-index 0
            width 100%
            height 100%
            background black
            opacity .3

    .project-abstract
        width 40%
        padding 3em
        z-index 1
        line-height 1.5em

    .project-stats
        width 60%
        padding 3em
        display flex
        flex-wrap wrap
        align-content start
        z-index 1

        > div
            margin-left 5em
            height 8em

</style>