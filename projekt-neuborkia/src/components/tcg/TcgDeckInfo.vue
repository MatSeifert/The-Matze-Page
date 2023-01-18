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
    <TcgDeckBox :deck="deck" :noLink="true" />
    
    <div class="card-list">
        <TcgCard v-for="(amount, name) in deck.deckContent?.pokemon"
                 :cardName="`${name}`"
                 :amount="amount" />
    </div>
    <div class="card-list">
        <TcgCard v-for="(amount, name) in deck.deckContent?.trainer"
                 :cardName="`${name}`"
                 :amount="amount" />
    </div>
    <div class="card-list energy">
        <TcgCard v-for="(amount, name) in deck.deckContent?.energy"
                 :cardName="`base_energy-${name}`"
                 :amount="4" />
    </div>
</template>

<style lang="stylus" scoped>
    .card-list
        margin 5em 0
        display flex
        flex-wrap wrap
        justify-content space-between
        gap 5em

        &.energy
            justify-content flex-start
</style>