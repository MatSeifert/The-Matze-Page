<script lang="ts">
export default {
  props: {
    projectName: String,
    imageCount: Number,
    title: String,
    fileNamePrefix: String,
    fileType: String,
    classes: String
  },
  data() {
    return {
      filePath: `/src/assets/images/projects/${this.projectName}/masonry/`,
    };
  },
};
</script>

<template>
  <h1>{{ title || 'Gallerie' }}</h1>
  <div :class="`masonry ${classes}`">
    <div v-for="image in imageCount" class="masonry-image-wrapper">
      <img :src="`${filePath}${fileNamePrefix || ''}${image}.${fileType || 'jpg'}`" />
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

    &.small .masonry-image-wrapper
      width calc(20% - 2em)
      background rgba(#000, .5)
      border-radius 1em

@media screen and (max-width: 1400px)
  .masonry.small .masonry-image-wrapper
    width calc(25% - 2em)

@media screen and (max-width: 1200px)
  .masonry .masonry-image-wrapper
    width 100%

@media screen and (max-width: 1000px)
  .masonry.small .masonry-image-wrapper
    width calc(33% - 2em)


@media screen and (max-width: 700px)
  .masonry.small .masonry-image-wrapper
    width calc(50% - 2em)       
</style>
