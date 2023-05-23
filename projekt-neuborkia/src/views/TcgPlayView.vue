<script lang="ts">
import _ from 'lodash'
import StatusPoisoned from '@/components/tcg/icons/StatusPoisoned.vue'
import StatusBurned from '@/components/tcg/icons/StatusBurned.vue'
import StatusAsleep from '@/components/tcg/icons/StatusAsleep.vue'
import StatusParalyzed from '@/components/tcg/icons/StatusParalyzed.vue'
import StatusConfused from '@/components/tcg/icons/StatusConfused.vue'
import PowerGx from '@/components/tcg/icons/PowerGx.vue'
import PowerVstar from '@/components/tcg/icons/PowerVstar.vue'

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
            bench: [] as Object[],
            availablePowers: {
                gx: true,
                vstar: true
            },
            STATUS_POISONED: 'poisoned',
            STATUS_BURNED: 'burned',
            STATUS_ASLEEP: 'asleep',
            STATUS_PARALYZED: 'paralyzed',
            STATUS_COFUSED: 'confused',
            POWER_GX: 'gx',
            POWER_VSTAR: 'vstar'
        }
    },
    methods: {
        addDamage(amount: number, position: number) {
            if (position == -1) {
                // Active Pokémon
                this.active.damage += amount
            } else {
                // add damage to benched pokémon at given position
            }
        },
        toggleStatus(statusType: string) {
            switch (statusType) {
                case this.STATUS_POISONED:
                    this.active.poisoned = !this.active.poisoned
                    break
                case this.STATUS_BURNED:
                    this.active.burned = !this.active.burned
                    break
                case this.STATUS_ASLEEP:
                    this.active.asleep = !this.active.asleep
                    break
                case this.STATUS_PARALYZED:
                    this.active.paralyzed = !this.active.paralyzed
                    break
                case this.STATUS_COFUSED:
                    this.active.confused = !this.active.confused
                    break
            }

            console.log(this.active.poisoned)
        },
        togglePower(powerType: string) {
            switch (powerType) {
                case this.POWER_GX:
                    this.availablePowers.gx = !this.availablePowers.gx
                    break
                case 'vstar':
                    this.availablePowers.vstar = !this.availablePowers.vstar
                    break
            }
        },
        addBenchedMon(mon?: Object) {
            if (this.bench.length == 5) {
                return
            }

            this.bench.push(mon || {
                damage: 0,
                poisoned: false,
                burned: false,
                asleep: false,
                paralyzed: false,
                confused: false
            })

            console.log(this.bench)
        },
        getBenchedInfo(index: number, prop: string) {
            console.log(index)
            const relevantMon = this.bench[index];

            if(!relevantMon) {
                console.warn(`No Pokémon found on Bench at index ${index}`)
                return
            }

            return _.get(relevantMon, [prop], '')
        },
        setActiveMon(mon: any) {
            this.active = mon
        }
    },
    components: {
        StatusPoisoned,
        StatusBurned,
        StatusAsleep,
        StatusParalyzed,
        StatusConfused,
        PowerGx,
        PowerVstar
    }
}
</script>

<template>
    <div class="play-area">
        <div class="active-area">
            <div class="active-mon" @click="addDamage(10, -1)">
                <div class="damage">{{ active.damage }}</div>
            </div>
            <div class="active-mon-status">
                <div :class="`status poisoned ${active.poisoned ? 'active' : ''}`" @click="toggleStatus(STATUS_POISONED)">
                    <StatusPoisoned />
                </div>
                <div :class="`status burned ${active.burned ? 'active' : ''}`" @click="toggleStatus(STATUS_BURNED)">
                    <StatusBurned />
                </div>
                <div :class="`status asleep ${active.asleep ? 'active' : ''}`" @click="toggleStatus(STATUS_ASLEEP)">
                    <StatusAsleep />
                </div>
                <div :class="`status paralyzed ${active.paralyzed ? 'active' : ''}`" @click="toggleStatus(STATUS_PARALYZED)">
                    <StatusParalyzed />
                </div>
                <div :class="`status confused ${active.confused ? 'active' : ''}`" @click="toggleStatus(STATUS_COFUSED)">
                    <StatusConfused />
                </div>
            </div>
            <div class="power-status">
                <div :class="`power gx ${!availablePowers.gx ? 'used' : ''}`" @click="togglePower(POWER_GX)">
                    <PowerGx />
                </div>
                <div :class="`power vstar ${!availablePowers.vstar ? 'used' : ''}`" @click="togglePower(POWER_VSTAR)">
                    <PowerVstar />
                </div>
            </div>
        </div>
        <div class="bench">
            <div class="benched-mon" v-for="b in 5">
                <div v-if="bench[b - 1]">
                    <span>{{ getBenchedInfo(b - 1, 'damage') }}</span>
                </div>
                <div v-else @click="addBenchedMon()">
                    +
                </div>
            </div>
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
                cursor pointer

                svg
                    width 70%
                    opacity .3
                    transition opacity .2s
                    position absolute
                    z-index 1

                .status
                    width 3em
                    height 3em
                    border-radius 50%
                    border 1px solid rgba(255, 255, 255, .25)
                    background rgba(0, 0, 0, .5)
                    display flex
                    align-items center
                    justify-content center
                    position relative
                    overflow hidden

                    &.active
                        &:before
                            content ''
                            display block
                            position absolute
                            width 80%
                            height 80%
                            border-radius 50%
                            filter blur(10px)
                            z-index 0
                            opacity .5
                            transition background .3s

                        svg
                            opacity 1

                    &.poisoned.active:before
                        background #9700ff

                    &.burned.active:before
                        background #ff0054

                    &.asleep.active:before
                        background #00b7ff

                    &.paralyzed.active:before
                        background #ffbf00

                    &.confused.active:before
                        background #00ff64

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
                    overflow hidden
                    position relative
                    cursor pointer

                    &.used 
                        background rgba(0, 0, 0, .2)

                        svg 
                            opacity .15


                    &:not(.used).gx:before
                        content ''
                        width 120%
                        height 75%
                        border-radius 50%
                        background red
                        position absolute
                        top -25%
                        left -35%
                        z-index -1
                        filter blur(1.5em)
                        opacity .6
                        transform rotate(-25deg)

                    &:not(.used).gx:after
                        content ''
                        width 220%
                        height 100%
                        border-radius 50%
                        background #349eeb
                        position absolute
                        bottom -35%
                        right -105%
                        opacity .75
                        z-index -2
                        filter blur(1.5em)
                        
                    &:not(.used).vstar:before
                        content ''
                        width 100%
                        height 60%
                        border-radius 50%
                        background #ead980
                        position absolute
                        z-index -1
                        filter blur(1.5em)
                        opacity .8

                    svg
                        width 60%

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
                cursor pointer
</style>
