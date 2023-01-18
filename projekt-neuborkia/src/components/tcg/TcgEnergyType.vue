<script lang="ts">
    export default {
        props: {
            energyType: {
                type: String,
                required: true
            }
        }
    }
</script>

<template>
    <div :class="`tcg-energy ${energyType}`">
        <img :src="`/src/assets/images/tcg/energy/${energyType}.svg`" :alt="`Energy Typ: ${energyType}`"/>
    </div>
</template>

<style lang="stylus" scoped>
    img
        width 2.5em
</style>