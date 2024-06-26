<script lang="ts">
import { RouterLink } from "vue-router";
import TcgDeckType from "./TcgDeckType.vue";
import TcgEnergyType from "./TcgEnergyType.vue";
import IconCaretLeft from "../icons/IconCaretLeft.vue";

export default {
  props: {
    deck: Object,
    noLink: Boolean,
    filter: String,
    typeFilter: Array,
    onlyNew: Boolean
  },
  components: {
    TcgDeckType,
    TcgEnergyType,
    IconCaretLeft
  },
  methods: {
    deckTypeIsVisible: function(filter: string, deck: any) {
      return (filter == "all" || filter == deck?.deckType || (deck?.deckType == "aplus" && (filter == "a" || filter == "s")));
    },
    energyTypeIsVisible: function(deckEnergyTypes: [string]) {
      if (!this.typeFilter || !this.typeFilter.length) return true;

      for (const energyType of this.typeFilter) {
        if (deckEnergyTypes.indexOf(energyType as string) != -1) return true;
      }

      return false;
    },
    oldDecksVisible: function(createionDate: string) {
      return this.onlyNew ? this.isNew(createionDate, new Date()) && this.onlyNew : true;
    },
    isNew: function(creationDate: string, currentDate: Date) {
      const createdAt = new Date(creationDate);
      const compareDate = new Date(currentDate.setMonth(currentDate.getMonth() - 3));

      return compareDate <= createdAt;
    }
  },
  mounted() {
    if (this.deck) {
      window.scrollTo(0, 0);
    }
  }
};
</script>

<template>
  <RouterLink v-if="!!deck && !noLink" :to="{ path: `/tcg/${deck.deckId}`}"
              :class="deckTypeIsVisible(filter || '', deck) && energyTypeIsVisible(deck?.deckEnergyTypes) && oldDecksVisible(deck.creationDate) ? '' : 'hide'">
    <div :class="`tcg-deck-card ${deck.deckEnergyTypes[0]}`">
      <h1>
        <span class="tcg-deck_new" v-if="isNew(deck.creationDate, new Date())">Neu</span> {{ deck.deckName }}
      </h1>

      <img class="tcg-deck-pate" :src="`../images/tcg/deckpaten/${deck.deckId}.svg`"
           :alt="`Deckpate ${deck.deckName}`" />

      <div class="tcg-deck-type-energy">
        <TcgDeckType :deckType="deck.deckType" />
        <div class="tcg-deck-energy">
          <TcgEnergyType v-for="energy in deck.deckEnergyTypes" :energyType="energy as string" />
        </div>
      </div>
    </div>
  </RouterLink>
  <div v-else :class="`tcg-deck-card ${deck?.deckEnergyTypes[0]}`">
    <RouterLink :to="{ path: `/tcg`}" class="tcg-backlink">
      <h1>
        <IconCaretLeft />
        {{ deck?.deckName }}
      </h1>
    </RouterLink>

    <img class="tcg-deck-pate" :src="`../images/tcg/deckpaten/${deck?.deckId}.svg`"
         :alt="`Deckpate ${deck?.deckName}`" />

    <div class="tcg-deck-type-energy">
      <TcgDeckType :deckType="deck?.deckType" />
      <div class="tcg-deck-energy">
        <TcgEnergyType v-for="energy in deck?.deckEnergyTypes" :energyType="energy as string" />
      </div>
    </div>
  </div>
</template>

<style lang="stylus" scoped>
a
  display block
  width calc(33% - 4em)
  max-width 30em
  transition all .2s ease-in-out

  &.hide
    display none

  &:before, &:after
    display none

  &:not(.tcg-backlink):hover
    transform scale(1.2)

  &.tcg-backlink:hover svg
    margin-left -.25em
    margin-right .25em

  svg
    transition all .1s ease-in-out

h1
  font-size 2.5em
  font-weight 800
  margin 0
  z-index 1
  display flex
  gap .5em
  align-items center

  &:after
    display none

  svg
    width .65em

.tcg-deck-card
  border 1px solid rgba(#fff, .25)
  border-radius 1.5em
  background rgba(#000, .5)
  padding 1em 2em
  overflow hidden
  position relative
  height 12em
  box-shadow 0 14px 28px rgba(0, 0, 0, 0.25), 0 10px 10px rgba(0, 0, 0, 0.22)

  &:before
    content ''
    display block
    position absolute
    width calc(100% + 8em)
    top -75%
    left -4em
    height 150%
    opacity .4

  &.fire:before
    background radial-gradient(#b40837, transparent 70%)

  &.grass:before
    background radial-gradient(#13a353, transparent 70%)

  &.water:before
    background radial-gradient(#0072eb, transparent 70%)

  &.psychic:before
    background radial-gradient(#bd00bf, transparent 70%)

  &.dragon:before
    background radial-gradient(#ae7c1d, transparent 70%)

  &.fighting:before
    background radial-gradient(#db4815, transparent 70%)

  &.steel:before
    background radial-gradient(#899098, transparent 70%)

  &.electric:before
    background radial-gradient(#f1c909, transparent 70%)
    opacity .3

  &.dark:before
    background radial-gradient(#535870, transparent 70%)

  &.colorless:before
    background radial-gradient(#c4bead, transparent 70%)

  .tcg-deck-pate
    position absolute
    top 1em
    right 2em
    height calc(100% - 6em)

  .tcg-deck-type-energy
    display flex
    position absolute
    width calc(100% - 4em)
    bottom 1em

    .tcg-deck-energy
      display flex
      gap .5em
      margin-left auto

span.tcg-deck_new
  display inline-block
  background green
  font-size .5em
  padding .25em .75em
  border-radius 2em
  text-transform uppercase
  font-weight 800
  color #fff
  background #ff2c51
  border 2px solid rgba(#fff, .5)
  box-shadow 0px 0px 20px 5px rgba(255, 44, 81, 0.85)

@media screen and (max-width: 1600px)
  a
    width calc(50% - 4em)

@media screen and (max-width: 1100px)
  a
    width 100%
</style>