<script lang="ts">
  import Header from "../components/Header.vue";
  import Footer from "../components/Footer.vue";
  import Timetracking from '../components/projects/Timetracking.vue'
  import Mtbsport from '../components/projects/Mtbsport.vue'
  import Podicons from '../components/projects/Podicons.vue'
  import SchickSoftware from '../components/projects/SchickSoftware.vue'

  import {
    PROJECT_TIMETRACKING,
    PROJECT_FACTSHUB,
    PROJECT_MTSPORT,
    PROJECT_PODICONS,
    PROJECT_SCHICKSOFTWARE
  } from "../helper/const.js";

  export default {
    props: {
      id: String,
    },
    data() {
      return {
        timetracking: PROJECT_TIMETRACKING,
        factshub: PROJECT_FACTSHUB,
        mtbsport: PROJECT_MTSPORT,
        podicons: PROJECT_PODICONS,
        schicksoftware: PROJECT_SCHICKSOFTWARE
      };
    },
    components: {
      Header,
      Footer,
      Timetracking,
      Mtbsport,
      Podicons,
      SchickSoftware
    },
    mounted() {
      window.scrollTo(0, 0);
    },
  };
</script>

<template>
  <Header />

  <Timetracking v-if="id == timetracking" />
  <Mtbsport v-else-if="id == mtbsport" />
  <Podicons v-else-if="id == podicons" />
  <SchickSoftware v-else-if="id == schicksoftware" />

  <Footer />
</template>
