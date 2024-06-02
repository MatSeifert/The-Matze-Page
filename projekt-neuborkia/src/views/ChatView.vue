<script setup lang="ts">
    import Footer from "../components/Footer.vue";
</script>

<template>
    <div class="chat-wrapper">
        <iframe src="https://chat.restream.io/embed?token=235f3c97-f5f3-4723-940f-3f469132eeb1" />
        <div class="footer">
            <Footer />
        </div>
    </div>
</template>

<style lang="stylus" scoped>
    .chat-wrapper
        position relative
        top 0
        left 0
        width calc(100% + 2em)
        height calc(100vh - 2em)
        margin-top -3em
        margin-left -1em

    iframe
        border none
        width 100%
        height calc(100% - 10em)
        padding 1rem

    .footer 
        margin-top -8em
</style>