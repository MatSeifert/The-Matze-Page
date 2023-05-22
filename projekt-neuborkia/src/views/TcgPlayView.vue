<script lang="ts">
import _ from 'lodash'

export default {
    data() {
        return {
            active: {
                damage: 0,
                poisoned: false,
                burned: false,
                asleep: false,
                paralyzed: false,
                confused: false
            },
            bench: [],
            availablePowers: {
                gx: true,
                vstar: true
            }
        }
    }
}
</script>

<template>
    <div class="play-area">
        <div class="active-area">
            <div class="active-mon">
                <div class="damage">{{ active.damage }}</div>
            </div>
            <div class="active-mon-status">
                <div :class="`status poisoned ${active.poisoned ? 'active' : ''}`"></div>
                <div :class="`status burned ${active.burned ? 'active' : ''}`"></div>
                <div :class="`status asleep ${active.asleep ? 'active' : ''}`"></div>
                <div :class="`status paralyzed ${active.paralyzed ? 'active' : ''}`"></div>
                <div :class="`status confused ${active.confused ? 'active' : ''}`"></div>
            </div>
            <div class="power-status">
                <div :class="`power gx ${!availablePowers.gx ? 'used' : ''}`">GX</div>
                <div :class="`power vstar ${!availablePowers.vstar ? 'used' : ''}`">VStar</div>
            </div>
        </div>
        <div class="bench">
            <div class="benched-mon">+</div>
            <div class="benched-mon">+</div>
            <div class="benched-mon">+</div>
            <div class="benched-mon">+</div>
            <div class="benched-mon">+</div>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    .play-area
        .active-area
            display flex
            gap 5em
            justify-content center
        
            .active-mon
                width 5em
                height 7em
                border-radius .5em
                border 1px solid rgba(255, 255, 255, .25)
                background rgba(0, 0, 0, .5)
                display flex
                align-items center
                justify-content center
                font-size 3em
                font-weight 800

            .active-mon-status
                display flex
                flex-direction column
                justify-content space-between

                .status
                    width 3em
                    height 3em
                    border-radius 50%
                    border 1px solid rgba(255, 255, 255, .25)
                    background rgba(0, 0, 0, .5)

            .power-status
                display flex
                flex-direction column
                gap 2em

                .power
                    width 10em
                    height 6em
                    border 1px solid rgba(255, 255, 255, .25)
                    background rgba(0, 0, 0, .5)
                    border-radius 1em
                    display flex
                    align-items center
                    justify-content center

        .bench
            display flex
            justify-content space-around
            margin-top 5em

            .benched-mon
                width 5em
                height 7em
                font-size 2.5em
                font-weight 800
                border-radius .5em
                border 1px dashed rgba(255, 255, 255, .3)
                background rgba(0, 0, 0, .15)
                display flex
                justify-content center
                align-items center
                color rgba(255, 255, 255, .3)
</style>
