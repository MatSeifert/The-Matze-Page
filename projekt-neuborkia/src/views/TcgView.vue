<script lang="ts">
    import _ from 'lodash' 
    import decks from '@/../public/data/decks.json'
    import TcgDeckBox from '@/components/tcg/TcgDeckBox.vue'
    import TcgDeckInfo from '@/components/tcg/TcgDeckInfo.vue'
    import Footer from "@/components/Footer.vue"
    import TcgDeckTypeIconV from '@/components/tcg/icons/TcgDeckTypeIconV.vue'
    import TcgDeckTypeIconB from '@/components/tcg/icons/TcgDeckTypeIconB.vue'
    import TcgDeckTypeIconA from '@/components/tcg/icons/TcgDeckTypeIconA.vue'
    import TcgDeckTypeIconS from '@/components/tcg/icons/TcgDeckTypeIconS.vue'
    import TcgEnergyType from '@/components/tcg/TcgEnergyType.vue'
    import HeroiconCheck from '@/components/icons/heroicons/HeroiconCheck.vue'
    import HeroiconXMark from '@/components/icons/heroicons/HeroiconXMark.vue'
    import HeroiconTrash from '@/components/icons/heroicons/HeroiconTrash.vue'
    import TcgPlayIcon from '@/components/tcg/icons/TcgPlayIcon.vue'

    export default {
        props: {
            id: String
        },
        data() {
            return {
                decks: decks,
                filter: 'all',
                showOnlyNew: false,
                typeFilterOverlayActive: false,
                typeFilter: [] as string[]
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
            TcgDeckTypeIconS,
            TcgEnergyType,
            HeroiconCheck,
            HeroiconXMark,
            HeroiconTrash,
            TcgPlayIcon
        },
        methods: {
            toggleTypeFilter: function (type: string | null) {
                if(!type) {
                    this.typeFilter = []
                    this.typeFilterOverlayActive = false

                    return
                }

                const typeFilterActive = this.typeFilter.indexOf(type) != -1

                if(typeFilterActive) {
                    this.typeFilter.splice(this.typeFilter.indexOf(type), 1)
                } else {
                    this.typeFilter.push(type)
                }
            }
        },
        mounted() {
            window.scrollTo(0, 0);
        }
    }
</script>

<template>
    <div v-if="!id">
        <div class="tcg-filters">
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

            <div class="tcg-filter_wrapper tcg-type-filter">
                <div class="tcg-filter" @click="typeFilterOverlayActive = !typeFilterOverlayActive">
                    <span v-if="!typeFilter || !typeFilter.length" style="padding-right: 1em">Alle Typen</span>
                    <span v-else class="tcg-type-filter_icons">
                        <TcgEnergyType v-for="energyType of typeFilter" :energyType="energyType"/>
                    </span>
                </div>
                <span v-if="typeFilter && typeFilter.length" class="tcg-type-filter_reset" @click="toggleTypeFilter(null)">
                    <HeroiconTrash/>
                </span>
            </div>

            <div :class="`tcg-filter_wrapper tcg-only-new ${showOnlyNew ? 'active' : ''}`">
                <div class="tcg-filter" @click="showOnlyNew = !showOnlyNew">
                    Neu
                </div>
            </div>
        </div>

        <div class="tcg-type-filter_background" v-if="typeFilterOverlayActive"/>
        <div :class="`tcg-type-filter_overlay grid col-2 ${typeFilterOverlayActive ? 'visible' : null }`">
            <div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('grass') != -1 ? 'active' : null}`" @click="toggleTypeFilter('grass')">
                    <div class="active-marker" v-if="typeFilter.indexOf('grass') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'grass'"/> Pflanze
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('fire') != -1 ? 'active' : null}`" @click="toggleTypeFilter('fire')">
                    <div class="active-marker" v-if="typeFilter.indexOf('fire') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'fire'"/> Feuer
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('water') != -1 ? 'active' : null}`" @click="toggleTypeFilter('water')">
                    <div class="active-marker" v-if="typeFilter.indexOf('water') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'water'"/> Wasser
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('electric') != -1 ? 'active' : null}`" @click="toggleTypeFilter('electric')">
                    <div class="active-marker" v-if="typeFilter.indexOf('electric') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'electric'"/> Elektro
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('fighting') != -1 ? 'active' : null}`" @click="toggleTypeFilter('fighting')">
                    <div class="active-marker" v-if="typeFilter.indexOf('fighting') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'fighting'"/> Kampf
                </div>
            </div>
            <div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('psychic') != -1 ? 'active' : null}`" @click="toggleTypeFilter('psychic')">
                    <div class="active-marker" v-if="typeFilter.indexOf('psychic') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'psychic'"/> Psycho
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('colorless') != -1 ? 'active' : null}`" @click="toggleTypeFilter('colorless')">
                    <div class="active-marker" v-if="typeFilter.indexOf('colorless') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'colorless'"/> Normal
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('dark') != -1 ? 'active' : null}`" @click="toggleTypeFilter('dark')">
                    <div class="active-marker" v-if="typeFilter.indexOf('dark') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'dark'"/> Unlicht
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('steel') != -1 ? 'active' : null}`" @click="toggleTypeFilter('steel')">
                    <div class="active-marker" v-if="typeFilter.indexOf('steel') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'steel'"/> Stahl
                </div>
                <div :class="`tcg-type-filter_item ${typeFilter.indexOf('dragon') != -1 ? 'active' : null}`" @click="toggleTypeFilter('dragon')">
                    <div class="active-marker" v-if="typeFilter.indexOf('dragon') != -1"><HeroiconCheck/></div>
                    <TcgEnergyType :energyType="'dragon'"/> Drache
                </div>
            </div>
            <div class="tcg-type-filter_buttons">
                <span @click="typeFilterOverlayActive = false">
                    <HeroiconCheck/> Anwenden
                </span>
            </div>
        </div>

        <div :class="`tcg-decks ${typeFilterOverlayActive ? 'blur' : null}`">
            <TcgDeckBox v-for="deck in decksSorted" :deck="deck" :filter="filter" :typeFilter="typeFilter" :onlyNew="showOnlyNew"/>       
        </div>

        <RouterLink :to="{ path: '/tcg/play'}" :class="'play-tcg no-hover-effect'">
            <TcgPlayIcon />
        </RouterLink>
    </div>

    <div v-else>
        <TcgDeckInfo :deck="getDeck" />
    </div>

    <Footer />
</template>

<style lang="stylus" scoped>
    .tcg-filters
        display flex
        gap 3em
        margin-bottom 4em
        justify-content center

    .tcg-decks
        display flex
        flex-wrap wrap
        gap 6em
        transition filter .2s

    .tcg-filter_wrapper
        width 100%
        max-width 40em
        max-height 60px
        border 1px solid rgba(#fff, .25)
        display flex
        border-radius 2em
        overflow hidden
        box-shadow 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22)

        &.tcg-type-filter
            width auto

            .tcg-filter
                padding 0 1em 0 2em

        &.tcg-only-new
            width auto

            .tcg-filter
                padding 0 2em 0 2em

            &.active
                box-shadow 0px 0px 20px 5px rgba(255,44,81,0.85)
                border 2px solid rgba(#fff, .6)

                .tcg-filter
                    background #ff2c51
                    color #fff

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

    .tcg-type-filter_overlay
        position fixed
        top 10em
        z-index -1
        background rgba(#000, .8)
        padding 3em
        border-radius 2em
        border 1px solid rgba(#fff, .25)
        opacity 0
        transition opacity .2s
        left 50%
        transform translate(-50%, 0)
        width 25em
        box-shadow 0 28px 56px rgba(0,0,0,0.4), 0 20px 20px rgba(0,0,0,0.4)

        > div
            margin 0 7em 0 0

        &.visible
            opacity 1
            z-index 2

        .tcg-type-filter_item
            display flex
            align-items center
            gap 1em
            text-transform uppercase
            font-weight 800
            margin-bottom 1.5em
            opacity .45
            cursor pointer
            transition opacity .1s
            position relative

            .active-marker
                position absolute
                width 1em
                height 1em
                border-radius 50%
                background #0acd76
                bottom 0
                left -.25em
                border 1px solid rgba(#fff, .65) 
                padding .2em
                box-shadow 0 14px 28px rgba(0,0,0,0.6), 0 10px 10px rgba(0,0,0,0.6)

            .tcg-energy
                opacity .5

            &:hover, &:hover .tcg-energy, &.active, &.active .tcg-energy
                opacity 1
    
    .tcg-type-filter_background
        background rgba(#000, .2)
        filter blur(2em)
        position absolute
        left 0
        width 100%
        height 100%
        z-index 2

    .tcg-type-filter_icons
        display flex
        gap .25em
        align-items center

        .tcg-energy
            height 2.5em
            transform scale(.7)

    .tcg-type-filter_buttons
        position absolute
        bottom -1.25em
        left 3em
        
        span
            display flex
            background rgba(#000, .9)
            color #0acd76
            border 2px solid rgba(#0acd76, .9)
            padding .75em 1.5em
            border-radius 3em
            font-weight 800
            text-transform uppercase
            transition background .2s
            cursor pointer

            &:hover
                background #054229

            svg
                width 1em
                margin-right .5em
    
    .tcg-type-filter_reset 
        width 1em
        padding 0 2em 0 1.25em
        background radial-gradient(rgba(#000, .75), rgba(#000, .75))
        transition background .2s
        cursor pointer
        position relative

        &:hover
            background radial-gradient(rgba(#f92e52, .75), rgba(#000, .75))

        svg
            width 1.5em
            margin-top .75em
            z-index 1
</style>