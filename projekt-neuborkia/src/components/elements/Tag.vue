<script lang="ts">
    export default {
        props: {
            type: String,
            label: String
        }
    }
</script>

<template>
    <div :class="`tag ${type}`">{{ label }}</div>    
</template>

<style lang="stylus" scoped>
     @import '../../assets/config.styl'

    .tag
        display inline-block
        padding .25em .5em
        background #202020
        margin .5em
        border-top-left-radius .5em
        border-top-right-radius .5em
        border-bottom-right-radius .5em
        border 1px solid rgba(#fff, .2)
        box-sizing border-box
        position relative
        font-weight 500
        box-shadow 0 3px 6px rgba(0,0,0,0.16), 0 3px 6px rgba(0,0,0,0.23)

        &.design
            background linear-gradient(to top, #001735, #022553)
            color #B1C2D9
            padding-left 2em

            &:before
                display inline-block
                position absolute
                width 1em
                height 1em
                content url('../../assets/images/icon_design.svg')
                margin-right .5em
                left .5em
                top .35em
        
        &.development
            background linear-gradient(to top, #032415, #003C20)
            color #AED6C4
            padding-left 2em

            &:before
                display inline-block
                position absolute
                width 1em
                height 1em
                content url('../../assets/images/icon_dev.svg')
                margin-right .5em
                left .5em
                top .35em

</style>