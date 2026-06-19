<script setup lang="ts">
import _ from 'lodash'
import insigts from '@/data/insights.json'

const insight = _.get(insigts, ['designsysteme'])

const getImage = () => {
    return `../images/insights/designsysteme.webp`;
}
</script>

<template>
    <div class="designsystem-hero">
        <img :src="getImage()">
        <h1>{{ insight.title }}</h1>
        <h2>{{ insight.subTitle }}</h2>
    </div>
    <div class="designsystem-content">
        <h3>Was ist ein Design System?</h3>
        <p>
            Im Grunde genommen ist ein Design System gleichzeitig ein Regelwerk und eine Bauanleitung. In ihm wird festgelegt, wie einzelne Aspekte des Designs oder auch ganze Konzepte gestaltet werden und welche Rahmenbedingungen sowohl im kreativen Prozess, als auch bei der Umsetzung beachtet werden sollten. Der Umfang dieser Regeln reicht dabei von der Definition einer Primärfarbe bis hin zur Festlegung genauer Abstände, Stile oder Schriftgrößen. Die Kunst eines wirklich guten Design Systems liegt jedoch darin, die sensible Balance zwischen einem zu engem Regelkorsett und dem kreativem Freiraum nicht aus dem Gleichgewicht zu bringen.
        </p>
        <h3>Vorteile und Nutzen eines Design Systems</h3>
        <p>
            Auf den ersten Blick sind mit der Erstellung und Verwendung eines Design Systems auch einige Nachteile verbunden. So benötigt die Erstellung zunächst einiges an Zeit, je nach Detailgrad können gut und gern auch mal mehrere Wochen Arbeit anfallen. Zudem schränken fixe Regeln und Bedingungen den kreativen Freiraum beim Gestalten natürlich etwas ein, da man für zahlreiche Elemente verschiedene Eigenschaften wie Größe, Farbe oder Abstände nicht mehr nach belieben festlegen kann. <br />
            Natürlich sind all die Punkte nicht von der Hand zu weisen, doch letztlich überwiegen die Vorteile nicht nur, auch vermeintliche Nachteile entpuppen sich am Ende oft ebenfalls als Vorteil. Die Erstellung eines durchdachten Design Systems schafft oft die Basis für eine Nutzerfreundliche, wartbare und zukunftssichere Software.
        </p>
        <h4>
            1. Vorteile für Designer &amp; Entwickler
        </h4>
        <p>Als Designer hat man zwar zunächst natürlich erstmal die Arbeit das Design System selbst zu erstellen, allerdings profitiert man in allen folgenden Schritten bereits selbst davon. Denn ebenso wie Entwickler geht die Erstellung von Inhalten deutlich einfacher und schneller, da es bereits feste Regeln und Vorgaben gibt. </p>

        <h3>Das ist drin - Design Systeme im Detail</h3>
        <p>
            Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.  Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam.
        </p>
        <h4>Grundlagen und Konzepte</h4>
        <p>Text</p>
        <h4>Layout-Constraints</h4>
        <p>Text</p>
        <h4>Farbkonzeption</h4>
        <p>Text</p>
        <h4>Typographie</h4>
        <p>Text</p>
        <h4>Icons</h4>
        <p>Text</p>
        <h4>Komponenten</h4>
        <p>Text</p>
    </div>
</template>

<style lang="stylus" scoped>
@import '../../styles/config.styl'

.designsystem-hero
    position relative
    height 80vh
    display flex
    flex-direction column
    justify-content center

    img
        position absolute
        left 0
        height 95%
        z-index 1
        filter drop-shadow(0 0 10em rgba(primaryColor, 0.66))
        pointer-events none

    h1
        margin 0
        font-size 14em
        line-height .8em
        font-weight 900
        text-align right
        mix-blend-mode soft-light

        &:after
            display none

    h2
        text-align right
        margin-top 2em
        opacity .66
        
.designsystem-content
    p
        max-width 40em
        text-align justify
        hyphens auto
        line-height 1.66em

    h3
        margin-top 3em

    h4
        margin-bottom -.5em
        margin-top 1.5em
</style>