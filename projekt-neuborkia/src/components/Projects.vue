<script lang="ts">
    import ProjectBox from './ProjectBox.vue'

    export default {
        data() {
            return {
                projects: [
                    'timetracking',
                    'factshub',
                    'mtbsport'
                ]
            }
        },
        components: {
            ProjectBox
        }
    }
</script>

<template>
    <h1 id="projects">projekte</h1>
    <div :class="'flex gap-top-m project-wrapper'">
        <ProjectBox v-for="project of projects" :key="project"/>
    </div>
</template>

<style lang="stylus" scoped>
    .project-wrapper
        gap 5em
        flex-wrap wrap
</style>