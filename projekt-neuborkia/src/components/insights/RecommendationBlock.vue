<script setup lang="ts">
import _ from 'lodash'
import insights from '@/data/insights.json'
import InsightSnippet from '@/components/elements/InsightSnippet.vue'

const props = defineProps({
    recommended: Array<string>
})
</script>

<template>
    <div class="recommended">
        <h1>Mehr Insights</h1>
        <div class="flex gap-3">
            <InsightSnippet v-for="recommendation in recommended" :key="recommendation" :insight="_.get(insights, [recommendation])" :hideImage="false" />
        </div>
    </div>
</template>

<style lang="stylus">
.recommended
    h1
        margin-top 1em
        margin-bottom -.5em
        text-align center

    .insight-container
        flex 1 0 0

        > .insight > div.insight-info h2
            font-size 2em
            margin 1em 0
</style>