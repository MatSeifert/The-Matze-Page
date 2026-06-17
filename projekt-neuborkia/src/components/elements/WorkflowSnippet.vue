<script lang="ts">
export default {
    props: {
        workflow: Object
    }
}
</script>

<template>
    <div class="workflow flex" v-if="!!workflow">
        <div class="workflow-image"></div>
        <div class="workflow-info">
            <h2>{{ workflow.title }}</h2>
            <h3>{{ workflow.subTitle }}</h3>
            <p>{{ workflow.abstract }}</p>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
.workflow
    border 1px solid rgba(#fff, .2)
    border-top 1px solid rgba(200, 200, 200, 0.4)
    border-radius 2em
    box-sizing border-box
    padding 1em 2em
    margin-top 3em

    h2
        font-size 3em
        letter-spacing .025em

    h3
        opacity .66

</style>