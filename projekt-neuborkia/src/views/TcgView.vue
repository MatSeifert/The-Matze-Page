<script lang="ts">
    import _ from 'lodash' 
    import decks from '../assets/data/decks.json'
    import TcgDeckBox from '../components/tcg/TcgDeckBox.vue'
    import TcgDeckInfo from '../components/tcg/TcgDeckInfo.vue'
    import Footer from "../components/Footer.vue"

    export default {
        props: {
            id: String
        },
        data() {
            return {
                decks: decks
            }
        },
        computed: {
            getDeck() {
                return _.get(decks, [`${this.id}`], {})
            }
        },
        components: {
            TcgDeckBox,
            TcgDeckInfo,
            Footer
        }
    }
</script>

<template>
    <div class="tcg-decks" v-if="!id">
        <TcgDeckBox v-for="deck in decks" :deck="deck"/>       
    </div>
    <div v-else>
        <TcgDeckInfo :deck="getDeck" />
    </div>

    <Footer />
</template>

<style lang="stylus" scoped>
    .tcg-decks
        display flex
        flex-wrap wrap
        gap 6em
</style>