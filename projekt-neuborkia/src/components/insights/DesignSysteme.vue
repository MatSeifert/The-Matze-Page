<script setup lang="ts">
import _ from 'lodash'
import insights from '@/data/insights.json'
import InsightSnippet from '@/components/elements/InsightSnippet.vue'

const insight = _.get(insights, ['designsysteme'])
const uipsychology = _.get(insights, ['uipsychology'])

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
        <div class="flex gap-3">
            <div class="text width-1 flex-1-0-0">
                <h3>Was ist ein Design System?</h3>
                <p>
                    Im Grunde genommen ist ein Design System gleichzeitig ein Regelwerk und eine Bauanleitung. In ihm wird festgelegt, wie einzelne Aspekte des Designs oder auch ganze Konzepte 
                    gestaltet werden und welche Rahmenbedingungen sowohl im kreativen Prozess, als auch bei der Umsetzung beachtet werden sollten. Der Umfang dieser Regeln reicht dabei von der 
                    Definition einer Primärfarbe bis hin zur Festlegung genauer Abstände, Stile oder Schriftgrößen. Die Kunst eines wirklich guten Design Systems liegt jedoch darin, die sensible 
                    Balance zwischen einem zu engem Regelkorsett und dem kreativem Freiraum nicht aus dem Gleichgewicht zu bringen.
                </p>
            </div>
            <div class="text width-1 flex-1-0-0">
                <h3>Vorteile und Nutzen eines Design Systems</h3>
                <p>
                    Auf den ersten Blick sind mit der Erstellung und Verwendung eines Design Systems auch einige Nachteile verbunden. So benötigt die Erstellung zunächst einiges an Zeit, je nach 
                    Detailgrad können gut und gern auch mal mehrere Wochen Arbeit anfallen. Zudem schränken fixe Regeln und Bedingungen den kreativen Freiraum beim Gestalten natürlich etwas ein, 
                    da man für zahlreiche Elemente verschiedene Eigenschaften wie Größe, Farbe oder Abstände nicht mehr nach belieben festlegen kann. <br />
                    Natürlich sind all die Punkte nicht von der Hand zu weisen, doch letztlich überwiegen die Vorteile nicht nur, auch vermeintliche Nachteile entpuppen sich am Ende oft ebenfalls 
                    als Vorteil. Die Erstellung eines durchdachten Design Systems schafft oft die Basis für eine Nutzerfreundliche, wartbare und zukunftssichere Software.
                </p>
            </div>
        </div>

        <div class="quote">
            „Die Kunst eines Design Systems liegt darin, die sensible Balance zwischen zu engem Regelkorsett und kreativem Freiraum zu halten.“
        </div>

        <div class="flex gap-3">
            <div class="text width-1 flex-1-0-0">
                <h4>
                    Vorteile für Designer &amp; Entwickler
                </h4>
                <p>Als Designer hat man zwar zunächst natürlich erstmal die Arbeit das Design System selbst zu erstellen, allerdings profitiert man in allen folgenden Schritten bereits selbst 
                    davon, denn wenn es um die Platzirung verschiedener Seitenelemente geht hilft es ungemein, wenn Abstände oder Größen bereits definiert sind. Man muss sich nicht mehr bei jedem 
                    neuen UI-Baustein die Frage stellen, wie und wo er im Gesamtbild der Seite stehen soll. Das schafft Konsistenz und Wiedererkennbarkeit, zudem hilft es dem Benutzer oder Kunden, 
                    sich zurecht zu finden, da wichtige Elemente an gewohnten Stellen zu finden sind. Als Entwickler profitiert man auf ganz ähnliche Art und Weise davon, denn aus den festgelegten 
                    Regelwerten lassen sich bereits erste CSS-Regelungen ableiten und festhalten. Diese Style-Klassifizierungen lassen sich dann ganz einfach überall im Projekt nutzen und sparen
                    wertvolle Zeit.    
                </p>
                <InsightSnippet key="uipsychology" :insight="uipsychology" :hideImage="true"/>
            </div>
            <div class="text width-1 flex-1-0-0">
                <h4>Benutzer sind lernwillige Gewohnheitstiere</h4>
                <p>
                    Wenn man eine Tätigkeit so oft auf die immer gleiche Art ausgeführt hat, dass man sie ohne darüber nachzudenken ausführen kann, spricht man von „Muscle Memory“. In der Welt des
                    Designs beschriebt dieser Begriff die Gewohnheit, UI-Elemente an bestimmten, vertrauten Stellen zu finden und dann damit zu interagieren. Vermutlich hat sich jeder schon einmal
                    irgendwo „verklickt“, weil eine Schaltfläche plötzlich an einer anderen Stelle zu finden war, als die tausenden Male zuvor. Oder als analoges Beispiel: Der Einkauf im Supermarkt
                    kann zur zeitlichen Herausforderung werden, wenn mal wieder die Regale neu eingeräumt oder sogar alles umgebaut wurde.
                </p>
                <p>
                    Diese Gewohnheiten kann man sich zunutze machen, indem man Elemente dort platziert, wo sie von Benutzer erwartet werden, da er bereits bei anderen Seiten oder Anwendungen gelernt
                    hat, wo bestimmte Elemente in der Regel zu finden sind. Aus diesem Grund haben Dialogfenster auf Webseiten oftmals oben links einen Schließen-Button mit einem „x“. Das kennt man
                    so bereits von Windows oder auch MacOS (auch wenn da der Schließen Button etwas anders aussieht, ist er doch zumindest in einer oberen Ecke zu finden). Gleichzeitig kann es aber
                    auch ungemein frustrierend sein, wenn gegen diese Gewohnheiten verstoßen wird. Wer mehr über Gewohnheiten erfahren möchte, wie man sie bewusst einsetzen und steuern kann, aber
                    auch wie sie oftmals zur Manipulation genutzt werden, findet im Bereich <a class="no-hover-effect text-link" href="/insights/uipsychology" title="Psychologie im UI Design" 
                    alt="Link zum weiterführenden Artikel „Psychologie im UI Design“">„Psychologie im UI Design“</a> spannende Einblicke.
                </p>
                <p>
                    Im Hinblick auf das Design System lässt sich dieses Wissen nutzen, um Gewohnheiten gewissermaßen zu trainieren. Hat man als Benutzer an einer Stelle eine Auswahl zwischen mehreren
                    Optionen, kann es vorteilhaft sein die präferierte Wahl, oder die wahrscheinlichste gegenüber den anderen Optionen hervorzuheben, etwa indem man einen primären, einen sekundären
                    und manchmal sogar einen tertiären Button anbietet. Das erleichtert die Auswahl, da man nicht erst visuell erfassen muss, welcher der Buttons beispielsweise ein gerade bearbeitetes
                    Dokument speichert, und welches alle Änderungen wieder verwirft. Gewohnheiten zu kennen ist also enorm wichtig, und ein Design System kann helfen für solche Situationen die
                    richtigen Werkzeuge bereitzustellen. Denn am Ende sind auch die Menschen, die an statt mit einem System arbeiten Gewohnheitstiere und freuen sich, wenn nicht jede Entscheidung
                    aufs Neue sorgfältig überlegt sein muss.
                </p>
            </div>
        </div>

        <div class="flex gap-3">
            <div class="text width-1 flex-1-0-0">
                <h3>Das ist drin - Design Systeme im Detail</h3>
                <p>
                    Doch was steckt konkret drin in einem Design System? Da der Nutzen und die Vorteile klar geworden sind, lohnt es sich einen genaueren Blick unter die Haube zu wagen, und sich im 
                    Detail anzuschauen, wie ein Design System aufgebaut sein kann und welche Regelungen darin konkret zu finden sind.
                </p>
            </div>
            <div class="text width-1 flex-1-0-0">
                <p>
                    Es ist an dieser Stelle jedoch auch wichtig zu betonen, dass es 
                    nicht „den einen“ perfekten Guide zur Erstellung eines Design Systems gibt. Oftmals sind die Ansprüche daran ganz unterschiedlich: Für kleinere Projekte reichen eventuell bereits
                    ein paar grob ausgearbeitete Regeln, während bei größeren Vorhaben mit verschiedenen Beteiligten eine sehr detaillierte Ausarbeitung durchaus sinnvoller sein kann. Auch soll hier
                    kein Anspruch auf Vollständigkeit erhoben werden, wichtig ist am Ende immer, dass die Menschen, die mit einem Design System arbeiten sollen, letztlich so wenig offene Fragen wie
                    möglich haben und sich gut darin zurechtfinden. Viel mehr zeige ich hier einen Ausschnitt dessen, wie ich in der Vergangenheit erfolgreich Design Systeme eingesetzt und entwickelt
                    habe.
                </p>
            </div>
        </div>
        <div class="flex gap-3">
            <div class="text width-1 flex-1-0-0">
                <h4>Grundlagen und Konzepte</h4>
                <p>
                    Noch bevor man in die Details ausarbeitet, ist es sinnvoll sich zunächst einen Überblick über das Projekt selbst zu verschaffen. Dazu zählt zunächst ersteinmal eher das Sammeln von
                    Meta-Informationen: 
                </p>
                <ul>
                    <li>Welche Ziele sollen erreicht werden?</li>
                    <li>Was ist die Markenausrichtung des Projektes?</li>
                    <li>Welche Zielgruppe soll angesprochen werden?</li>
                    <li>Für welche Plattformen oder Medien soll das Projekt angeboten werden?</li>
                </ul> 
                <p>
                    Kurzum: Zunächst muss klar sein, welche DNA ein Projekt mitbringt, um anschließend detaillierte und zugeschnittene Regeln definieren zu können. Hier kann es oft helfen, sich zunächst
                    ein sogenanntes „Moodboard“ zusammenzustellen. Dabei handelt es sich um eine Sammlung verschiedener Medien, die zur Stimmung oder Markenidentität des Vorhabens passen. Von Screenshots
                    ähnlicher Produkte, über Schriftarten oder auch Fotos ist hier grundsätzlich alles erlaubt. Ziel ist es, sich selbst einen Überblick darüber zu verschaffen, welche Idee das Projekt
                    verfolgt, denn erst wenn diese klar ist, können alle Weiteren Entscheidungen wirklich sinnvoll getroffen werden. 
                </p>
            </div>
            <div  class="image img-rounded width-1 flex-1-0-0">
                <img :src="'../images/insights/moodboard.webp'" alt=""/>
                <span class="caption">Ein klassisches Moodboard mit Inspirationen und ersten Ideen</span>
            </div>
        </div>
        <div class="flex gap-3">
            <div class="text image img-rounded width-1 flex-1-0-0">        
                <h4>Wireframes</h4>
                <p>
                    Zur Erstellung von sogenannten „Wireframes“ ist es nicht zwingend notwendig, sich vorher ein Moodboard zu erstellen, es ist aber dennoch oftmals schon hilfreich. Beim wireframing
                    kommen weder Farben noch konkrete Schriftarten zum Einsatz, theoretisch muss es nicht einmal digital erfolgen, es reicht bereits ein Stift und Papier (tatsächlich wird auch
                    hin und wieder noch so gearbeitet). Vielmehr soll in diesem Schritt der grundlegende Aufbau und ein grobes Gerüst konzipiert werden, die dann im weiteren Verlauf des Entwicklungsprozeses
                    detaillierter ausgearbeitet werden.
                </p>
                <img :src="'../images/insights/wireframes.webp'" alt=""/>
                <span class="caption">Erste Wireframes muten zunächst spartanisch an, reduzieren aber das Design auf das Wesentliche</span>
            </div>
            <div class="text width-1 flex-1-0-0">        
                <h4>Layout-Constraints</h4>
                <p>Text</p>
            </div>
        </div>
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
        font-family DM Serif Display

        &:after
            display none

    h2
        text-align right
        margin-top 2em
        opacity .66
        
.designsystem-content
    p
        text-align justify
        hyphens auto
        line-height 1.66em

    h3
        margin-top 3em

    h4
        margin-bottom -.5em
        margin-top 1.5em
</style>