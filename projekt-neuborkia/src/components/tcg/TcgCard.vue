<script lang="ts">
import axios from "axios";
import _ from "lodash";
import apiConfig from "@/assets/apiConfig.json";

export default {
  props: {
    cardName: String,
    amount: Number
  },
  data() {
    return {
      info: {} as Object
    };
  },
  computed: {
    getImage() {
      console.log(this.info);

      return _.get(this.info, ["data", "images", "large"]);
    }
  },
  mounted() {
    const config = {
      headers: {
        "X-Api-Key": _.get(apiConfig, ["apiKey"])
      }
    };

    const url = `https://api.pokemontcg.io/v2/cards/${this.cardName}`;

    axios.get(url, config)
      .then(response => (this.info = response.data))
      .catch(error => console.log(error));
  }
};
</script>

<template>
  <div class="card-wrapper">
    <img v-if="!getImage" src="/src/assets/images/tcg/loading.png" alt="Card loading" class="card loading" />
    <img v-for="i in amount"
         :class="`card card-${i}`"
         :src="getImage" />
  </div>
</template>

<style lang="stylus" scoped>
.card-wrapper
  position relative
  width calc(20% - 5em)
  max-width 15em

  img.card
    width 100%
    border-radius .8em
    box-shadow 0 14px 28px rgba(0, 0, 0, 0.25), 0 10px 10px rgba(0, 0, 0, 0.22)
    transition all .1s

    &:hover
      transform scale(1.3)

    &.card-2
      position absolute
      border-radius .7em
      bottom -1em
      z-index -1
      width 95%
      left 2.5%

    &.card-3
      position absolute
      border-radius .6em
      bottom -2em
      z-index -2
      width 90%
      left 5%

    &.card-4
      position absolute
      border-radius .4em
      bottom -3em
      width 85%
      z-index -3
      left 7.5%

@media screen and (max-width: 1919px)
  .card-wrapper
    width calc(25% - 5em)

@media screen and (max-width: 1400px)
  .card-wrapper
    width calc(33% - 5em)

@media screen and (max-width: 1000px)
  .card-wrapper
    width calc(50% - 5em)
    max-width unset

    img.card:hover
      transform none

</style>