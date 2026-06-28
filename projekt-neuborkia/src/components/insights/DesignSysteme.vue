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

        <div class="flex gap-3 gap-top">
            <div class="text width-1 flex-1-0-0">
                <h3>Das ist drin - Design Systeme im Detail</h3>
                <p>
                    Doch was steckt konkret drin in einem Design System? Da der Nutzen und die Vorteile klar geworden sind, lohnt es sich einen genaueren Blick unter die Haube zu wagen, und sich im 
                    Detail anzuschauen, wie ein Design System aufgebaut sein kann, welche Regelungen darin konkret zu finden sind, wie man sie strukturieren kann und vor allem, warum auch auf den 
                    ersten Blick vielleicht unwichtige Dinge, wie Abstände eine tragende Rolle spielen können.
                </p>
                <p>
                    Es ist an dieser Stelle jedoch auch wichtig zu betonen, dass es 
                    nicht „den einen“ perfekten Guide zur Erstellung eines Design Systems gibt. Oftmals sind die Ansprüche daran ganz unterschiedlich: 
                </p>
            </div>
            <div class="text width-1 flex-1-0-0" style="margin-top: 5em">
                <p>
                    Für kleinere Projekte reichen oft bereits
                    einige grob ausgearbeitete Regeln, während bei größeren Vorhaben mit verschiedenen Beteiligten eine detailliertere Ausarbeitung durchaus sinnvoll sein kann. Auch soll hier
                    kein Anspruch auf Vollständigkeit erhoben werden, denn wichtig ist am Ende, dass die Menschen, die mit einem Design System arbeiten sollen, so wenig offene Fragen wie
                    möglich haben und sich darin zurechtfinden. Viel mehr zeige ich hier einen Ausschnitt dessen, wie ich in der Vergangenheit erfolgreich Design Systeme eingesetzt und entwickelt
                    habe.
                </p>
            </div>
        </div>
        <div class="flex gap-3 gap-top">
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
        <div class="flex gap-3 gap-top">
            <div class="text width-1 flex-1-0-0">        
                <h4>Wireframes</h4>
                <p>
                    Zur Erstellung von sogenannten „Wireframes“ ist es nicht zwingend notwendig, sich vorher ein Moodboard zu erstellen, es ist aber dennoch oftmals schon hilfreich. Beim wireframing
                    kommen weder Farben noch konkrete Schriftarten zum Einsatz, theoretisch muss es nicht einmal digital erfolgen, es reicht bereits ein Stift und Papier (tatsächlich wird auch
                    hin und wieder noch so gearbeitet). Vielmehr soll in diesem Schritt der grundlegende Aufbau und ein grobes Gerüst konzipiert werden, die dann im weiteren Verlauf des Entwicklungsprozeses
                    detaillierter ausgearbeitet werden.
                </p>
                <div class="flex gap-3">
                    <div class="image img-rounded masonry">
                        <img :src="'../images/insights/wireframe_01.webp'" alt=""/>
                        <img :src="'../images/insights/wireframe_02.webp'" alt=""/>
                    </div>
                    <div class="image img-rounded masonry">
                        <img :src="'../images/insights/wireframe_04.webp'" alt=""/>
                        <img :src="'../images/insights/wireframe_03.webp'" alt=""/>
                    </div>
                </div>
                <div class="image">
                    <span class="caption">Erste Wireframes muten zunächst spartanisch an, reduzieren aber das Design auf das Wesentliche.</span>
                </div>
            </div>
            <div class="text width-1 flex-1-0-0">        
                <h4>Abstände &amp; Whitespace</h4>
                <p>
                    Beim Thema Design denkt man oftmals zuerst an Farben, Bilder, Animationen, Videos und tolle Effekte. Alles davon kann auch dazu beitragen Bereiche und Elemente spannender zu gestalten,
                    oder den Fokus des Benutzers auf bestimmte Bereiche zu lenken, doch oftmals unterschätzt man dabei ein UI-Element, was eigentlich streng genommen gar keines ist: Whitespace. Der leere
                    Raum ist ein mächtiges Werkzeug, um unauffällig den Fokus zu lenken. Wenn es um ein Redesign geht, hat es oftmals den größten Effekt, wenn man einfach nur mehr Platz schafft und die 
                    einzelnen Bereiche oder Elemente mehr Platz zum atmen haben. Es wirkt zunächst nicht intuitiv, denn leerer Raum bietet keinen Inhalt oder enthält Informationen. Doch genau darin liegt
                    auch seine Stärke, denn er lenkt die Aufmerksamkeit dorthin, wo der Inhalt zu finden ist. Fehlt der Freiaum, kämpfen zahlreiche Elemente um die Aufmerksamkeit des Nutzers, man weiß oft
                    gar nicht, wo man zuerst hinschauen soll und verliert sich im Informationschaos. Die gezielte Suche nach Informationen wird zur Herausforderung.
                </p>
                <p>
                    Whitespace ist in der Praxis nicht selten eine Stelle, bei der feste Regeln nur bedingt helfen. Geht es darum ein bestimmtes Element richtig in Szene zu setzen, braucht es oft individuelle
                    Abstände, je nach Bedarf. Die goldene Regel hier ist: die richtige Menge Whitespace findet man, indem man den Abstand verringert, statt vergrößert. Das klingt erstmal, als würde es den
                    kompletten vorherigen Abschnitt invalidieren, gemeint ist damit aber das Folgende: Beginnt man mit gar keinem Abstand und erhöht diesen Stück für Stück, hat man am Ende gerade so viel
                    Leerraum, dass es gerade so nicht mehr schlecht aussieht. Normalerweise brauchen Elemente jedoch deutlich mehr Platz als man denkt, um wirklich hervorzustechen. Also dreht man den Spieß um
                    und startet mit so absurd viel Leerraum, dass es eindeutig zu viel ist. Anschließend verringert man diesen bis zu dem Punkt, wo es besser aussieht. Probiert man diese Taktik aus wird man
                    feststellen, dass bei der zweiten Variante deutlich mehr Whitespace übrig bleibt, als bei der ersten Herangehensweise.
                </p>
                
                <div class="quote" style="width: 80%">
                    „Normalerweise brauchen Elemente deutlich mehr Raum als man denkt.“
                </div>

                <p>
                    Sind fixe Regelungen für Abstände also gar nicht sinnvoll? Doch, in gewisser Weise schon, allerdings sind die Anwendungszwecke hier enger abgesteckt und bei Bedarf ist ein Abweichen von den
                    Regeln nicht nur erlaubt, sondern oft sogar notwendig. Bei Abständen zwischen wiederkehrenden UI Elementen, wie Paragraphen längerer Texte, Abstände von Überschriften, oder dem Freiraum
                    zwischen Navigationselementen ist es aber sinnvoll einige Vorgaben bereitzustellen. Wichtig ist dabei, dass die Abstände nicht linear vergrößert werden sollten, sondern eher einer 
                    logarithmischen Kurve folgen sollten,
                </p>
            </div>
        </div>

        <div class="flex gap-3 gap-top">
            <div class="text width-1 flex-1-0-0">
                <h4>Farbkonzeption</h4>
                <p>
                    Wenn eine grundlegende Idee und ein struktureller Aufbau erarbeitet wurde, kann man sich nun auch der Farbgestaltung widmen. Oft gehören Farben den ersten Assoziationen, wenn
                    es um UI-Design geht, tatsächlich kommen die bunten Pixel aber erst recht spät im Prozess wirklich zum tragen. Auch hier gilt es einige grundlegenden Dinge zu beachten, die
                    letztlich den Unterschied zwischen einem durchdachten und logischen Interface, und einem das aussieht, als wäre man in die Villa kunterbunt gestolpert machen können.
                </p>
                <p>
                    Im Internet findet man auf der Suche nach Farben schnell so genannte „Farbpaletten“ mit drei oder sogar mehr Farben, die zwar gut und nach bestimmten Regeln aufeinander 
                    abgestimmt sind, jedoch ist das Ziel nicht das nächste Wandgemälde im Michelangelo Stil zu erschaffen, sondern ein nutzbares und klares User Interface. Daher reicht es meist
                    bereits aus, nur eine einzige Farbe auszuwählen, diese aber in mehreren Abstufungen von hell zu dunkel auszudefinieren. Gegebenenfalls können auch zwei Farben gut miteinander
                    harmonieren, nötig ist das allerdings nicht.
                </p>
                <p>
                    Ist die Entscheidung für eine Farbe gefallen, kann es durchaus herausfordernd sein, die Helligkeitsabstufungen richtig anzupassen. Wie viele Abstufungen benötigt werden, 
                    hängt natürlich immer vom Einsatzzweck ab, allerdings sind 3 das absolute Minimum (Primär, helle Variante, dunkle Variante). Besser sind 5 Abstufungen, bei komplexen 
                    Benutzerobferflächen können es aber gut und gern auch mal 7 oder mehr werden. Die Zahl ist dabei normalerweise ungerade, da es in der Mitte der Farbpalette eine Primärfarbe
                    gibt, und jeweils links und rechts davon die gleiche Anzahl an hellen und dunklen Abstufungen.
                </p>
            </div>

            
            <div class="image img-rounded width-1 flex-1-0-0">
                <img :src="'../images/insights/colors.webp'" alt=""/>
                <span class="caption">Konzeption der Farbpalette dieser Seite mit Primär- und Sekundärfarbe, sowie Verläufen</span>
            </div>      
        </div>      
        <div class="flex gap-3">
            <div class="image img-rounded width-1 flex-1-0-0">
                <img :src="'../images/insights/color_saturation.webp'" alt="" style="max-width: 600px; border-radius: .75em"/>
                <span class="caption">Wenig Sättigung bei helleren Farben - viel Sättigung bei dunklen Farben</span>
            </div>

            <div class="text width-1 flex-1-0-0">
                <p>
                    Als kleine Faustregel für die Helligkeitsabstufungen gilt: Je heller, desto niedriger sollte der Sättigungswert eingestellt werden (Zur Farbabstimmung ist immer der HSL 
                    Farbraum, statt beispielsweise RGB oder CMYK empfehlenswert) und je dunkler, desto mehr Sättigung wird auch benötigt, damit die Farbe noch leicht durchscheint und man nicht
                    bei mehreren Grautönen landet. Ganz pragmatisch lässt sich das auch mit echten Farben veranschaulichen: Bei weiß reicht bereits ein kleiner Klecks von beispielsweise rot, um
                    ein sanftes Rosa zu erhalten. Startet man jedoch mit schwarz, muss reichlich rot dazugegeben werden, damit der eigentliche Farbton tatsächlich durchschimmert. Oder aus der
                    anderen Richtung: Fügt man dem Rot schwarz hinzu, reicht schon eine kleine Menge und es wird signifikant dunkler.
                </p>
                <p>
                    Das Thema Farben, wie sie wirken, welche Primärfarbe möglicherweise am besten zu wem passt und was es alles zu beachten gibt ist jedoch so komplex, dass es hier nur angerissen
                    werden kann. Wer mehr darüber erfahren möchte, findet im Bereich <a class="no-hover-effect text-link" href="/insights/color-theory" title="Pixel & Pigmente: Der UI-Farbguide" 
                    alt="Link zum weiterführenden Artikel „Pixel & Pigmente: Der UI-Farbguide“">„Pixel & Pigmente: Der UI-Farbguide“</a> noch viel mehr Tipps und Tricks, sowie Erklärungen und 
                    Hilfestellungen.
                </p>
            </div>
        </div>

        <div class="flex gap-3 gap-top">
            <div class="text width-1 flex-1-0-0">
                <h4>Typographie</h4>
                <p>
                    Die richtige Wahl der Schriftart gehört zu den am meisten unterschätzten Themen im Bezug auf ansprechendes Design. In gewisser Weise ist das auch nachvollziehbar, immerhin
                    sehen sich viele Schriftarten sehr ähnlich, im Falle von Arial oder Helvetica muss man die Unterschiede teils wirklich mit der Lupe suchen. Und doch ist es kein Zufall, dass
                    große Unternhemen sich oft sogar eigene Fonts gestalten lassen, um die Individualität des eigenen Brandings zu steigern. 
                </p>
                <p>
                    Nun ist es natürlich eher selten notwendig, sich eine komplett eigene Schriftart gestalten zu lassen (und sicher auch nicht sonderlich günstig), allerdings kann man auch mit
                    freien Fonts bereits einen großen Effekt erzielen, wenn man sich darüber Gedanken macht, welche Stimmung vermittelt werden soll. Buchstaben mit Serifen vermitteln einen eher
                    professionellen und wertigeren Eindruck, als solche ohne. Soll es etwas freundlicher wirken, können abgerundete Ecken an den Lettern dazu beitragen. Viele weitere Eigenschaften
                    vermitteln ganz bestimmte Emotionen und Stimmungsbilder und zu erkennen, welches am besten zum eigenen Projekt passt, ist ein wichtiger Schritt in Richtung eines ansprechenden
                    UI. Wer hier bereits beim Wort „Serifen“ ausgestiegen ist: Kein Problem, auch das Feld der Schriftarten ist unheimlich breit gefächert und wie man die korrekte Wahl trifft,
                    was es mit all den Buzzwords auf sich hat und wie man die feinen Unterschiede erkennt gibt es im Bereich <a class="no-hover-effect text-link" href="/insights/typography" title="Pixel & Pigmente: Der UI-Farbguide" 
                    alt="Link zum weiterführenden Artikel „Typografie auf den Punkt“">„Typografie auf den Punkt“</a> zu entdecken.
                </p>
            </div>
            <div class="image img-rounded  width-1 flex-1-0-0">
                <img :src="'../images/insights/typography.webp'" alt=""/>
                <span class="caption">Schriftarten sind ein mächtiges Kommunikations-Werkzeug</span>
            </div>
        </div>
        <div class="flex gap-3">
            <div class="text width-1 flex-1-0-0">
                <p>
                    In diesem Thema soll es jedoch weniger um die eigentliche Auswahl und Wirkung verschiedener Schriftarten gehen, sondern vielmehr darum wie sie im Design System verwendet
                    werden kann, worauf bei der Verwendung zu achten ist und - natürlich - welche Ausnahmen es von den Regeln gibt. <br/>
                    Die Wahl wurde nach reiflicher Überlegung also getroffen, weswegen im nächsten Schritt Regeln für die Verwendung von Text und Schrift erstellt werden müssen. Die Basis für
                    diese Regeln ist die Größe und der Stil von Fließtexten. Diese werden in jedem Bereich den größten Teil der Worte ausmachen und sind gleichzeitig der Ankerpunkt für alle
                    anderen Schriftregeln, welche immer um einen Faktor x größer und seltener auch kleiner sind. Diesen Faktor kann man später im Code verwenden, denn besonders im Web-Bereich
                    sollten em oder rem die Einheiten der Wahl für Schriftgrößen sein. Beide definieren die Größe relativ zu einem bestimmten Ankerpunkt, lediglich dieser unterscheidet sich
                    bei beiden. Während bei em die Größe des Elterncontainers ausschalggebend ist, bezieht sich rem immer auf einen globalen Ankerpunkt. <br/>
                    Die Basis dafür, also die Größe des regulären Fließtextes sollte also nicht zu groß und nicht zu klein sein, den einerseits skalieren die Überschriften zu weit, wenn der
                    Ankerpunkt bereits sehr groß gewählt wurde, andererseits sind größere Fonts generell besser lesbar, besonders auf kleineren Geräten wie Smartphones oder für Menschen mit
                    visuellen Handicaps. Etwa 20 px (das unterscheidet sich je nach Schriftart ein wenig) bei einem regulären Monitor mit 100% DPI Skalierung eigenen sich als Basisschriftgröße
                    erfahrungsgemäß am besten, allerdings darf hier durchaus um ein paar wenige Größenordnungen nach oben oder unten experimentiert werden. <br/>
                    Ausgehend hiervon kann sich nun die verschiedenen Hierarchie-Ebenen nach oben gearbeitet weden. Wie viele davon relevant sind ist natürlich ganz vom Einsatzzweck abhängig,
                    mancher kommt mit zwei Überschriften klar, textlastige Projekte benötigen aber gern mehrere Hierarchiestufen. Wichtig ist, dass diese sich klar voneinander abgrenzen, um
                    zu gewährleisten, dass die unterschiedlichen Ebenen auf einen Blick erkennbar sind. Anders gesagt: Eine Überschrift sollte immer als solche aussehen, nicht wie Text, und 
                    verschiedene Überschriften sollten ihrer Stufe entsprechend unterschiedlich viel Gewicht mitbringen. Dieses Gewicht lässt sich über Faktoren wie die Schriftrgröße, aber
                    auch über Eigenschaften wie Gewichtung und Farbe steuern. Hier findet sich auch eine hervorragende Faustregel für gute (Fließtext)-Schriftarten: Je mehr Stile sie von sich
                    aus mitbringt, desto besser. Viele Schriftarten bieten nicht nur die reguläre Font-Weight an, sondern auch fett (bold) oder sogar Zwischenstufen (medium, semi-bold, extra-bold,
                    black, ...), sowie kursiv in all den eben genannten Ausführugnen. Es müssen natürlich nicht immer 8 verschiedene Gewichtungen vorhanden sein, aber wenn es neben der normalen
                    Schriftart lediglich eine bold und italic Variante (oder sogar gar keine Variante) gibt, ist Vorsicht geboten. Möglicherweise eignet sich eine solche Schriftart dann eher
                    für Akzente wie Überschriften und Titel. <br/>
                    Allgemein gilt bei Schriftarten das gleiche Sparsamkeitsprinzip wie bei Farben: Weniger ist meist mehr und nicht selten reicht es aus eine einzige passende Schriftart zu 
                    finden. Soll noch eine zweite dazu kommen, ist es sinnvoll diese maximal für bestimmte Akzente zu nutzen, die allerdings gut begründete Ausnahmen sein sollten. Je mehr
                    Fonts verwendet werden, desto schwieriger wird es die Hierarchie zu unterscheiden und zu erkennen, um was für eine Art Text es sich eigentlich gerade handelt. Sparsamkeit
                    ist zudem auch ein wunderbares Stichwort beim Thema Textfarbe, denn auch hier ist weniger mehr. Während es kein Problem ist Texte in unterschiedlichen Graustufen (unter
                    Wahrung der Accessibility-Guidelines) zu trennen, sollte farblich hervorgehobener Text ausschließlich für Links verwendet werden. Hier scheitert der kreative Freiraum
                    einfach an der Gewohnheit der Nutzer, die von Anbeginn des Internets darauf trainiert wurden, auf farblich hervorgehobene Textabschnitte klicken zu können. Ausnahmen bilden
                    hier lediglich einige Überschriften, doch auch hier sollte mit Bedacht vorgegangen werden.
                    
                </p>
            </div>
            <div class="text width-1 flex-1-0-0">
                <p>
                    Moar text
                </p>
            </div>
        </div>


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
    .gap-top
        margin-top 3em

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