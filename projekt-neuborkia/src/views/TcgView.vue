<script lang="ts">
    import decks from '../assets/data/decks'
    import TcgDeckType from '../components/tcg/TcgDeckType'

    export default {
        data() {
            return {
                decks: decks
            }
        },
        components: {
            TcgDeckType
        }
    }
</script>

<template>
    <div class="tcg-decks">
        <div v-for="deck in decks" :class="`tcg-deck-card ${deck.deckEnergyTypes[0]}`">
            <h1>{{ deck.deckName }}</h1>

            <div>
                <TcgDeckType :deckType="deck.deckType" />
            </div>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    .tcg-decks
        display flex
        justify-content space-between

        .tcg-deck-card
            width calc(33% - 2em)
            border 1px solid #fff
</style>