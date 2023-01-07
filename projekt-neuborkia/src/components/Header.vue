<script>
    import {RouterLink } from 'vue-router'

    export default {
        data() {
            return {
                navBarClass: 'navigation-bar',
                navItemClass: 'navigation-item',
                links: {
                    aboutMe: {
                        id: 'aboutMe',
                        i18n: {
                            de: 'über mich',
                            en: 'about me'
                        }
                    },
                    projects: {
                        id: 'projects',
                        i18n: {
                            de: 'projekte',
                            en: 'projects'
                        }
                    }
                }
            }
        }
    }
</script>

<template>
    <div id="header">
        <h1>matthias seifert</h1>
        <ul :class="navBarClass">
            <li v-for="link in links" :key="link.id" :class="navItemClass">
                <RouterLink tag="a" :to="{path: '', hash: `#${link.id}`}">
                    {{ link.i18n.de }}
                </RouterLink>
            </li>
        </ul>
    </div>
</template>