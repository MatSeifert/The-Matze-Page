<script lang="ts">
export default {
  props: {
    type: String,
    label: String
  }
};
</script>

<template>
  <div :class="`shimmer ${type}`">
    <div :class="`tag ${type}`">
      {{ label }}
    </div>
  </div>
</template>

<style lang="stylus" scoped>
@import '../../assets/config.styl'

.shimmer
  display inline-block
  position relative
  z-index 2

  &.design:after
    background: secondaryColor

  &.development:after
    background primaryColor

  &:after
    width: calc(100% + 1em)
    height: 2.25em
    content: ""
    display: block
    position: absolute
    left: -.5em
    z-index: -1
    bottom: -.2em
    border-radius: 20%
    filter: blur(15px)
    opacity: .5

.tag
  padding .25em .5em
  background #202020
  margin .5em
  border-top-left-radius .5em
  border-top-right-radius .5em
  border-bottom-right-radius .5em
  border-top 1px solid rgba(#fff, .4)
  box-sizing border-box
  position relative
  font-weight 500
  box-shadow 0 3px 6px rgba(0, 0, 0, 0.25), 0 3px 6px rgba(0, 0, 0, 0.33)

  &.design
    background linear-gradient(to top, #00285d, #0651ad)
    color #cbd6e5
    padding-left 2em

    &:before
      display inline-block
      position absolute
      width 1em
      height 1em
      content url('../../assets/images/icon_design.svg')
      margin-right .5em
      left .5em
      top .35em

  &.development
    background linear-gradient(to top, #003f23, #017c47)
    color #c9ecdc
    padding-left 2em

    &:before
      display inline-block
      position absolute
      width 1em
      height 1em
      content url('../../assets/images/icon_dev.svg')
      margin-right .5em
      left .5em
      top .35em
</style>
