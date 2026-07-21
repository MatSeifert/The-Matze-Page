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
    <div class="designsystem-content insight-content">

        <div class="text">
            <h3>Was ist ein Design System?</h3>
            <p>
                Im Grunde genommen ist ein Design System gleichzeitig ein Regelwerk und eine Bauanleitung. In ihm wird
                festgelegt, wie einzelne Aspekte des Designs oder auch ganze Konzepte
                gestaltet werden und welche Rahmenbedingungen sowohl im kreativen Prozess, als auch bei der Umsetzung
                beachtet werden sollten. Der Umfang dieser Regeln reicht dabei von der
                Definition einer Primärfarbe bis hin zur Festlegung genauer Abstände, Stile oder Schriftgrößen. Die
                Kunst eines wirklich guten Design Systems liegt jedoch darin, die sensible
                Balance zwischen einem zu engem Regelkorsett und dem kreativem Freiraum nicht aus dem Gleichgewicht zu
                bringen.
            </p>
        </div>

        <div class="text">
            <h3>Vorteile und Nutzen eines Design Systems</h3>
            <p>
                Auf den ersten Blick sind mit der Erstellung und Verwendung eines Design Systems auch einige Nachteile
                verbunden. So benötigt die Erstellung zunächst einiges an Zeit, je nach
                Detailgrad können gut und gern auch mal mehrere Wochen Arbeit anfallen. Zudem schränken fixe Regeln und
                Bedingungen den kreativen Freiraum beim Gestalten natürlich etwas ein,
                da man für zahlreiche Elemente verschiedene Eigenschaften wie Größe, Farbe oder Abstände nicht mehr nach
                belieben festlegen kann. <br />
                Natürlich sind all die Punkte nicht von der Hand zu weisen, doch letztlich überwiegen die Vorteile nicht
                nur, auch vermeintliche Nachteile entpuppen sich am Ende oft ebenfalls
                als Vorteil. Die Erstellung eines durchdachten Design Systems schafft oft die Basis für eine
                Nutzerfreundliche, wartbare und zukunftssichere Software.
            </p>
        </div>

        <div class="quote">
            „Die Kunst eines Design Systems liegt darin, die sensible Balance zwischen zu engem Regelkorsett und
            kreativem Freiraum zu halten.“
        </div>

        <div class="text">
            <h4>
                Vorteile für Designer &amp; Entwickler
            </h4>
            <p>Als Designer hat man zwar zunächst natürlich erstmal die Arbeit das Design System selbst zu erstellen,
                allerdings profitiert man in allen folgenden Schritten bereits selbst
                davon, denn wenn es um die Platzirung verschiedener Seitenelemente geht hilft es ungemein, wenn Abstände
                oder Größen bereits definiert sind. Man muss sich nicht mehr bei jedem
                neuen UI-Baustein die Frage stellen, wie und wo er im Gesamtbild der Seite stehen soll. Das schafft
                Konsistenz und Wiedererkennbarkeit, zudem hilft es dem Benutzer oder Kunden,
                sich zurecht zu finden, da wichtige Elemente an gewohnten Stellen zu finden sind. Als Entwickler
                profitiert man auf ganz ähnliche Art und Weise davon, denn aus den festgelegten
                Regelwerten lassen sich bereits erste CSS-Regelungen ableiten und festhalten. Diese
                Style-Klassifizierungen lassen sich dann ganz einfach überall im Projekt nutzen und sparen
                wertvolle Zeit.
            </p>
        </div>

        <div class="text">
            <h4>Benutzer sind lernwillige Gewohnheitstiere</h4>
            <p>
                Wenn man eine Tätigkeit so oft auf die immer gleiche Art ausgeführt hat, dass man sie ohne darüber
                nachzudenken ausführen kann, spricht man von „Muscle Memory“. In der Welt des
                Designs beschriebt dieser Begriff die Gewohnheit, UI-Elemente an bestimmten, vertrauten Stellen zu
                finden und dann damit zu interagieren. Vermutlich hat sich jeder schon einmal
                irgendwo „verklickt“, weil eine Schaltfläche plötzlich an einer anderen Stelle zu finden war, als die
                tausenden Male zuvor. Oder als analoges Beispiel: Der Einkauf im Supermarkt
                kann zur zeitlichen Herausforderung werden, wenn mal wieder die Regale neu eingeräumt oder sogar alles
                umgebaut wurde.
            </p>
            <p>
                Diese Gewohnheiten kann man sich zunutze machen, indem man Elemente dort platziert, wo sie von Benutzer
                erwartet werden, da er bereits bei anderen Seiten oder Anwendungen gelernt
                hat, wo bestimmte Elemente in der Regel zu finden sind. Aus diesem Grund haben Dialogfenster auf
                Webseiten oftmals oben links einen Schließen-Button mit einem „x“. Das kennt man
                so bereits von Windows oder auch MacOS (auch wenn da der Schließen Button etwas anders aussieht, ist er
                doch zumindest in einer oberen Ecke zu finden). Gleichzeitig kann es aber
                auch ungemein frustrierend sein, wenn gegen diese Gewohnheiten verstoßen wird. Wer mehr über
                Gewohnheiten erfahren möchte, wie man sie bewusst einsetzen und steuern kann, aber
                auch wie sie oftmals zur Manipulation genutzt werden, findet im Bereich <a
                    class="no-hover-effect text-link" href="/insights/uipsychology" title="Psychologie im UI Design"
                    alt="Link zum weiterführenden Artikel „Psychologie im UI Design“">„Psychologie im UI Design“</a>
                spannende Einblicke.
            </p>
            <p>
                Im Hinblick auf das Design System lässt sich dieses Wissen nutzen, um Gewohnheiten gewissermaßen zu
                trainieren. Hat man als Benutzer an einer Stelle eine Auswahl zwischen mehreren
                Optionen, kann es vorteilhaft sein die präferierte Wahl, oder die wahrscheinlichste gegenüber den
                anderen Optionen hervorzuheben, etwa indem man einen primären, einen sekundären
                und manchmal sogar einen tertiären Button anbietet. Das erleichtert die Auswahl, da man nicht erst
                visuell erfassen muss, welcher der Buttons beispielsweise ein gerade bearbeitetes
                Dokument speichert, und welches alle Änderungen wieder verwirft. Gewohnheiten zu kennen ist also enorm
                wichtig, und ein Design System kann helfen für solche Situationen die
                richtigen Werkzeuge bereitzustellen. Denn am Ende sind auch die Menschen, die an statt mit einem System
                arbeiten Gewohnheitstiere und freuen sich, wenn nicht jede Entscheidung
                aufs Neue sorgfältig überlegt sein muss.
            </p>
        </div>

        <InsightSnippet key="uipsychology" :insight="uipsychology" :hideImage="true" />

        <div class="text">
            <h3>Das ist drin - Design Systeme im Detail</h3>
            <p>
                Doch was steckt konkret drin in einem Design System? Da der Nutzen und die Vorteile klar geworden sind,
                lohnt es sich einen genaueren Blick unter die Haube zu wagen, und sich im
                Detail anzuschauen, wie ein Design System aufgebaut sein kann, welche Regelungen darin konkret zu finden
                sind, wie man sie strukturieren kann und vor allem, warum auch auf den
                ersten Blick vielleicht unwichtige Dinge, wie Abstände eine tragende Rolle spielen können.
            </p>
            <p>
                Es ist an dieser Stelle jedoch auch wichtig zu betonen, dass es
                nicht „den einen“ perfekten Guide zur Erstellung eines Design Systems gibt. Oftmals sind die Ansprüche
                daran ganz unterschiedlich:
            </p>
        </div>

        <div class="text">
            <p>
                Für kleinere Projekte reichen oft bereits
                einige grob ausgearbeitete Regeln, während bei größeren Vorhaben mit verschiedenen Beteiligten eine
                detailliertere Ausarbeitung durchaus sinnvoll sein kann. Auch soll hier
                kein Anspruch auf Vollständigkeit erhoben werden, denn wichtig ist am Ende, dass die Menschen, die mit
                einem Design System arbeiten sollen, so wenig offene Fragen wie
                möglich haben und sich darin zurechtfinden. Viel mehr zeige ich hier einen Ausschnitt dessen, wie ich in
                der Vergangenheit erfolgreich Design Systeme eingesetzt und entwickelt
                habe.
            </p>
        </div>

        <div class="text">
            <h4>Grundlagen und Konzepte</h4>
            <p>
                Noch bevor man in die Details ausarbeitet, ist es sinnvoll sich zunächst einen Überblick über das
                Projekt selbst zu verschaffen. Dazu zählt zunächst ersteinmal eher das Sammeln von
                Meta-Informationen:
            </p>
            <ul>
                <li>Welche Ziele sollen erreicht werden?</li>
                <li>Was ist die Markenausrichtung des Projektes?</li>
                <li>Welche Zielgruppe soll angesprochen werden?</li>
                <li>Für welche Plattformen oder Medien soll das Projekt angeboten werden?</li>
            </ul>
            <p>
                Kurzum: Zunächst muss klar sein, welche DNA ein Projekt mitbringt, um anschließend detaillierte und
                zugeschnittene Regeln definieren zu können. Hier kann es oft helfen, sich zunächst
                ein sogenanntes „Moodboard“ zusammenzustellen. Dabei handelt es sich um eine Sammlung verschiedener
                Medien, die zur Stimmung oder Markenidentität des Vorhabens passen. Von Screenshots
                ähnlicher Produkte, über Schriftarten oder auch Fotos ist hier grundsätzlich alles erlaubt. Ziel ist es,
                sich selbst einen Überblick darüber zu verschaffen, welche Idee das Projekt
                verfolgt, denn erst wenn diese klar ist, können alle Weiteren Entscheidungen wirklich sinnvoll getroffen
                werden.
            </p>
        </div>

        <div class="image">
            <img :src="'../images/insights/moodboard.webp'" alt="" />
            <span class="caption">Ein klassisches Moodboard mit Inspirationen und ersten Ideen</span>
        </div>

        <div class="text">
            <h4>Wireframes</h4>
            <p>
                Zur Erstellung von sogenannten „Wireframes“ ist es nicht zwingend notwendig, sich vorher ein Moodboard
                zu erstellen, es ist aber dennoch oftmals schon hilfreich. Beim wireframing
                kommen weder Farben noch konkrete Schriftarten zum Einsatz, theoretisch muss es nicht einmal digital
                erfolgen, es reicht bereits ein Stift und Papier (tatsächlich wird auch
                hin und wieder noch so gearbeitet). Vielmehr soll in diesem Schritt der grundlegende Aufbau und ein
                grobes Gerüst konzipiert werden, die dann im weiteren Verlauf des Entwicklungsprozeses
                detaillierter ausgearbeitet werden.
            </p>
        </div>

        <div class="image">
            <div class="flex gap-3">
                <div class="image img-rounded masonry">
                    <img :src="'../images/insights/wireframe_01.webp'" alt="" />
                    <img :src="'../images/insights/wireframe_02.webp'" alt="" />
                </div>
                <div class="image img-rounded masonry">
                    <img :src="'../images/insights/wireframe_04.webp'" alt="" />
                    <img :src="'../images/insights/wireframe_03.webp'" alt="" />
                </div>
            </div>
            <span class="caption">
                Erste Wireframes muten zunächst spartanisch an, reduzieren aber das Design
                auf das Wesentliche.
            </span>
        </div>

        <div class="text">
            <h4>Abstände &amp; Whitespace</h4>
            <p>
                Beim Thema Design denkt man oftmals zuerst an Farben, Bilder, Animationen, Videos und tolle Effekte.
                Alles davon kann auch dazu beitragen Bereiche und Elemente spannender zu gestalten,
                oder den Fokus des Benutzers auf bestimmte Bereiche zu lenken, doch oftmals unterschätzt man dabei ein
                UI-Element, was eigentlich streng genommen gar keines ist: Whitespace. Der leere
                Raum ist ein mächtiges Werkzeug, um unauffällig den Fokus zu lenken. Wenn es um ein Redesign geht, hat
                es oftmals den größten Effekt, wenn man einfach nur mehr Platz schafft und die
                einzelnen Bereiche oder Elemente mehr Platz zum atmen haben. Es wirkt zunächst nicht intuitiv, denn
                leerer Raum bietet keinen Inhalt oder enthält Informationen. Doch genau darin liegt
                auch seine Stärke, denn er lenkt die Aufmerksamkeit dorthin, wo der Inhalt zu finden ist. Fehlt der
                Freiaum, kämpfen zahlreiche Elemente um die Aufmerksamkeit des Nutzers, man weiß oft
                gar nicht, wo man zuerst hinschauen soll und verliert sich im Informationschaos. Die gezielte Suche nach
                Informationen wird zur Herausforderung.
            </p>
            <p>
                Whitespace ist in der Praxis nicht selten eine Stelle, bei der feste Regeln nur bedingt helfen. Geht es
                darum ein bestimmtes Element richtig in Szene zu setzen, braucht es oft individuelle
                Abstände, je nach Bedarf. Die goldene Regel hier ist: die richtige Menge Whitespace findet man, indem
                man den Abstand verringert, statt vergrößert. Das klingt erstmal, als würde es den
                kompletten vorherigen Abschnitt invalidieren, gemeint ist damit aber das Folgende: Beginnt man mit gar
                keinem Abstand und erhöht diesen Stück für Stück, hat man am Ende gerade so viel
                Leerraum, dass es gerade so nicht mehr schlecht aussieht. Normalerweise brauchen Elemente jedoch
                deutlich mehr Platz als man denkt, um wirklich hervorzustechen. Also dreht man den Spieß um
                und startet mit so absurd viel Leerraum, dass es eindeutig zu viel ist. Anschließend verringert man
                diesen bis zu dem Punkt, wo es besser aussieht. Probiert man diese Taktik aus wird man
                feststellen, dass bei der zweiten Variante deutlich mehr Whitespace übrig bleibt, als bei der ersten
                Herangehensweise.
            </p>
        </div>

        <div class="quote">
            „Normalerweise brauchen Elemente deutlich mehr Raum als man denkt.“
        </div>

        <div class="text">
            <p>
                Sind fixe Regelungen für Abstände also gar nicht sinnvoll? Doch, in gewisser Weise schon, allerdings
                sind die Anwendungszwecke hier enger abgesteckt und bei Bedarf ist ein Abweichen von den
                Regeln nicht nur erlaubt, sondern oft sogar notwendig. Bei Abständen zwischen wiederkehrenden UI
                Elementen, wie Paragraphen längerer Texte, Abstände von Überschriften, oder dem Freiraum
                zwischen Navigationselementen ist es aber sinnvoll einige Vorgaben bereitzustellen. Wichtig ist dabei,
                dass die Abstände nicht linear vergrößert werden sollten, sondern eher einer
                logarithmischen Kurve folgen sollten,
            </p>
        </div>

        <div class="text">
            <h4>Farbkonzeption</h4>
            <p>
                Wenn eine grundlegende Idee und ein struktureller Aufbau erarbeitet wurde, kann man sich nun auch der
                Farbgestaltung widmen. Oft gehören Farben den ersten Assoziationen, wenn
                es um UI-Design geht, tatsächlich kommen die bunten Pixel aber erst recht spät im Prozess wirklich zum
                tragen. Auch hier gilt es einige grundlegenden Dinge zu beachten, die
                letztlich den Unterschied zwischen einem durchdachten und logischen Interface, und einem das aussieht,
                als wäre man in die Villa kunterbunt gestolpert machen können.
            </p>
            <p>
                Im Internet findet man auf der Suche nach Farben schnell so genannte „Farbpaletten“ mit drei oder sogar
                mehr Farben, die zwar gut und nach bestimmten Regeln aufeinander
                abgestimmt sind, jedoch ist das Ziel nicht das nächste Wandgemälde im Michelangelo Stil zu erschaffen,
                sondern ein nutzbares und klares User Interface. Daher reicht es meist
                bereits aus, nur eine einzige Farbe auszuwählen, diese aber in mehreren Abstufungen von hell zu dunkel
                auszudefinieren. Gegebenenfalls können auch zwei Farben gut miteinander
                harmonieren, nötig ist das allerdings nicht.
            </p>
            <p>
                Ist die Entscheidung für eine Farbe gefallen, kann es durchaus herausfordernd sein, die
                Helligkeitsabstufungen richtig anzupassen. Wie viele Abstufungen benötigt werden,
                hängt natürlich immer vom Einsatzzweck ab, allerdings sind 3 das absolute Minimum (Primär, helle
                Variante, dunkle Variante). Besser sind 5 Abstufungen, bei komplexen
                Benutzerobferflächen können es aber gut und gern auch mal 7 oder mehr werden. Die Zahl ist dabei
                normalerweise ungerade, da es in der Mitte der Farbpalette eine Primärfarbe
                gibt, und jeweils links und rechts davon die gleiche Anzahl an hellen und dunklen Abstufungen.
            </p>
        </div>

        <div class="image">
            <img :src="'../images/insights/colors.webp'" alt="" />
            <span class="caption">Konzeption der Farbpalette dieser Seite mit Primär- und Sekundärfarbe, sowie
                Verläufen</span>
        </div>

        <div class="text">
            <p>
                Als kleine Faustregel für die Helligkeitsabstufungen gilt: Je heller, desto niedriger sollte der
                Sättigungswert eingestellt werden (Zur Farbabstimmung ist immer der HSL
                Farbraum, statt beispielsweise RGB oder CMYK empfehlenswert) und je dunkler, desto mehr Sättigung wird
                auch benötigt, damit die Farbe noch leicht durchscheint und man nicht
            <div class="image floating-image floating-left">
                <img :src="'../images/insights/color_saturation.webp'" alt="" />
                <span class="caption">Wenig Sättigung bei helleren Farben - viel Sättigung bei dunklen Farben</span>
            </div>
            bei mehreren Grautönen landet. Ganz pragmatisch lässt sich das auch mit echten Farben veranschaulichen:
            Bei weiß reicht bereits ein kleiner Klecks von beispielsweise rot, um
            ein sanftes Rosa zu erhalten. Startet man jedoch mit schwarz, muss reichlich rot dazugegeben werden,
            damit der eigentliche Farbton tatsächlich durchschimmert. Oder aus der
            anderen Richtung: Fügt man dem Rot schwarz hinzu, reicht schon eine kleine Menge und es wird signifikant
            dunkler.
            </p>
            <p>
                Das Thema Farben, wie sie wirken, welche Primärfarbe möglicherweise am besten zu wem passt und was es
                alles zu beachten gibt ist jedoch so komplex, dass es hier nur angerissen
                werden kann. Wer mehr darüber erfahren möchte, findet im Bereich <a class="no-hover-effect text-link"
                    href="/insights/color-theory" title="Pixel & Pigmente: Der UI-Farbguide"
                    alt="Link zum weiterführenden Artikel „Pixel & Pigmente: Der UI-Farbguide“">„Pixel & Pigmente: Der
                    UI-Farbguide“</a> noch viel mehr Tipps und Tricks, sowie Erklärungen und
                Hilfestellungen.
            </p>
        </div>

        <div class="text">
            <h4>Typographie</h4>
            <p>
                Die richtige Wahl der Schriftart gehört zu den am meisten unterschätzten Themen im Bezug auf
                ansprechendes Design. In gewisser Weise ist das auch nachvollziehbar, immerhin
                sehen sich viele Schriftarten sehr ähnlich, im Falle von Arial oder Helvetica muss man die Unterschiede
                teils wirklich mit der Lupe suchen. Und doch ist es kein Zufall, dass
                große Unternhemen sich oft sogar eigene Fonts gestalten lassen, um die Individualität des eigenen
                Brandings zu steigern.
            </p>
            <p>
                Nun ist es natürlich eher selten notwendig, sich eine komplett eigene Schriftart gestalten zu lassen
                (und sicher auch nicht sonderlich günstig), allerdings kann man auch mit
                freien Fonts bereits einen großen Effekt erzielen, wenn man sich darüber Gedanken macht, welche Stimmung
                vermittelt werden soll. Buchstaben mit Serifen vermitteln einen eher
                professionellen und wertigeren Eindruck, als solche ohne. Soll es etwas freundlicher wirken, können
                abgerundete Ecken an den Lettern dazu beitragen. Viele weitere Eigenschaften
                vermitteln ganz bestimmte Emotionen und Stimmungsbilder und zu erkennen, welches am besten zum eigenen
                Projekt passt, ist ein wichtiger Schritt in Richtung eines ansprechenden
                UI. Wer hier bereits beim Wort „Serifen“ ausgestiegen ist: Kein Problem, auch das Feld der Schriftarten
                ist unheimlich breit gefächert und wie man die korrekte Wahl trifft,
                was es mit all den Buzzwords auf sich hat und wie man die feinen Unterschiede erkennt gibt es im Bereich
                <a class="no-hover-effect text-link" href="/insights/typography"
                    title="Pixel & Pigmente: Der UI-Farbguide"
                    alt="Link zum weiterführenden Artikel „Typografie auf den Punkt“">„Typografie auf den Punkt“</a> zu
                entdecken. <br />
                In diesem Thema soll es jedoch weniger um die eigentliche Auswahl und Wirkung verschiedener Schriftarten
                gehen, sondern vielmehr darum wie sie im Design System verwendet
                werden kann, worauf bei der Verwendung zu achten ist und - natürlich - welche Ausnahmen es von den
                Regeln gibt.
            </p>
        </div>
        <div class="image">
            <img :src="'../images/insights/typography-example.webp'" alt="" />
            <span class="caption">Schriftarten sind ein mächtiges Kommunikations-Werkzeug</span>
        </div>

        <div class="text">
            <h5>Schrifthierarchie festlegen</h5>
            <p>
                Die Wahl wurde nach reiflicher Überlegung also getroffen, weswegen im nächsten Schritt Regeln für die
                Verwendung von Text und Schrift erstellt werden müssen. Die Basis für
                diese Regeln ist die Größe und der Stil von Fließtexten. Diese werden in jedem Bereich den größten Teil
                der Worte ausmachen und sind gleichzeitig der Ankerpunkt für alle
                anderen Schriftregeln, welche immer um einen Faktor x größer und seltener auch kleiner sind. Diesen
                Faktor kann man später im Code verwenden, denn besonders im Web-Bereich
                sollten em oder rem die Einheiten der Wahl für Schriftgrößen sein. Beide definieren die Größe relativ zu
                einem bestimmten Ankerpunkt, lediglich dieser unterscheidet sich
                bei beiden. Während bei em die Größe des Elterncontainers ausschalggebend ist, bezieht sich rem immer
                auf einen globalen Ankerpunkt.
            </p>
            <p>
                Die Basis dafür, also die Größe des regulären Fließtextes sollte also nicht zu groß und nicht zu klein
                sein, den einerseits skalieren die Überschriften zu weit, wenn der
                Ankerpunkt bereits sehr groß gewählt wurde, andererseits sind größere Fonts generell besser lesbar,
                besonders auf kleineren Geräten wie Smartphones oder für Menschen mit
                visuellen Handicaps. Etwa 20 px (das unterscheidet sich je nach Schriftart ein wenig) bei einem
                regulären Monitor mit 100% DPI Skalierung eigenen sich als Basisschriftgröße
                erfahrungsgemäß am besten, allerdings darf hier durchaus um ein paar wenige Größenordnungen nach oben
                oder unten experimentiert werden.
            </p>
            <p>
                Ausgehend hiervon kann sich nun die verschiedenen Hierarchie-Ebenen nach oben gearbeitet weden. Wie
                viele davon relevant sind ist natürlich ganz vom Einsatzzweck abhängig,
                mancher kommt mit zwei Überschriften klar, textlastige Projekte benötigen aber gern mehrere
                Hierarchiestufen. Wichtig ist, dass diese sich klar voneinander abgrenzen, um
                zu gewährleisten, dass die unterschiedlichen Ebenen auf einen Blick erkennbar sind. Anders gesagt: Eine
                Überschrift sollte immer als solche aussehen, nicht wie Text, und
                verschiedene Überschriften sollten ihrer Stufe entsprechend unterschiedlich viel Gewicht mitbringen.
                Dieses Gewicht lässt sich über Faktoren wie die Schriftrgröße, aber
                auch über Eigenschaften wie Gewichtung und Farbe steuern. Hier findet sich auch eine hervorragende
                Faustregel für gute (Fließtext)-Schriftarten: Je mehr Stile sie von sich
                aus mitbringt, desto besser. Viele Schriftarten bieten nicht nur die reguläre Font-Weight an, sondern
                auch fett (bold) oder sogar Zwischenstufen (medium, semi-bold, extra-bold,
                black, ...), sowie kursiv in all den eben genannten Ausführugnen. Es müssen natürlich nicht immer 8
                verschiedene Gewichtungen vorhanden sein, aber wenn es neben der normalen
                Schriftart lediglich eine bold und italic Variante (oder sogar gar keine Variante) gibt, ist Vorsicht
                geboten. Möglicherweise eignet sich eine solche Schriftart dann eher
                für Akzente wie Überschriften und Titel.
            </p>
        </div>

        <div class="image img-rounded">
            <img :src="'../images/insights/typography_hero-example.webp'" alt="" />
            <span class="caption">Für spezifische Szenarien, wie Hero-Captions ist auch besonders große Schrift
                unproblematisch</span>
        </div>

        <div class="text">
            <h5>Weniger ist mehr</h5>
            <p>
                Allgemein gilt bei Schriftarten das gleiche Sparsamkeitsprinzip wie bei Farben: Weniger ist meist mehr
                und nicht selten reicht es aus eine einzige passende Schriftart zu
                finden. Soll noch eine zweite dazu kommen, ist es sinnvoll diese maximal für bestimmte Akzente zu
                nutzen, die allerdings gut begründete Ausnahmen sein sollten. Je mehr
                Fonts verwendet werden, desto schwieriger wird es die Hierarchie zu unterscheiden und zu erkennen, um
                was für eine Art Text es sich eigentlich gerade handelt. Sparsamkeit
                ist zudem auch ein wunderbares Stichwort beim Thema Textfarbe, denn auch hier ist weniger mehr. Während
                es kein Problem ist Texte in unterschiedlichen Graustufen (unter
                Wahrung der Accessibility-Guidelines) zu trennen, sollte farblich hervorgehobener Text ausschließlich
                für Links verwendet werden. Hier scheitert der kreative Freiraum
                einfach an der Gewohnheit der Nutzer, die von Anbeginn des Internets darauf trainiert wurden, auf
                farblich hervorgehobene Textabschnitte klicken zu können. Ausnahmen bilden
                hier lediglich einige Überschriften, doch auch hier sollte mit Bedacht vorgegangen werden.
            </p>
        </div>

        <div class="quote">
            „Farbiger Text sollte nur für <span class="troll" title="erwischt!">Links</span> verwendet werden.“
        </div>

        <div class="text">
            <h5>Visuelles Gewicht verstehen und nutzen</h5>
            <p>
                Die Festlegung der Texthierarchie kann, besonders wenn es mehrere Ebenen gibt, durchaus herausfordernd
                sein. Texte sollten, auch wenn es sich um Überschriften handelt, nicht
                allzu groß werden und schon gar nicht zu klein. Hier kommt etwas zum tragen, was ich gern visuelles
                Gewicht nenne. Damit ist gemeint, wie ein Buchstabe optisch wirkt, unabhängig
                davon, welche Eigenschaften für ihn definiert sind. Beispielsweise bringt hier der linke Text deutlich
                weniger Gewicht auf die Waage, obwohl er genauso groß wie der rechte
                Text ist.
            </p>
            <div class="flex gap-3">
                <div class="width-1 downpop">Dieser Text hat eine Größe von 1em, jedoch eine font-weight von
                    lediglich 200 und eine opacity (Transparenz) von 0.85</div>
                <div class="width-1 uppop">Dieser Text ist ebenfalls 1em groß, aber in Großbuchstaben mit font-weight
                    800 und ohne Transparenz</div>
            </div>
            <p>
                Diese Beispiel verdeutlicht, dass es neben der reinen Schriftgröße noch andere, ebenfalls sehr effektive
                Methoden gibt, das visuelle Gewicht zu beeinflussen. Liegen also zwei
                definierte Textebenen optisch zu nah beeinander, lassen sich Eigenschaften wie die font-weight, oder die
                Textfarbe (bzw. die Transparenz) nach unten oder oben korrigieren.
                Dadurch lässt sich eine deutlichere Abgrenzung erreichen, ohne dass der Text zu groß oder klein wird.
                Mit Stilmitteln wie nur Großbuchstaben sollte allerdings ebenfalls eher
                sparsam umgegangen werden, da dies die Lesbarkeit oft negativ beeinflusst. Er sollte daher nur für kurze
                Titel oder seltener vorkommende Überschriften verwendet werden,
                keinesfalls aber für Fließtexte. Gleiches gilt für Transparenzeffekt oder genrell dem Abstufen in
                Grautöne, auch hier ist es immer wichtig darauf zu achten, dass noch genügend
                Kontrast zum Hintergrund bestehen bleibt, damit der Text auch für Menschen lesbar ist, deren Sicht
                möglicherweise eingeschränkt ist.
            </p>
        </div>

        <div class="text">
            <h4>Komponenten</h4>
            <p>
                Abschließend ist es nun durchaus möglich basierend auf den bislang getroffenen Regeln eigene kleinere
                Komponenten abzuleiten und zu definieren. Hierzu gehören etwa Buttons,
                Textfelder, Badges oder auch Schlagschatten. Hier profitieren erneut Designer und Entwickler von der
                Möglichkeit, diese Elemente in Form von wiederverwendbaren Komponenten
                immer wieder zu nutzen, ohne jedes Mal aufs Neue Aufwand in die Definition stecken zu müssen. Oftmals
                verschwimmen hierbei die Grenzen zwischen einzelnen Elementen und
                ganzen Screendesigns bereits. Daher ist es wichtig darauf zu achten die Umgebung in die das Element
                eingebettet werden soll nicht zu detailliert zu beschreiben, sondern
                wirklich beim Kern der Sache zu bleiben.
            </p>
            <p>
                Besonders Formularfelder, sprich Buttons, Textfelder, Checkboxen, Radiobuttons, etc. sind wichtige
                Elemente, die in fast allen Bereichen auf die Ein oder Andere Art eine
                Rolle spielen und bei denen bei der Gestaltung besonders auch im Hinblick auf Accessibility auf einige
                wichtige Dinge geachtet werden sollte.
            </p>

            <h5>Buttons</h5>
            <p>
            <div class="image floating-image floating-right">
                <img :src="'../images/insights/button-design.webp'" alt="" />
                <span class="caption">Eine detailliert ausgearbeitete Definition - ideal zur Erstellung
                    wiederverwendbarer
                    Komponenten</span>
            </div>

            Bei Buttons verhält es sich ähnlich wie bei Text: Es gibt oftmals mehrere Hierarchie-Ebenen und
            natürlich auch den Ein oder Anderen Spezielfall, der gegebenenfalls mit
            bedacht werden sollte. Jedoch gibt es im Gegensatz zur Typologie deutlich weniger Abstufungen, in der
            Regel reicht es aus einen Primär- und einen Sekundärbutton zu definieren.
            Selten kann auch ein Tertiärbutton relevant sein, in vielen Fällen reichen aber zwei Versionen aus. Der
            Gedanke dahinter ist, dass es in den allermeisten Fällen Aktionen gibt,
            die der Benutzer bevorzug auswählt, bzw. auswählen soll. Editiert man beispielsweise Daten in einem
            Formular ist es am wahrscheinlichsten, dass man danach auf speichern klicken
            möchte, damit die Änderungen nicht verloren gehen und nicht etwa auf Abbrechen. Hier kann man dem User
            einiges an kognitiver Arbeit ersparen, wenn man ihn nicht erst nach dem
            entsprechenden Button suchen lässt, weil er optisch unter anderen Elementen untergeht. Oder noch
            schlimmer: Es kommt zu Fehlklicks und statt zu speichern wird die ganze Arbeit
            verworfen. Es sollte also jederzeit so einfach wie möglich sein zu erkennen, welcher Button in einer
            Situation der präferierte ist, sei es der Speichern Button, oder auch ein
            call-to-action Button, etwa um Kontakt aufzunehmen oder ein Produkt in den Warenkorb zu legen.
            </p>
            <p>
                Ein besonders hervorgehobener Button ist auch dann sinnvoll, wenn ein Klick darauf eine destruktive
                Aktion auslöst, meist das Löschen von nicht wiederherstellbaren Daten. Ein
                rot gekennzeichneter Button (gesetzt den Fall die primäre Design-Farbe ist nicht rot) sticht hier
                besonders hervor und vermittelt ein Gefühl von Gefahr. Doch auch hier wartet
                eine Falle, denn dadurch erreichen wir auch genau das, was eigentlich der Primärbutton erreichen soll:
                Aufmerksamkeit. Und die möchten wir in dem Fall eventuell (noch) gar
                nicht haben, denn die Versuchung ist hier groß ebenfalls einfach auf den erstbesten hervorstehenden
                Button zu klicken. In solchen Momenten ist es durchaus erlaubt, dem
                Benutzer etwas mehr Arbeit zuzugestehen, besonders wenn die Daten, die gelöscht werden sollen sensibel
                und anschließend unwiederbringlich verloren sind. Sinnvoll ist es daher,
                hier noch einen Dialog vorzuschalten, der eine warnende Nachricht, ebenfalls in Signalfarbe, anzeigt.
                Diese sollte nicht zu lang sein, denn sonst wird sie ebenfalls nicht
                richtig gelesen, aber vermitteln, dass man sich nun in eine Gefahrenzone begibt. Diesen Dialog kann man
                zunächst mit einem Standard Primärbutton bestätigen, wodurch dem User
                klar wird, dass der nächste Schritt unwiderrufliche Konseqzenen hat. Nun ergibt der effekthascherische
                Button in Signalfarbe, der die Aktion letztendlich auslöst, auch wieder
                mehr Sinn, denn der Gesamtkontext und das Gefahrenbewusstsein sind nun deutlicher.
            </p>
        </div>

        <div class="quote">
            „Sinnvoll definierte UI Elemente können dem User einiges an kognitiver Arbeit ersparen.“
        </div>

        <div class="text">
            <h5>Textfelder &amp; weitere Formular-Elemente</h5>
            <p>
                Gibt es Bereiche, in denen Informationen eingegeben werden können, sind Textfelder und andere
                Formularelemente wie Checkboxen nicht zu umgehen. Das kann der Fall sein, wenn man
                ein Kontaktformular anbietet, oder aber wenn es einen Login-Prozess mit Benutzerprofil gibt. Auch hier
                sollen die Komponenten natürlich so aussehen, dass sie zum erarbeiteten
                Design passen. Allerdings gibt es hier einige Fallstricke, die es zu beachten gilt, weshalb diese drei
                Grundregeln für Input Felder beachtet werden sollten.
            </p>
            <p>
                <strong>1. Labels müssen immer sichtbar sein</strong> <br />
                Ein aufgeräumtes und klares User Interface ist wichtig und wertvoll, allerdings darf man hier nicht über
                das Ziel hinaus schießen und Informationen verstecken, die für den Benutzer wichtig sind. So kann die
                Versuchung
                groß sein, die üblichen Feldlabels durch den Placeholder Text zu ersetzen. Das spart einerseits Platz,
                sorgt
                für eine weniger zerstreute Gesamtoptik.

            <div class="flex gap-3 center-h gap-bottom-m">
                <div class="width-1 flex flex-col">
                    <label for="firstName">Vorname</label>
                    <input type="text" name="firstName" />
                    <label for="name">Nachname</label>
                    <input type="text" name="lastName" />
                    <label for="email">E-Mail Adresse</label>
                    <input type="text" name="email" />
                    <label for="password">Passwort</label>
                    <input type="password" name="password" />
                </div>
                <div class="width-1 flex flex-col gap-2">
                    <input type="text" name="firstName" placeholder="Vorname" />
                    <input type="text" name="lastName" placeholder="Nachname" />
                    <input type="text" name="email" placeholder="E-Mail Adresse" />
                    <input type="password" name="password" placeholder="Passwort" />
                </div>
            </div>

            Der höhere Platzbedarf wird direkt ersichtlich und auch die Anzeige der Labels oberhalb der Felder wirkt
            zunächst möglicherweise, als würde man wertvollen Raum vergeuden. Problematisch wird es jedoch, wenn man
            beginnt das Formular auszufüllen, da hierbei der Inhalt den Platzhaltertext überschreibt. Eine nachträgliche
            Prüfung, ob alles korrekt ausgefüllt wurde, wird so schwierig bis unmöglich. Noch deutlicher wird diese
            Problematik,
            wenn das Auto-Fill Feature des Browsers aktiviert und genutzt wurde. Wenn alle Felder automatisch befüllt
            wurden
            muss man entweder darauf vertrauen, dass alles korrekt ausgewiesen und befüllt wurde, oder aber man löscht
            den
            Inhalt, um einen Blick auf den Platzhalter zu erhaschen. Das nachfolgende Beispiel zeigt, wie das Formular
            oben
            an seine Grenzen stößt, wenn es ausgefüllt wurde.

            <div class="flex gap-3 center-h gap-bottom-m">
                <div class="width-1 flex flex-col">
                    <label for="firstName">Vorname</label>
                    <input type="text" name="firstName" value="Kurt" />
                    <label for="name">Nachname</label>
                    <input type="text" name="lastName" value="Paul" />
                    <label for="email">E-Mail Adresse</label>
                    <input type="text" name="email" value="paul.kurz@matze.dev" />
                    <label for="password">Passwort</label>
                    <input type="password" name="password" value="plzdonthackme" />
                </div>
                <div class="width-1 flex flex-col gap-2">
                    <input type="text" name="firstName" placeholder="Vorname" value="Kurt" />
                    <input type="text" name="lastName" placeholder="Nachname" value="Paul" />
                    <input type="text" name="email" placeholder="E-Mail Adresse" value="paul.kurt@matze.dev" />
                    <input type="password" name="password" placeholder="Passwort" value="plzdonthackme" />
                </div>
            </div>

            Wurde Kurt Pauls Name in die korrekten Felder eingetragen? Links ist das problemlos ersichtlich, rechts
            könnte
            das Feld für Vor- und Nachname aber auch vertauscht sein. Hybridlösungen, wie es beispielsweise bei Googles
            Material Design vorkommt, wo das Label per Animation nach oben rutscht, aber sichtbar bleibt, funktionieren
            natürlich auch und können ein eleganter Kompromiss sein. Das Feldlabel sollte jedoch niemals komplett
            ausgeblendet werden.
            </p>
            <p>
                <strong>2. Das Design der Felder folgt dem Inhalt</strong> <br />
                Bei Formularen gilt der gleiche Grundsatz wie überall im UI/UX Design: Der Benutzer sollte möglichst
                intuitiv
                durch die Oberfläche navigieren können, ohne sich zu viele Gedanken machen zu müssen. Aus kognitiver
                Sicht ist
                es dementsprechend hilfreich, wenn bereits mit einem flüchtigen Blick erfasst werden kann, welche
                Inhalte in
                welche Felder eingetragen werden sollen. Folgendes Beispiel könnte eine beliebige (vereinfachte)
                Checkout Seite
                eines Online-Shops bei einer Bestellung sein:

            <div class="flex flex-col gap-bottom-m">
                <label for="firstName">Vorname</label>
                <input type="text" name="firstName" />
                <label for="name">Nachname</label>
                <input type="text" name="lastName" />
                <label for="email">E-Mail Adresse</label>
                <input type="text" name="email" />
                <label for="password">Passwort (optional)</label>
                <input type="password" name="password" />
                <label for="street">Straße</label>
                <input type="text" name="street" />
                <label for="number">Hausnummer</label>
                <input type="number" name="number" />
                <label for="zip">PLZ</label>
                <input type="text" name="zip" />
                <label for="city">Stadt</label>
                <input type="text" name="city" />
                <label for="country">Land</label>
                <input type="text" name="country" />
                <label for="phone">Telefon</label>
                <input type="text" name="phone" />
                <label for="cardnumber">Kartennummer</label>
                <input type="text" name="cardnumber" />
                <label for="validity">Gültig bis</label>
                <input type="text" name="validity" />
                <label for="csv">CSV</label>
                <input type="text" name="csv" />
                <label for="cardowner">Karteninhaber</label>
                <input type="text" name="cardowner" />
            </div>

            Bei einem Bestellvorgang kommen schnell einige Felder zusammen, schließlich müssen auch zahlreiche
            Informationen
            erfasst werden, damit die Bestellung bezahlt wird und letztlich auch verschickt werden kann. Um die Eingabe
            der Daten
            so komfortabel wie möglich zu machen gibt es einige Kniffe, wie das gesamte Formular ordentlich aufgebessert
            werden
            kann. </p>
            <p>
                Zunächst sind aktuell alle Felder gleich breit, obwohl etwa eine Hausnummer oder die Postleitzahl sehr
                wahrscheinlich
                eher kurze Texte beinhalten dürften. Wird die Breite dem Inhalt angepasst, lassen sich so auch
                zusammengehörige Felder
                nebeneinander anzeigen, was zudem einiges an Platz spart. Ein Feld, oder Feldpaar muss dabei nicht
                zwingend
                immer
                die komplette verfügbare Breite einnehmen, es gilt: Der Inhalt diktiert die Breite.
            </p>
            <p>
                Der Inhalt spielt auch eine Rolle bei unterstützenden Elementen einiger Felder, wie Placeholder Texte
                oder
                Icons. Diese
                sind mit einer gewissen Vorsicht einzusetzen, können aber an geeigneten Stellen einen großen Mehrwert
                bieten. Platzhalter
                sind bei Eingabefeldern, deren Inhalt klar ist, wie der Name oder die E-Mail Adresse eher überflüssig
                und
                sorgen für
                visuelles Rauschen (Visual Noise). Die Gültigkeit eine Kreditkarte jedoch besteht immer aus zwei Ziffern
                für
                den
                Monat und das Jahr, hier kann ein Platzhalter also mehr Struktur bringen. </p>
            <p>
                Auch Icons können bei der Eingebe helfen, etwa wenn anhand der ersten 4 Ziffern der Kreditkartennummern
                klar
                ist,
                um was für eine Karte es sich handelt (VISA, MasterCard, usw.). Zudem können sie hilfreich sein, wenn
                das
                Feld eine
                zusätzliche Aktion bietet, wie etwa ein Kalender bei der Auswahl eines Datumsfeldes, oder das klassische
                Auge bei
                Passwortfeldern zur Anzeige im Klartext. Als Faustregel gilt hier: Icons links vom Text haben
                unterstützenden
                Charakter, während Icons rechts am Feldrand für Interaktivität stehen. Dort sollte dann auch eine
                entsprechende
                onClick Action ausgelöst werden.
            </p>
        </div>

        <div class="quote">
            „Bei Eingabefeldern diktiert der Inhalt Funktionalität und Aussehen.“
        </div>

        <div class="text">
            <p>
                Zuletzt sollten die Felder nicht nur was ihre Breite angeht an den Inhalt angepasst werden, sondern auch
                ihrem Datentyp
                entsprechen. Das Passwortfeld sollte also als solches markiert sein, auch das E-Mail Feld sollte
                gebrauch vom
                entsprechenden Datentyp machen. Das hat einerseits den Vorteil, dass bereits eine soft-validation vom
                Browser
                vorgenommen wird, da z.B. in Zahlenfeldern kein Text zugelassen wird, andererseits bieten gerade
                Smartphones die
                Möglichkeit, das Tastaturlayout entsprechend des Feldtyps anzupassen. So wird bei einem E-Mail Feld
                beispielsweise das
                @ Symbol direkt als Taste angezeigt, oder bei Zahlenfeldern erscheint direkt ein Ziffernblock. Doch
                Vorsicht mit
                Zahlenfeldern: Nicht immer wo sie auf den ersten Blick sinnvoll erscheinen, sollten sie eingesetzt
                werden. Eine
                Hausnummer kann beispielsweise auch einen Adresszusatz wie 12a enthalten, Postleitzahlen beginnen
                manchmal mit einer 0,
                die vom Feld dann entfernt wird und Telefonnummern können mit einer Ländervorwahl angegeben werden, zum
                Beispiel +49.
                Der Feldtyp sollte also den Einsatzzweck unterstützen, nicht behindern.
            </p>
            <p>
                Mit all diesen kleinen und großen Änderungen wird aus dem trostlosten und raumgreifenden Formular eine
                gut nutzbare
                und übersichtliche Eingabemaske, die man ggf. sogar noch mit kleinen Überschriften gruppieren kann.

            <div class="flex flex-col gap-bottom-m">
                <h6>Benutzerkonto</h6>
                <div class="flex gap-2">
                    <div class="flex flex-col width-1">
                        <label for="firstName">Vorname</label>
                        <input type="text" name="firstName" />
                    </div>
                    <div class="flex flex-col width-1">
                        <label for="name">Nachname</label>
                        <input type="text" name="lastName" />
                    </div>
                </div>
                <div class="flex gap-2">
                    <div class="flex flex-col width-1">
                        <label for="email">E-Mail Adresse</label>
                        <input type="email" name="email" />
                    </div>
                    <div class="flex flex-col width-1">
                        <label for="password">Passwort (optional)</label>
                        <input type="password" name="password" />
                    </div>
                </div>
                <h6>Adresse</h6>
                <div class="flex gap-2">
                    <div class="flex flex-col width-3">
                        <label for="street">Straße</label>
                        <input type="text" name="street" />
                    </div>
                    <div class="flex flex-col width-1">
                        <label for="number">Nummer</label>
                        <input type="text" name="number" />
                    </div>
                </div>
                <div class="flex gap-2">
                    <div class="flex flex-col width-1">
                        <label for="zip">PLZ</label>
                        <input type="text" name="zip" />
                    </div>
                    <div class="flex flex-col width-3">
                        <label for="city">Stadt</label>
                        <input type="text" name="city" />
                    </div>
                </div>
                <div class="flex gap-2">
                    <div class="flex flex-col width-1">
                        <label for="country">Land</label>
                        <input type="text" name="country" />
                    </div>
                    <div class="flex flex-col width-1">
                        <label for="phone">Telefon</label>
                        <input type="tel" name="phone" />
                    </div>
                </div>

                <h6>Zahlungsinformationen</h6>
                <div class="flex gap-2">
                    <div class="flex flex-col width-4">
                        <label for="cardnumber">Kartennummer</label>
                        <input type="text" name="cardnumber" />
                    </div>
                    <div class="flex flex-col width-2">
                        <label for="validity">Gültig bis</label>
                        <input type="text" name="validity" placeholder="MM / YY" />
                    </div>
                    <div class="flex flex-col width-1" style="max-width: 7em">
                        <label for="csv">CSV <a class="no-hover-effect text-link" href="#">Was ist das?</a></label>
                        <input type="text" name="csv" />
                    </div>
                </div>

                <div class="flex flex-col w50p">
                    <label for="cardowner">Karteninhaber (voller Name)</label>
                    <input type="text" name="cardowner" />
                </div>
            </div>
            </p>
            <p>
                <strong>3. Individualisierung darf nicht auf Kosten der Accessibility gehen</strong> <br />
                Bis auf einige Ausnahmen wie Textbasierte Felder sind die meisten Formular-Elemente eigentlich
                Hoheitsgebiet
                des eingesetzten Browsers. So ist es nicht mit CSS allein möglich Checkboxen, Radiobuttons oder
                Dropdown-Menüs
                zu individualisieren. Das ist zunächst ärgerlich, schließlich wirken diese dann oft deplatziert und
                bieten
                teilweise sogar weniger Funktionalität. Ein Standard-Dropdown unterstützt beispielsweise kein type-ahead
                um
                Optionen zu filtern. Natürlich gibt es dennoch einige Tricks um diese Formularelemente optisch nahtlos
                in
                ihr Umfeld einzufügen, allerdings darf dies niemals auf Kosten der Zugänglichkeit passieren. <br />
                Checkboxen lassen sich unter anderem ausblenden und mit CSS-Pseudoelementen individualisieren, oftmals
                wird dabei jedoch vergessen, dass einige Nutzer bevorzugt mit der Tastatur und Tabulator Taste durch das
                Formular gehen. Hierbei wird oft vergessen den Focus State zu gestalten, bzw. die Checkbox überhaupt für
                eine Tastatur-Navigation ansprechbar zu machen. Noch problematischer wird es, wenn blinde Menschen einen
                Screenreader verwenden und die eigentliche Checkbox, oder auch ein Radio-Button nicht mehr sichtbar
                sind.
                Für sie wird das Ausfüllen so zum absoluten Hindernis. Übrigens: Auch die bereits angesprochenen
                Feld-Labels
                sind für Screenreader ein wichtiges Werkzeug.
            </p>
            <p>
                Dropdown-Menüs sind fast schon eine Wissenschaft für sich, denn die heutigen Implementierungen gehen weit über
                eine simple Auswahlliste an Optionen hinaus. Sie bieten unter anderem Icons, gruppierbare Einträge, Mehrfachauswahlen,
                oder das schon angedeutete type-ahead um eine große Auswahl an Möglichkeiten einzugrenzen, indem man die ersten 
                Buchstaben in das Feld tippt. Hier gibt es im Grunde für jedes größere UI-Framework vorhandene Lösungen, die in
                den meisten Fällen auch Accessibility-konform sind, weswegen hier durchaus auf bestehendes zurückgegriffen werden
                darf, sofern man sich eine individualisierbare Lösung wünscht. Mehr zum Thema Accessibility, worauf es zu achten gilt und
                welche gesetzlichen Regelungen es gibt, kann im Bereich <a class="no-hover-effect text-link"
                    href="/insights/accessibility" title="Accessibility: Teilhabe ist nicht optional"
                    alt="Link zum weiterführenden Artikel „Accessibility: Teilhabe ist nicht optional“">„Accessibility: Teilhabe ist nicht optional“</a>
                    nachgelesen werden.
            </p>
        </div>

        <div class="text gap-top-l">
            <p>
                Wie bereits erwähnt ist das natürlich kein Handbuch für die eine richtige und einzig wahre Vorgehensweise, aber
                es fasst einige grundlegende Handlungsempfehlungen zusammen, die sich im Bereich UI/UX als Best Practice erwiesen
                haben, oder einfach als Hilfestellung dienen, worauf bei der Erstellung geachtet werden sollte. Ein aus diesen
                Bausteinen erarbeitetes und gut strukturiertes Design System hilft letztlich aber allen Beteiligten, sei es im
                Entwicklungsprozess oder als Benutzer, denn es schafft Klarheit, Nachvollziehbarkeit sowie ein einheitliches
                und wiedererkennbares Interface.
            </p>
        </div>

    </div>

    <div class="recommended">
        <h2>Weitere spannende Insights</h2>
        <div class="flex gap-3">
            <InsightSnippet key="uipsychology" :insight="uipsychology" :hideImage="true" />
            <InsightSnippet key="uipsychology" :insight="uipsychology" :hideImage="true" />
            <InsightSnippet key="uipsychology" :insight="uipsychology" :hideImage="true" />
        </div>
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
    .gap-top
        margin-top 3em

    .troll
        background defaultGradient
        background-clip text
        color transparent
        font-weight 700
        transition all .3s

    .downpop
        font-weight 200
        opacity .8

    .uppop
        font-weight 700
        text-transform uppercase

.recommended
    h2
        margin-top 5em
        margin-bottom 0
        text-align center

</style>