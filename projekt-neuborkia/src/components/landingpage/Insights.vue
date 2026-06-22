<script lang="ts">
import insights from "@/data/insights.json"
import InsightSnippet from "@/components/elements/InsightSnippet.vue";

export default {
  data() {
    return {
      insights
    };
  },
  components: {
    InsightSnippet
  }
};
</script>

<template>
    <h1 id="insights">insights</h1>

    <div class="insight-wrapper">
        <InsightSnippet v-for="(insight, index) in insights" :key="index" :insight="insight"/>
    </div>
</template>

<style lang="stylus" scoped>
@import '../../styles/config.styl'

h1
    margin-bottom -1.15em
    margin-top 1em

.insight-wrapper
    margin-top 10em

    > .insight:not(:first-child)
        margin-top 15em
</style>