<script lang="ts">
    export default {
        props: {
            projectName: String,
            imageCount: Number
        },
        data() {
            return {
                filePath: `/src/assets/images/projects/${this.projectName}/masonry/`
            }
        }
    }
</script>

<template>
    <h1>Gallerie</h1>
    <div class="masonry">
        <div v-for="image in imageCount" class="masonry-image-wrapper">
            <img :src="`${filePath}${image}.jpg`"/>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    h1
        margin-top 3em

    .masonry
        display flex
        flex-wrap wrap
        justify-content space-between
        margin 3em 0

        .masonry-image-wrapper
            width calc(50% - 2em)
            margin-bottom 4em


            img
                width 100%
                border-radius 1em
                box-shadow: 0 19px 38px rgba(0,0,0,0.30), 0 15px 12px rgba(0,0,0,0.22);

</style>