<script lang="ts">
    import TcgDeckBox from './TcgDeckBox.vue'
    import TcgCard from './TcgCard.vue'

    export default {
        props: {
            deck: {
                type: Object,
                required: true
            }
        },
        components: {
            TcgDeckBox,
            TcgCard
        }
    }
</script>

<template>
    <TcgDeckBox :deck="deck" :noLink="true" :filter="'all'" />
    
    <h1 class="gap-top-m">pokémon</h1>
    <div class="card-list">
        <TcgCard v-for="(amount, name) in deck.deckContent?.pokemon"
                 :cardName="`${name}`"
                 :amount="amount" />
    </div>
    <h1>trainer</h1>
    <div class="card-list">
        <TcgCard v-for="(amount, name) in deck.deckContent?.trainer"
                 :cardName="`${name}`"
                 :amount="amount" />
    </div>
    <h1>energie</h1>
    <div class="card-list energy">
        <TcgCard v-for="(amount, name) in deck.deckContent?.energy"
                 :cardName="`${name}`"
                 :amount="4" />
    </div>
</template>

<style lang="stylus" scoped>
    .card-list
        width calc(100% + 5em)
        margin 3em 0 6em 0
        display flex
        flex-wrap wrap
        gap 5em

        &.energy
            justify-content flex-start
</style>