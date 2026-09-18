<script lang="ts">
import Header from "@/components/Header.vue"
import Footer from "@/components/Footer.vue"
import DesignSysteme from "@/components/insights/DesignSysteme.vue"
import UiPsychology from "@/components/insights/UiPsychology.vue"

import {
  INSIGHT_DESIGNSYSTEME,
  INSIGHT_UIPSYCHOLOGY
} from "@/helper/const"

export default {
  props: {
    id: String
  },
  data() {
    return {
      designsysteme: INSIGHT_DESIGNSYSTEME,
      uipsychology: INSIGHT_UIPSYCHOLOGY
    };
  },
  components: {
    Header,
    Footer,
    DesignSysteme,
    UiPsychology
  },
  mounted() {
    window.scrollTo(0, 0);
  }
};
</script>

<template>
  <Header />

  <DesignSysteme v-if="id === designsysteme" />
  <UiPsychology v-else-if="id === uipsychology" />
  <!-- v-else-if -->

  <Footer />
</template>
