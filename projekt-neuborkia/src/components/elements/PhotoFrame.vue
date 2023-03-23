<script lang="ts">
    import { usePhotoFrameStore } from '@/stores/photoFrame'

    export default {
        setup() {
            const photoFrame = usePhotoFrameStore()
            return {
                nextImage: photoFrame.nextImage,
                prevImage: photoFrame.prevImage,
                toggleFrame: photoFrame.toggleFrame,
                registerPhotos: photoFrame.registerPhotos,
                getActiveImage: photoFrame.getActiveImage
            }
        },
        props: {
            images: Array,
            activeImage: Number
        },
        mounted() {
            () => this.registerPhotos(this.images?.length || 0)
        }
    }
</script>

<template>
    <div class="photo-frame">
        Aktives Foto: {{ getActiveImage }}
        <div v-for="image of images">
            <img :src="`${image}`" />
        </div>
        <div class="next-photo" @click="nextImage()">next</div>
        <div class="prev-photo" @click="prevImage()">back</div>
        <div class="close-frame">close</div>
    </div>
</template>

<style lang="stylus"></style>