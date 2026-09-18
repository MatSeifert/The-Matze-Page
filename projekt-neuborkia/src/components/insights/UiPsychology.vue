<script setup lang="ts">
import _ from 'lodash'
import insights from '@/data/insights.json'
import RecommendationBlock from './RecommendationBlock.vue'

// Images
import heroImage from '@/assets/images/insights/uipsychology.webp'
import appBar from '@/assets/images/insights/app-bar.webp'
import xikipedia from '@/assets/images/insights/xikipedia.webp'
import dpBahn from '@/assets/images/insights/dp-bahn.webp'
import dpBesserImGlas from '@/assets/images/insights/dp-besserimglas.webp'
import dpHeise from '@/assets/images/insights/dp-heise.webp'
import dpKleinanzeigen from '@/assets/images/insights/dp-kleinanzeigen.webp'
import dpRewe from '@/assets/images/insights/dp-rewe.webp'
import dpOtto from '@/assets/images/insights/dp-otto.webp'

const insight = _.get(insights, ['uipsychology'])

</script>

<template>

    <div class="insight-hero uipsychology">
        <div class="hero-image">
            <img :src="heroImage">
        </div>
        <div class="hero-text">
            <h1>{{ insight.title }}</h1>
            <h2>{{ insight.subTitle }}</h2>
        </div>
    </div>

    <div class="designsystem-content insight-content">

        <div class="text">
            <h3>Menschen sind Gewohnheitstiere</h3>
            <p>
                Gewohnheiten sind an und für sich eine ziemlich praktische Sache, denn sie sparen uns täglich jede Menge
                Energie, indem sie unser Gehirn für wiederkehrende Aufgaben quasi auf Autopilot schalten. Niemand möchte
                jeden Morgen direkt nach dem Aufstehen erstmal eine Aufwach-Routine erarbeiten, die zudem aus den immer
                weider fast identischen Aufgaben besteht: Zähne putzen, waschen, anziehen, Haare kämmen. Was auch immer
                dazu gehört, kaum jemand denkt wirklich groß darüber nach was morgens zu tun ist – man macht es eben
                einfach, so wie man es schon hunderte Male gemacht hat.
            </p>
        </div>

        <div class="image">
            <img :src="appBar" alt="Beispiele des App-Starters am unteren Bildschirm" />
            <span class="caption">Alle gängigen Betriebssysteme platzieren den Standart App-Launcher am unteren
                Bildschirmrand</span>
        </div>

        <div class="text">
            <p>
                Dieser Autopilot hilft uns im Alltag mehrmals täglich, damit unsere Denkkapazitäten für die wirklich
                relevanten Probleme frei bleiben. Auch bei der Benutzung eines PCs, Tablets oder Smartphones haben wir
                Routinen und Gewohnheiten, die uns über die Jahre hinweg antrainiert wurden, und auf die wir immer
                wieder zurückgreifen. Die Schnellstartleiste für Apps ist beispielsweise fast immer am unteren Rand des
                Bildschirms. Auch wenn es jetzt natürlich den Ein oder Anderen gibt, bei dem sie da nicht platziert ist,
                hat es einen Grund, dass sie in den Standardeinstellungen bei Windows, MaxOS, iOS, Android und auch
                vielen Linux Desktopumgebungen meist unten zu finden ist. Der Großteil der Benutzer ist genau daran
                gewöhnt.
            </p>

            <h3>Gewohnheiten zu verstehen kann dem Nutzer helfen</h3>
            <p>
                Diese Gewohnheiten zu kennen ist ein essenzieller Teil im Bereich UI / UX. Denn wer weiß, wie Menschen
                nach Dingen suchen, kann ihnen dabei helfen sie schnell und einfach zu finden. Ein Benutzer verwendet
                eine Webseite oder eine Anwendung, weil er ein bestimmtes Anliegen oder Bedürfnis hat. Das kann im
                einfachsten Fall die Suche nach einer Information sein, es kann allerdings auch der Wunsch sein, etwas
                zu kaufen, eine Dienstleistung in Anspruch zu nehmen, oder aber es ist schlicht die Suche nach
                Unterhaltung. Als Designer und Entwickler ist die wichtigste Aufgabe, diese „Probleme“ der Suche so zu
                lösen, dass man als Benutzer nicht erst groß darüber nachdenken muss, wo die gesuchte Information zu
                finden ist.
            </p>
        </div>

        <div class="quote">
            „Als Designer und Entwickler ist die wichtigste Aufgabe, die Probleme der Nutzer zu lösen.“
        </div>

        <div class="text">
            <p>
                Mit dem Wissen über erlernte Gewohnheiten ist es also möglich, die Aufmerksamkeit und den Blick so zu
                steuern, dass es möglichst einfach ist, die gewünschte Aktion zu finden und auszuführen. Konkret kann
                das beispielsweise die klassische Call-to-Action sein, wie etwa der Button für eine Projektanfrage auf
                dieser Seite. Auch die Buttons für den Kauf oder das Legen in den Warenkorb bei Online-Shops werden in
                der Regel prominent platziert und hervorgehoben, sodass es keine große Herausforderung ist, ein Produkt
                zu kaufen. Jedes spezifische Problem benötigt in der Regel eine individuelle Lösung, für die man sich
                antrainierte Gewohnheiten zu Nutze machen kann. Am Ende steht immer das große Ziel, dass die
                Benutzeroberfläche möglichst so intuitiv ist, dass man ohne weiteres Kopfzerbrechen das findet, wonach
                man gerade sucht.
            </p>
        </div>

        <div class="text">
            <h3>Gewohnheiten sind nicht in Stein gemeißelt</h3>
            <p>
                Sich an den Gewohnheiten zu orientieren kann im ersten Moment etwas ernüchternd klingen, fast so als
                hätte man im Grunde gar keine große Wahl oder keine Möglichkeit aus diesem Korsett auszubrechen, Neues
                zu probieren. Alle Seiten und Anwendungen sehen am Ende doch wieder gleich aus, wenn die Gewohnheit der
                Nutzer das UI diktiert, oder?
            </p>
            <p>
                Diese Erkenntnis ist erstens richtig und zweitens falsch. Es stimmt natürlich grundsätzlich schon, dass
                viele Webseiten oder Anwendungen sich im grundlegenden Aufbau stark ähneln, da ihnen die gleichen
                Konzepte zugrunde liegen. Im Umkehrschluss bedeutet das allerdings nicht, dass dadurch sämtliche
                Kreaitivität und Individualität im Keim erstickt wird. Zum Einen gibt es auch innerhalb der gesetzten
                Grenzen der Gewohnheit unendlich viele Möglichkeiten individuelle Akzente zu setzen, andererseits sind
                Gewohnheiten nicht für immer festgeschrieben.
            </p>
            <p>
                Das beste Beispiel hierfür ist das Scrollverhalten der Menschen. Bis etwa zum Ende der 2000er herrschte
                die gängige Meinung vor, dass wichtige Informationen sich immer „above the fold“, also im sichtbaren
                Bereich des Browserfensters, befinden müssen. Alles was nur durch scrollen erreicht werden kann, wird
                deutlich seltener wahrgenommen, da Nutzer oftmals gar nicht erst nach unten scrollen, und wenn sie es
                tun, dann nicht sehr weit. Dieses Paradigma bescherte uns eine Reihe von Websites, deren Startseite
                so gnadenlos überfrachtet waren, dass zwar durchaus alle relevanten Informationen direkt sichtbar waren.
                Gut auffindbar waren sie deswegen jedoch nicht, im Gegenteil. Durch die schiere Masse an Informationen
                kämpften zahlreiche Elemente um die Aufmerksamkeit des Benutzers und man musste sich Mühe geben zu
                finden, was man gerade sucht und alles andere kognitiv auszublenden.
            </p>
            <p>
                Doch dann passierte etwas spannendes: Die sozialen Medien setzten ihren Siegeszug mit voller Wucht in
                den 2010er Jahren fort, Worte wie „Doomscrolling“ wurden geboren, und die Feeds machten das Scrollen von
                Seiten nicht mehr zum No-Go, sondern zum definierten Ziel. <br />
                Das führte nicht nur zu einem geänderten Verhalten der Nutzer, für die das scrollen nach weiteren
                Informationen nun fast schon zum Automatismus wurde, auch die Gestaltung der Startseiten und
                Landingpages änderte sich. Statt möglichst alle wichtigen Details so zu platzieren, dass sie auf dem
                ersten Blick erreichbar sind, konzentriert man sich darauf, den Kern der eigenen Marke, sowie die
                Identität möglichst stark zu präsentieren.
            </p>
        </div>

        <div class="image">
            <img :src="xikipedia" alt="Doomscrolling mit Lehrwert: Zufällige Wikipedia-Artikel als Endlos-Timeline" />
            <span class="caption">Wenn schon Doomscrolling, dann mit Lerneffekt: Auf <a href="https://xikipedia.org/"
                    target="_blank" alt="Link zur Xikipedia Website" class="no-hover-effect text-link">Xikipedia</a>
                werden zufällige Artikel der Eznyklopädie als Endlos-Feed angezeigt</span>
        </div>

        <div class="text">
            <p>
                Dieses Beispiel zeigt deutlich, dass Gewohnheiten zwar tief verankert, aber nicht in Stein gemeißelt
                sind. Natürlich wäre es jetzt vermessen zu glauben, dass man einen vergleichbaren Einfluss auf das
                Nutzerverhalten hat, wie die Big Player der sozialen Medien, doch das muss auch gar nicht das Ziel sein.
                Denn mit dem Wissen um wiederkehrende Nutzungsmuster kann man nicht nur helfen, Dinge zu finden, die
                gefunden werden sollen, man kann auch ganz bewusst aus diesen Mustern ausbrechen, sei es einfach um zu
                überraschen, oder aber um sich von anderen abzuheben. <br />
                Hier ist der Grat auf dem man sich bewegt natürlich recht schmal, denn es darf natürlich kein Frust
                entstehen, weil man an einfachen Bedienkonzepten scheitert. Schafft man es aber, dem Besucher ein kurzes
                innerliches „Hui“ zu entlocken, ist die Wahrscheinlichkeit hoch, dass er mehr interagiert und neugierig
                wird.
            </p>
        </div>

        <div class="text">
            <h3>Dark Patterns - Wenn Gewohnheiten missbraucht werden</h3>
            <p>
                Kennt man die üblichen Gewohnheiten und Muster, kann man diese jedoch nicht nur unterstützend einsetzen,
                es eröffnet auch die Möglichkeiten dieses Wissen zu missbrauchen – und so möglicherweise den Benutzer
                dazu verleiten Dinge anzuklicken, die er gar nicht anklicken wollte. Dieser Missbrauch hat mittlerweile
                sogar einen eigenen Namen bekommen, da es leider immer öfter eingesetzt wird: Dark Patterns.
            </p>
            <p>
                Wer schon einmal zu schnell geklickt und sich dann darüber geärgert hat war möglicherweise unaufmerksam.
                Möglicherweise ist man aber auch einem Dark Pattern zum Opfer gefallen, denn diese sind mittlerweile so
                verbreitet, dass - bewusst oder nicht - wahrscheinlich jeder schon einmal damit in Berührung gekommen
                sein dürfte. Das prominenteste Beispiel dürften die wenig beliebten Cookie-Banner sein. Die grundlegende
                Idee dahinter ist prinzipiell begrüßenswert, da sie einerseits die Transparenz erhöhen, was mit den
                eigenen Daten passiert und andererseits ein gewisses Maß an Kontrolle darüber geben, welche Daten man
                preisgeben möchte.
            </p>
        </div>

        <div class="image">
            <div class="flex gap-3">
                <div class="image img-rounded masonry">
                    <img :src="dpHeise" />
                    <img :src="dpKleinanzeigen" />
                </div>
                <div class="image img-rounded masonry">
                    <img :src="dpRewe" />
                    <img :src="dpOtto" />
                </div>
                <div class="image img-rounded masonry">
                    <img :src="dpBahn" />
                    <img :src="dpBesserImGlas" />
                </div>
            </div>
            <span class="caption">Lediglich die Seite der Deutschen Bahn bietet eine ausgewogene Auswahl. Alle anderen
                heben den Button zum Akzeptieren aller Cookies deutlich hervor, einige verstecken sogar die Ablehnung
                aktiv</span>
        </div>

        <div class="text">
            <p>
                Doch in einer Welt, in der Werbeeinnahmen über Existenzen entscheiden können, besteht ein hohes
                Interesse
                die Ablehnung von Cookies zu verhindern, besonders nicht die der Advertisement-Partner.
                Daher ist der Button zum Akzeptieren der Cookies meist deutlicher hervorgehoben, während die Optionen
                zum Ablehnen visuell weniger markant sind. In einer Stichprobe einiger häufig und weniger häufig
                besuchten deutschen Webseiten wurde diese Muster bei nahezu allen genutzt. Manche hatten immerhin noch
                eine Option zum Ablehnen aller Cookies mit nur einem Klick, andere wiederum verstecken diese Möglichkeit
                hinter uneindeutig beschrifteten Schaltflächen wie „Einstellungen“, hinter denen gern auch mal mehrere
                Dutzend Schalter warten, die dann einzeln abgewählt werden müssen. Wiederum andere Seiten lassen eine
                Nutzung ohne Cookie-Einwilligung generell nicht zu und bieten eine gleichwertig positionierte Option an,
                ein Bezahl-Abo abzuschließen. Legal ist diese Art der Cookie-Banner übrigens nicht, allerdings gibt es
                oftmals weder Kontrollen noch Sanktionen, zum Leidwesen derer, die sich an die Regeln halten.
            </p>
        </div>

        <div class="quote">
            „In einer Welt, in der Werbeeinnahmen über Existenzen entscheiden können, besteht ein hohes Interesse
            die Ablehnung von Cookies zu verhindern.“
        </div>

        <div class="text">
            <p>
                Abseits der in verruf geratenen Cookie-Banner gibt es natürlich viele weitere Muster, die aus ethischer
                Sicht zumindest zweifelhaft sind. So kann die Kündigung von Abonnements einige Nerven rauben, wenn man
                sich
                vorher durch mehrere Abfragen klicken muss, ob man sich wirklich ganz sicher ist, oder ob man nicht doch
                lieber nochmal über den attraktiven und exklusiven Rabatt nachdenken möchte. Auch hier sind die
                hervorgehobenen Optionen natürlich die, mit denen das Abo am Ende doch noch einmal verlängert wird.
            </p>
            <p>
                Eine weitere oft genutzte Methode nennt sich „FOMO“ - die <em>Fear of missing out</em>, also die Angst
                etwas zu verpassen. Für ein Produkt oder eine Dienstleistung wird eine künstliche Knappheit erzeugt, die
                dazu verleiten soll, den Kauf durchzuführen ohne zu lange das Für und Wider abzuwägen. Die Hemmschwelle
                von Personen, nach einem Kauf von diesem zurückzutreten und sein gesetzliches Widerspruchsrecht in
                Anspruch zu nehmen ist wesentlich geringer, als die Hemmschwelle etwas gar nicht erst zu kaufen. Wenn
                etwas also mit „Nur noch 5 Stück auf Lager“, „8 Personen haben das gerade im Warenkorb“ oder „Nur für
                kurze Zeit“ beworben wird, soll damit vor allem eine Kaufentscheidung herbeigeführt werden, eine
                tatsächlich begrenzte Verfügbarkeit existiert aber in aller Regel nicht.
            </p>
            <p>
                Besonders perfide wird es, wenn soziale Konzepte ausgenutzt werden, um die Entscheidungen von Menschen
                zu beeinflussen. Dies geschieht unter anderem, wenn bereits eine Formulierung unterbewusst Druck
                aufbaut, oder ein schlechtes Gewissen macht. Ein super-exklusives Rabattangebot lässt sich
                beispielsweise nur über einen Button ablehnen, der mit „Nein, ich möchte keine tollen Rabatte erhalten“
                beschriftet ist. Es vermittelt ein subtiles schlechtes Gefühl, wenn man dann den Rabatt ablehnt, auch
                wenn man eigentlich eh nichts kaufen wollte.
            </p>
            <p>Von diesen Mustern gibt es noch zahlreiche weitere Beispiele, so kam eine von netzpolitik.org
                durchgeführte Studie zum Ergebnis, dass 77% der meistbesuchten Seiten Deutschlands irreführende Buttons
                nutzen. Eine andere Studie der europäischen Kommisssion fand sogar bei 97% der untersuchten Webseiten
                mindestens ein genutztes „Dark Pattern“. Wer sich dafür interessiert, oder diese Designmuster künftig
                einfacher entlarven möchte, findet auf <a href="https://da-pa.ch/" target="_blank"
                    alt="Umfangreiche Sammlung von Dark Patterns" class="no-hover-effect text-link">da-pa.ch</a>
                zahlreiche Beispiele und Erklärungen rund um das Thema.</p>
        </div>
    </div>

    <RecommendationBlock :recommended="['designsysteme', 'colorTheory', 'typography']" />

</template>

<style lang="stylus" scoped>
@import '../../styles/config.styl'

.insight-hero.uipsychology
    .hero-text
        h1
            font-size 7.45em
            line-height 1.1em

        h2
            margin-top 2em

    .hero-image > img
        width 108%
        transform scale(-1, 1)

</style>