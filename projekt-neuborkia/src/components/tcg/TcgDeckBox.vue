<script lang="ts">
    import { RouterLink } from 'vue-router'
    import TcgDeckType from './TcgDeckType.vue'
    import TcgEnergyType from './TcgEnergyType.vue'
    import IconCaretLeft from '../icons/IconCaretLeft.vue'

    export default {
        props: {
            deck: Object,
            noLink: Boolean
        },
        components: {
            TcgDeckType,
            TcgEnergyType,
            IconCaretLeft
        }
    }
</script>

<template>
    <RouterLink v-if="!!deck && !noLink" :to="{ path: `/tcg/${deck.deckId}`}">
        <div :class="`tcg-deck-card ${deck.deckEnergyTypes[0]}`">
            <h1>{{ deck.deckName }}</h1>

            <img class="tcg-deck-pate" :src="`../images/tcg/deckpaten/${deck.deckId}.svg`" :alt="`Deckpate ${deck.deckName}`"/>

            <div class="tcg-deck-type-energy">
                <TcgDeckType :deckType="deck.deckType" />
                <div class="tcg-deck-energy">
                    <TcgEnergyType v-for="energy in deck.deckEnergyTypes" :energyType="energy" />
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

        <img class="tcg-deck-pate" :src="`../images/tcg/deckpaten/${deck?.deckId}.svg`" :alt="`Deckpate ${deck?.deckName}`"/>

        <div class="tcg-deck-type-energy">
            <TcgDeckType :deckType="deck?.deckType" />
            <div class="tcg-deck-energy">
                <TcgEnergyType v-for="energy in deck?.deckEnergyTypes" :energyType="energy" />
            </div>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    a
        display block
        width calc(33% - 4em)
        transition all .2s ease-in-out

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
</style>