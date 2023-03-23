import { defineStore } from "pinia";

export const usePhotoFrameStore = defineStore("photoFrame", {
    state: () => {
        return {
            photoFrameKey: '',
            isActive: false,
            activeImage: 0,
            totalImages: 10
        }
    },
    getters: {
        getActiveImage: (state) => state.activeImage,
        getActiveState: (state) => state.isActive,
        getTotalImages: (state) => state.totalImages,
        getPhotoFrameKey: (state) => state.photoFrameKey
    },
    actions: {
        registerPhotos(totalPhotos: number) {
            this.totalImages = totalPhotos
        },
        toggleFrame() {
            this.isActive = !this.isActive
        },
        nextImage() {
            if (this.activeImage == this.totalImages) {
                this.activeImage = 0
            } else {
                this.activeImage++
            }
        },
        prevImage() {
            if (this.activeImage == 0) {
                this.activeImage = this.totalImages
            } else {
                this.activeImage--
            }
        }
    }
});
