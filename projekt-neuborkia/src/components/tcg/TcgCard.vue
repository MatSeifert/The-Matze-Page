<script lang="ts">
    export default {
        props: {
            cardName: String,
            amount: Number
        }
    }
</script>

<template>
    <div class="card-wrapper">
        <img v-for="i in amount" 
             :class="`card card-${i}`"
             :src="`/src/assets/images/tcg/decks/${cardName}.png`" />
    </div>
</template>

<style lang="stylus" scoped>
    .card-wrapper
        position relative
        width calc(25% - 5em)

        img.card
            width 100%
            border-radius .8em
            box-shadow: 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22);
            transition all .1s

            &:hover
                transform scale(1.3)

            &.card-2
                position absolute
                border-radius .7em
                bottom -1em
                z-index -1
                width 95%
                left 2.5%

            &.card-3
                position absolute
                border-radius .6em
                bottom -2em
                z-index -2
                width 90%
                left 5%

            &.card-4
                position absolute
                border-radius .4em
                bottom -3em
                width 85%
                z-index -3
                left 7.5%
</style>