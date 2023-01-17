<script lang="ts">
    import TcgDeckTypeIconV from './icons/TcgDeckTypeIconV.vue'
    import TcgDeckTypeIconB from './icons/TcgDeckTypeIconB.vue'
    import TcgDeckTypeIconA from './icons/TcgDeckTypeIconA.vue'
    import TcgDeckTypeIconS from './icons/TcgDeckTypeIconS.vue'

    export default {
        props: {
            deckType: {
                type: String,
                required: true
            }
        },
        data() {
            return {
                deckTypes: {
                    v: "Vintage",
                    b: "Basic",
                    a: "Advanced",
                    s: "Savage"
                }
            }
        },
        components: {
            TcgDeckTypeIconV,
            TcgDeckTypeIconB,
            TcgDeckTypeIconA,
            TcgDeckTypeIconS
        }
    }
</script>

<template>
    <div v-if="!!deckType" class="deck-type">
        <div class="deck-type-abb">
            <TcgDeckTypeIconV v-if="deckType == 'v'" />
            <TcgDeckTypeIconB v-if="deckType == 'b'" />
            <TcgDeckTypeIconA v-if="deckType == 'a'" />
            <TcgDeckTypeIconS v-if="deckType == 's'" />
        </div>
        <div class="deck-type-name">
            <div :class="`upper-name ${deckTypes[deckType]}`">
                {{ deckTypes[deckType] }}
            </div>
            <div class="lower-name"> Deck </div>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    .deck-type
        display flex
        padding 0 .25em
        background linear-gradient(to bottom, #EDEDED, #CBCBCB)
        width 8em
        height 2.5em
        border-radius 5em

        .deck-type-abb
            width 3em
            height 2em

            svg
                margin-top -.8em
                height 3em

        .deck-type-name
            text-transform uppercase
            color #131615
            margin-left .5em

            .upper-name
                font-weight 900
                font-size .73em
                margin-top .5em

            .lower-name
                font-weight 900
                letter-spacing .15em
                margin-top -.25em
</style>