<script lang="ts">
    import _ from 'lodash' 
    import decks from '../assets/data/decks.json'
    import TcgDeckBox from '../components/tcg/TcgDeckBox.vue'
    import TcgDeckInfo from '../components/tcg/TcgDeckInfo.vue'
    import Footer from "../components/Footer.vue"
    import TcgDeckTypeIconV from '../components/tcg/icons/TcgDeckTypeIconV.vue'
    import TcgDeckTypeIconB from '../components/tcg/icons/TcgDeckTypeIconB.vue'
    import TcgDeckTypeIconA from '../components/tcg/icons/TcgDeckTypeIconA.vue'
    import TcgDeckTypeIconS from '../components/tcg/icons/TcgDeckTypeIconS.vue'

    export default {
        props: {
            id: String
        },
        data() {
            return {
                decks: decks,
                filter: 'all'
            }
        },
        computed: {
            getDeck() {
                return _.get(decks, [`${this.id}`], {})
            },
            decksSorted() {
                return _.sortBy(this.decks, (d) => {
                    switch (d.deckType) {
                        case 'v': return 1
                        case 'b': return 2
                        case 'a': return 3
                        case 's': return 4
                    }
                })
            }
        },
        components: {
            TcgDeckBox,
            TcgDeckInfo,
            Footer,
            TcgDeckTypeIconV,
            TcgDeckTypeIconB,
            TcgDeckTypeIconA,
            TcgDeckTypeIconS
        }
    }
</script>

<template>
    <div v-if="!id">
        <div class="tcg-filter_wrapper">
            <div :class="`tcg-filter ${filter == 'all' ? 'active' : ''}`" @click="filter = 'all'">
                Alle
            </div>
            <div :class="`tcg-filter ${filter == 'v' ? 'active' : ''}`" @click="filter = 'v'"> 
                <TcgDeckTypeIconV :fill="filter == 'v' ? undefined : 'rgba(255, 255, 255, .2)'"
                                  :stroke="filter == 'v' ? undefined : 'rgba(255, 255, 255, .4)'"/> 
            </div>
            <div :class="`tcg-filter ${filter == 'b' ? 'active' : ''}`" @click="filter = 'b'"> 
                <TcgDeckTypeIconB :fill="filter == 'b' ? undefined : 'rgba(255, 255, 255, .2)'"
                                  :stroke="filter == 'b' ? undefined : 'rgba(255, 255, 255, .4)'"/> 
            </div>
            <div :class="`tcg-filter ${filter == 'a' ? 'active' : ''}`" @click="filter = 'a'"> 
                <TcgDeckTypeIconA :fill="filter == 'a' ? undefined : 'rgba(255, 255, 255, .2)'"
                                  :stroke="filter == 'a' ? undefined : 'rgba(255, 255, 255, .4)'"/> 
            </div>
            <div :class="`tcg-filter ${filter == 's' ? 'active' : ''}`" @click="filter = 's'"> 
                <TcgDeckTypeIconS :fill="filter == 's' ? undefined : 'rgba(255, 255, 255, .2)'"
                                  :stroke="filter == 's' ? undefined : 'rgba(255, 255, 255, .4)'"/>
            </div>
        </div>
        <div class="tcg-decks">        
            <TcgDeckBox v-for="deck in decksSorted" :deck="deck" :filter="filter"/>       
        </div>
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

    .tcg-filter_wrapper
        width 100%
        max-width 40em
        margin 0 auto 3em auto
        border 1px solid rgba(#fff, .25)
        display flex
        border-radius 2em
        overflow hidden
        box-shadow 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22)

        .tcg-filter
            flex 1
            text-align center
            cursor pointer
            text-transform uppercase
            font-weight 800
            background rgba(#000, .4)
            color rgba(#fff, .65)
            display flex
            align-items center
            justify-content center
            position relative
            overflow hidden

            &:not(.active):hover:before
                content ''
                width 150%
                height 5em
                border-radius 50%
                display block
                background radial-gradient(#13a353, transparent 70%)
                position absolute
                top -2.5em
                z-index -1

            &.active
                background linear-gradient(to bottom, #353535, #1E1E1E)
                color #fff

            &:not(:last-child)
                border-right 1px solid rgba(#fff, .25)

            svg
                height 2em
                padding .5em 0
</style>