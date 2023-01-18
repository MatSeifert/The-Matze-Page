<script lang="ts">
    import decks from '../assets/data/decks.json'
    import TcgDeckBox from '../components/tcg/TcgDeckBox.vue'

    export default {
        data() {
            return {
                decks: decks
            }
        },
        components: {
            TcgDeckBox
        }
    }
</script>

<template>
    <div class="tcg-decks">
        <TcgDeckBox v-for="deck in decks" :deck="deck"/>       
    </div>
</template>

<style lang="stylus" scoped>
    .tcg-decks
        display flex
        flex-wrap wrap
        gap 6em
</style>