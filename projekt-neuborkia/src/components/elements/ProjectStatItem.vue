<script lang="ts">
import Tag from "./Tag.vue";

export default {
  props: {
    value: [String, Number, Array],
    label: String,
  },
  components: {
    Tag,
  },
};
</script>

<template>
  <div class="stat-item">
    <div v-if="!Array.isArray(value)" class="stat-item_value">
      {{ value }}
    </div>
    <div v-else class="stat-item_value">
      <Tag v-for="tag of value" :label="tag" :type="tag" />
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

.stat-item_label
    opacity .6
    white-space nowrap

 .tag
    font-size .5em
    margin 0.5em 1em 0.5em 0
</style>
