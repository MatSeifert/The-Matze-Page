<script lang="ts">
    import Timetracking from '../components/projects/timetracking.vue'
    import Mtbsport from '../components/projects/Mtbsport.vue'

    import { 
        PROJECT_TIMETRACKING, PROJECT_FACTSHUB, PROJECT_MTSPORT, PROJECT_PODICONS 
    } from '../helper/const.js'

    export default {
        props: {
            id: String
        },
        data() {
            return {
                timetracking: PROJECT_TIMETRACKING,
                factshub: PROJECT_FACTSHUB,
                mtbsport: PROJECT_MTSPORT,
                podicons: PROJECT_PODICONS
            }
        },
        components: {
            Timetracking,
            Mtbsport
        }
    }
</script>

<template>
    <Timetracking v-if="id == timetracking" />
    <Mtbsport v-else-if="id == mtbsport" />
</template>