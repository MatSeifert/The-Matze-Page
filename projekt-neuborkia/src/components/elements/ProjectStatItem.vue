<script lang="ts">
import Tag from "./Tag.vue";

export default {
  props: {
    value: [String, Number, Array],
    label: String
  },
  components: {
    Tag
  }
};
</script>

<template>
  <div class="stat-item">
    <div v-if="!Array.isArray(value)" class="stat-item_value">
      {{ value }}
    </div>
    <div v-else class="stat-item_value">
      <Tag v-for="tag of value" :label="`${tag}`" :type="`${tag}`" />
    </div>
    <div v-if="!!label" class="stat-item_label">
      {{ label }}
    </div>
  </div>
</template>

<style lang="stylus" scoped>
@import '../../assets/config.styl'

.stat-item_value
  font-size 2em
  font-weight 700
  display flex
  color primaryColor
  white-space nowrap

  .shimmer
    font-size .5em

    &:after
      width calc(100% + .5em)
      height 100%
      left -.25em
      opacity .35
      border-radius 33%
      filter blur(18px)

.stat-item_label
  opacity .6
  white-space nowrap
</style>
