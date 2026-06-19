<script lang="ts">
import Header from "@/components/Header.vue"
import Footer from "@/components/Footer.vue"
import DesignSysteme from "@/components/insights/DesignSysteme.vue"


import {
  INSIGHT_DESIGNSYSTEME
} from "@/helper/const";

export default {
  props: {
    id: String
  },
  data() {
    return {
      designsysteme: INSIGHT_DESIGNSYSTEME
    };
  },
  components: {
    Header,
    Footer,
    DesignSysteme
  },
  mounted() {
    window.scrollTo(0, 0);
  }
};
</script>

<template>
  <Header />

  <DesignSysteme v-if="id == designsysteme" />
  <!-- v-else-if -->

  <Footer />
</template>
