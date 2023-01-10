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
                    <button class="btn btn-primary">
                        Livedemo
                    </button>
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

    .project-abstract
        width 40%

    .project-stats
        width 60%
        display flex
        flex-wrap wrap
        gap 5em
        align-content start
</style>