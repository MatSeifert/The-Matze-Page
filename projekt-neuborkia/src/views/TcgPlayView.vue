<script lang="ts">
import _ from 'lodash'
import StatusPoisoned from '@/components/tcg/icons/StatusPoisoned.vue'
import StatusBurned from '@/components/tcg/icons/StatusBurned.vue'
import StatusAsleep from '@/components/tcg/icons/StatusAsleep.vue'
import StatusParalyzed from '@/components/tcg/icons/StatusParalyzed.vue'
import StatusConfused from '@/components/tcg/icons/StatusConfused.vue'
import PowerGx from '@/components/tcg/icons/PowerGx.vue'
import PowerVstar from '@/components/tcg/icons/PowerVstar.vue'
import HeroiconExtend from '@/components/icons/heroicons/HeroiconExtend.vue'
import HeroiconMinimize from '@/components/icons/heroicons/HeroiconsMinimize.vue'
import { ref } from 'vue'
import { useFullscreen } from '@vueuse/core'

export default {
    setup() {
        const el = ref(null)
        const { toggle, isFullscreen } = useFullscreen(el)

        return {
            toggle,
            isFullscreen
        }
    },
    data() {
        return {
            active: {
                damage: 0,
                poisoned: false,
                burned: false,
                asleep: false,
                paralyzed: false,
                confused: false
            } as any,
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
            POWER_VSTAR: 'vstar',
            selectedDamageAdder: 10,
            switchDialogActive: false
        }
    },
    methods: {
        addDamage(position: number, addDamage: boolean) {
            const damageAmount = this.selectedDamageAdder

            if (position == -1) {
                // Active Pokémon
                if (addDamage) {
                    this.active.damage += damageAmount
                } else {
                    if (this.active.damage - damageAmount < 0) {
                        this.active.damage = 0
                    } else {
                        this.active.damage -= damageAmount
                    }
                }
            } else {
                if (!this.bench[position]) return
                const relevantMon = this.bench[position] as any

                if(addDamage) {
                    relevantMon.damage += 10
                } else {
                    if (relevantMon.damage - damageAmount < 0) {
                        relevantMon.damage = 0
                    } else {
                        relevantMon.damage -= damageAmount
                    }
                }
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
        },
        getBenchedInfo(index: number, prop: string) {
            const relevantMon = this.bench[index];

            if(!relevantMon) {
                console.warn(`No Pokémon found on Bench at index ${index}`)
                return
            }

            return _.get(relevantMon, [prop], '')
        },
        setActiveMon(mon: any) {
            this.active = mon
        },
        setDamageAdder(adder: number) {
            this.selectedDamageAdder = adder
        },
        knockOut(position: number) {
            if (position > -1) {
                // benched mon was knocked out
                this.bench.splice(position, 1)
            } else {
                this.active = {
                    damage: 0,
                    poisoned: false,
                    burned: false,
                    asleep: false,
                    paralyzed: false,
                    confused: false
                }

                this.selectedDamageAdder = 10

                if(this.bench.length == 1) {
                    // switch last remaining mon in automatically
                    this.switchOut(0, true)
                } else if(this.bench.length != 0) {
                    this.switchDialogActive = true
                }
            }
        },
        switchOut(index: number, activeMonWasKnockedOut: boolean) {
            // cannot switch out, if the bench or the given spot is empty
            if (!this.bench.length || !this.bench[index]) return

            // Deep Clone, we dont want to store a reference
            const temp = Object.assign({}, this.active)
            this.active = Object.assign({}, this.bench[index])

            // recovering from special conditions
            temp.poisoned = false
            temp.burned = false
            temp.asleep = false
            temp.paralyzed = false
            temp.confused = false

            this.bench.splice(index, 1)

            if (!activeMonWasKnockedOut) {
                this.bench.push(temp)
            } else {
                this.switchDialogActive = false
            }
        }
    },
    components: {
        StatusPoisoned,
        StatusBurned,
        StatusAsleep,
        StatusParalyzed,
        StatusConfused,
        PowerGx,
        PowerVstar,
        HeroiconExtend,
        HeroiconMinimize
    }
}
</script>

<template>
    <div class="toggle-fullscreen" @click="toggle">
        <HeroiconExtend v-if="!isFullscreen"/>
        <HeroiconMinimize v-if="isFullscreen"/>
    </div>
    <div v-if="switchDialogActive" class="switch-dialog">
        Wähle das neue aktive Pokémon
    </div>
    <div class="play-area" ref="el">
        <div :class="`active-area ${switchDialogActive ? 'blur' : ''}`">
            <div class="active-mon">
                <div class="damage-bar">
                    <div @click="addDamage(-1, false)">-</div>
                    <div :class="selectedDamageAdder == 10 ? 'active' : ''" @click="setDamageAdder(10)">10</div>
                    <div :class="selectedDamageAdder == 20 ? 'active' : ''" @click="setDamageAdder(20)">20</div>
                    <div :class="selectedDamageAdder == 30 ? 'active' : ''" @click="setDamageAdder(30)">30</div>
                    <div :class="selectedDamageAdder == 50 ? 'active' : ''" @click="setDamageAdder(50)">50</div>
                    <div @click="addDamage(-1, true)">+</div>
                </div>
                <div class="damage">{{ active.damage }}</div>
                <div class="action-bar">
                    <div class="knocked-out" @click="knockOut(-1)">
                        besiegt
                    </div>
                </div>
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
            <div :class="`benched-mon ${bench[b - 1] ? 'assigned' : 'empty'}`" v-for="b in 5">
                <div v-if="bench[b - 1]">
                    <div class="bench-action" @click="switchOut(b - 1, switchDialogActive)">
                        {{ switchDialogActive ? 'auswählen' : 'tausch' }}
                    </div>

                    <div class="bench-hp-bar">
                        <div class="add-bench-damage substract" @click="addDamage(b - 1, false)">-</div>
                        <span>{{ getBenchedInfo(b - 1, 'damage') }}</span>
                        <div class="add-bench-damage add" @click="addDamage(b - 1, true)">+</div>
                    </div>

                    <div class="bench-action" @click="knockOut(b - 1)">
                        besiegt
                    </div>
                </div>
                <div v-else @click="addBenchedMon()">
                    +
                </div>
            </div>
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    .toggle-fullscreen
        position fixed
        top 2em
        right 2em
        cursor pointer

        svg
            width 1.5em

    .play-area
        display flex
        flex-direction column
        justify-content space-around
        height calc(100vh - 10em)

        .active-area
            display flex
            gap 5em
            justify-content center

            &.blur
                filter blur(10px)
        
            .active-mon
                width 5em
                height 7em
                border-radius .5em
                border 1px solid rgba(255, 255, 255, .25)
                background rgba(0, 0, 0, .5)
                display flex
                flex-direction column
                align-items center
                justify-content center
                gap 1em
                font-size 3em
                font-weight 800

                .damage-bar, .action-bar
                    display flex
                    font-size .3em
                    font-weight 600
                    border 1px solid rgba(255, 255, 255, .3)
                    border-radius 2em
                    overflow hidden

                .damage-bar > div
                    padding .7em
                    border-right 1px solid rgba(255, 255, 255, .2)
                    background rgba(0, 0, 0, .5)
                    cursor pointer
                    color rgba(255, 255, 255, .4)

                    &.active
                        background: linear-gradient(to bottom,#353535,#1e1e1e);
                        color #fff

                    &:first-child
                        padding .7em .8em .7em 1em
                        position relative
                        color #ff0054

                        &:before
                            background #ff0054

                    &:last-child
                        padding .7em 1em .7em .8em
                        border none 
                        position relative
                        color #00ff64

                        &:before
                            background #00ff64

                    &:first-child:before, &:last-child:before
                        content ''
                        display block
                        width 80%
                        height 80%
                        position absolute
                        top 10%
                        left 10%
                        z-index -1
                        filter blur(10px)
                        opacity .8

                .knocked-out, .switch-out
                    flex 1
                    color #fff
                    text-transform uppercase
                    padding .7em 1em
                    cursor pointer

                .knocked-out
                    border-right 1px solid rgba(255, 255, 255, .2)

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
                display flex
                justify-content center
                align-items center
                cursor pointer
                border-radius .5em

                > div
                    display flex
                    flex-direction column
                    justify-content space-around
                    align-items center
                    height 100%
                    width 100%

                    .bench-action
                        text-transform uppercase
                        font-size .33em
                        border 1px solid rgba(255, 255, 255, .2)
                        display inline-block
                        padding .7em 1em
                        border-radius 2em

                &.empty > div
                    width 100%
                    height 100%
                    display flex
                    align-items center
                    justify-content center
                    border-radius .5em
                    border 1px dashed rgba(255, 255, 255, .3)
                    background rgba(0, 0, 0, .15)
                    color rgba(255, 255, 255, .3)

                &.assigned
                    border 1px solid rgba(255, 255, 255, .3)
                    background rgba(0, 0, 0, .5)

                    .bench-hp-bar
                        display flex
                        align-items center
                        justify-content center
                        gap .25em
                        width 100%
                    
                        .add-bench-damage
                            width 2em
                            height 2em
                            border 1px solid rgba(255, 255, 255, .2)
                            border-radius 50%
                            display flex
                            align-items center
                            justify-content center
                            font-size .5em
                            cursor pointer

                            &.add, &.substract
                                position relative
                                overflow hidden

                                &:before
                                    content ''
                                    display block
                                    width 60%
                                    height 60%
                                    z-index -1
                                    border-radius 50%
                                    position absolute
                                    left 20%
                                    top 20%
                                    filter blur(15px)
                                    opacity .5

                            &.add
                                color #00ff64

                                &:before
                                    background #00ff64

                            &.substract
                                color #ff0054

                                &:before
                                    background #ff0054

    .switch-dialog
        position absolute
        z-index 1
        width 100%
        height 50vh
        background linear-gradient(to bottom, rgba(0, 0, 0, .5) 75%, rgba(0, 0, 0, 0) 100%)
        display flex
        align-items center
        justify-content center
        font-size 3em
        font-weight 800
        top 0
        left 0

    @media screen and (max-width: 1600px)            
        .play-area
            font-size 14px

            .bench
                margin-top 2em

    @media screen and (max-width: 1200px)    
        .play-area
                font-size 12px

    @media screen and (max-width: 1000px)    
        .play-area
                font-size 10px
                margin-top -5em

    @media screen and (max-width: 1000px)    
        .play-area
            margin-top -8em
            font-size 8px
            width calc(100% + 20em)
            margin-left -10em

            .active-area
                gap 10em

                .active-mon .damage-bar
                    font-size .5em

                .active-mon .action-bar
                    font-size .6em
                
                .active-mon-status
                    gap 1em 
                    max-width 15%
                    flex-wrap wrap
                    flex-direction row
                    
                    .status
                        width 5em
                        height 5em

            .bench 
                .benched-mon.assigned 
                    .bench-action
                        font-size .6em

                    .bench-hp-bar
                        gap .75em
                        width auto
                        
                        .add-bench-damage
                            background #000
                            border 1px solid rgba(255, 255, 255, .5)
                            width 3em
                            height 3em

        .switch-dialog
            font-size 1.5em
</style>
