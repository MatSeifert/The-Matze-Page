<script lang="ts">
import workflows from "@/data/workflows.json"
import WorkflowSnippet from "@/components/elements/WorkflowSnippet.vue";

export default {
  data() {
    return {
      workflows
    };
  },
  components: {
    WorkflowSnippet
  }
};
</script>

<template>
    <h1 id="workflow">workflows</h1>

    <div :class="'workflow-wrapper'">
        <WorkflowSnippet v-for="(workflow, index) in workflows" :key="index" :workflow="workflow" />
    </div>

    <ul>
        <li>Design System</li>
        <li>SPA vs klassische Website</li>
        <li>Baukasten vs individuelle Seite</li>
    </ul>
</template>

<style lang="stylus" scoped>
    @import '../../styles/config.styl'

    h1
        padding-top 10em
</style>