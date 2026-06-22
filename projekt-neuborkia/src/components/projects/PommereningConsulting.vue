<script lang="ts">
import ProjectHeader from "@/components/elements/ProjectHeader.vue";
import Masonry from "@/components/elements/Masonry.vue";
import { TAG_DESIGN, TAG_DEV } from "@/helper/const";

export default {
  data() {
    return {
      tags: [TAG_DESIGN, TAG_DEV],
      projectName: "pommereningconsulting"
    };
  },
  components: {
    ProjectHeader,
    Masonry
  }
};
</script>

<template>
    <ProjectHeader :projectName="projectName"
                :headline="'Konzeption und Umsetzung Website'"
                :subHeadline="'Praxisnahe DevOps-Lösungen für Ihr Unternehmen – modern, innovativ und nachhaltig.'"
                :abstract="'Frank Pommerening unterstützt auch Ihr Unternehmen professionell rund um das Thema DevOps. Mit Technologien wie Kubernetes zur effizienten Orchestrierung von Containern bis hin zu Blazor-Anwendungen für schnelle und stabile Umsetzungen ist alles dabei.'"
                :timespan="'1 Jahr'"
                :year="'2025 / 26'"
                :tags="tags"
                :linkTarget="'https://pommerening-consulting.de/'"
                :linkTargetSecondary="'#story'"
                :openInNewTab="false"
                :buttonLabelSecondary="'die story'" />

  <div class="story">
    <h1 id="story">story</h1>
  
    <h2>Ende zu Ende Webentwicklung - Von der Skizze zur fertigen Seite</h2>

    <div class="flex gap-2">
      <div class="text width-2 accent accent-1">
        <p>
          Für seine gleichnamige IT-Consulting Firma hat Frank Pommerening ein „Rundum sorglos“ Paket für den neuen Webauftritt des Unternehmens gesucht. Vom Logo, über die Konzeption des Designs 
          bis hin zur technischen Umestzung der Homepage durfte ich die Verantwortung für die neue digitale Identität von <a href="https://pommerening-consulting.de/" alt="Link zur Website von 
          Pommerening Consulting" title="Zur Homepage" target="_blank">Pommerening Consulting</a> übernehmen um am Ende eine maßgeschneiderte und individuelle Lösung zu vorzustellen.
        </p>

        <h3>Das Logo</h3>
        <p>Dreh- und Angelpunkt einer Firmenidenität ist immer das Logo. Es muss gleichzeitig klar kommunizieren, welche Werte und Kompetenzen ein Unternhemen bietet, sollte aber auch individuell
          genug sein, um die Markenidendität zu stärken und damit einen hohen Wiedererkennungswert besitzen. Einfachheit und Komplexität - Zwei auf den ersten Blick gegensätzliche Eigenschaften,
          und doch sind beide enorm wichtig für ein Logo.
        </p>
        <p>
          Consulting ist ein Bereich, der Menschen zusammen bringt. Er lebt vom regen Austausch mit dem Kunden, der nach Unterstützung sucht, gleichzeitig aber seine Ideen und Konzepte so erklären
          muss, dass am Ende ein Produkt oder eine Dienstleistung entsteht, die einen echten Mehrwert bieten kann. Diesen kommunikativen Aspekt mit in das Logo zu integrieren, war von Anfang an
          Teil meiner Vision für das Logo, ohne jedoch die eigentliche Markenidentität von Pommerening Consulting zu vernachlässigen.
        </p>
      </div>
      <div class="image img-rounded width-2">
        <img src="@/assets/images/projects/pommereningconsulting/story/logo_concept.jpeg" />
        <span class="caption">Erste Konzepte und Sammlung der Ideen. (Ja, ich habe meine Displayfolie falsch herum angebracht)</span>
      </div>
    </div>

    <div class="flex gap-2">
      <div class="image width-2">
        <img src="@/assets/images/projects/pommereningconsulting/story/LogoVision.webp" />
        <span class="caption">Das Logo symbolisiert den direkten Austausch mit dem Kunden</span>
      </div>
      <div class="text width-2">
        <p>
          Das finale Logo zeigt ein stilisiertes blaues „P“ und stellt so einen direkten Bezug zum Firmennamen her. Spiegelt man das „P“ auf beiden Achsen erkennt man eine sinnbildliche Person,
          ähnlich wie auf den klassischen Platzhaltern für Profilfotos. Gleichzeitig bilden die beiden größeren Elemente eine Art Konversation zweier Sprechblasen. <br/> All das zusammen ergibt 
          ein Logo, welches alle Aspekte der klassischen Consulting-Arbeit ineinander vereint: Bei Pommerening Consulting führt die direkte Kommunikation mit dem Kunden immer zum bestmöglichen 
          Ergebnis, denn nur wenn für beide Seiten die Ziele klar sind wird eine effiziente und lösungsorientierte Umsetzung der ursprünglichen Vision ermöglicht.
        </p>
      </div>
      <div class="image width-1">
        <img src="@/assets/images/projects/pommereningconsulting/story/pc_logo.webp" />
        <span class="caption">Das finale Logo</span>
      </div>
    </div>

    <h3>Corporate Identity</h3>
    <div class="flex gap-2">
      <div class="text width-1">
        <p>
          Eine Corporate Identity, die individuelle Identität, ist ein Zusammenspiel aus Farben, Formen und bestimmten Regeln. Oftmals sind all diese Informationen in einem Design System,
          bzw. einem Styleguide verankert. Durch die wiederkehrenden Elemente entsteht ein einheitliches Auftreten, was einen klaren Wiedererennungswert schafft. Dadurch manifstiert sich
          die Unternehmenseigene Identität und vom Webauftritt über Vortragsfolien bis hin zum Briefpapier ist diese DNA jederzeit wiederzuerkennen. Auch das bereits fertige Logo gehört
          hier dazu und hat einen besonderen Stellenwert, da es in der Regel die meiste Verwendung auf Marketing-Material findet. 
        </p>
        <p>
          Allein die Definition von einigen Farben und Regeln schafft jedoch noch keine eigene Identität. Hierfür braucht es einen kreativen Prozess, damit die Werte und Leistungen des
          Unternehmens sich im Design widerspiegeln. Hier müssen zunächst einige Eigenschaften der eigenen Marke abgesteckt werden, wobei diese Aufzählung nicht notwendigerweise bereits
          vollständig ist.
          <ul>
            <li>Wird ein Produkt, eine Dienstleistung oder sogar beides angeboten?</li>
            <li>Ist die Markenausrichtung eher luxuriös oder locker?</li>
            <li>Richtet sich das Angebot an einen Premium- oder Massenmarkt?</li>
            <li>soll das Auftreten eher konservativ oder verspielt wirken?</li>
            <li>Wie sieht der ideale Kunde aus? Welche Eigenschaften bringt er mit?</li>
          </ul>
        </p>
      </div>
      <div class="text width-1">
        <p>
          Fast immer gibt es auf keine dieser Fragen eine eindeutigen Antwort, vielmehr verteilen sich die Eigenschaften auf ein kleines Spektrum innerhalb der Antworten. Manchmal trifft
          auch gar nichts zu, manchmal müssen noch andere Fragen gestellt werden. Wichtig ist am Ende aber, dass ein klares Bild vom Unternehmen, den Werten und den Zielen entsteht. Erst
          dann lässt sich aus diesen Erkenntnissen eine Corporate Identity entwerfen, die wirklich zum Kunden passt.
        </p>
        <p>
          Das Consulting Unternehmen von Frank Pommerening ist eine junge, professionelle Firma mit klarem Anspruch an eine hohe technische Expertise. Die Corporate Identity soll 
          professionell, modern und technologieorientiert sein. Das entworfene Design System setzt daher auf klare Akzente, aber einen generell eher minimalistischen Look. Der 
          helle und freundliche Gesamteindruck wird an vielen Stellen mit Farbakzenten in blau und lila ergänzt. Diese Farben verbindet man aus psychologischer Sicht vor allem mit
          Vertrauen, Stabilität und Sicherheit (blau), jedoch ergänzt durch einen Akzent von Kreativität, Erfolg und Einfallsreichtum (lila). <br/>
          Durch eine subtile Verwendung von Schatten und Highlights wird ein leichter 3D-Effekt erzeugt, der einladend, freundlich und auch ein wenig frech ist. Der Gesamteindruck
          wirkt dadurch jugendlich und mordern, ohne dabei Zweifel an der Kompetenz und Zuverlässigkeit zu lassen.  
        </p>
      </div>
    </div>

    <h3>Design System</h3>
    <p>Da die Vision und die Identität nun klar ist, müssen diese eher kreativen Ansätze in klare technische Regeln und Anweisungen übersetzt werden. Hier kommt das bereits erwähnte
      Design System zum tragen, das detailliert Eigenschaften wie Farbgebung, Schriftgrößen, UI-Elemente und deren jeweilige Bedeutung beschreibt. Ein solches System ist hilfreich,
      um sicherzustellen, dass UI Elemente und der gesamte UX-Workflow konsistent bleiben und nicht nur alles nach einem stimmigen Gesamtpaket aussieht, sondern sich auch so benutzen lässt.
      Dabei spielen viele eng miteinander verzahnte Faktoren eine Rolle, die je nach Bedarf detaillierter oder auch weniger filigran ausgestaltet werden können.
    </p>
    <h4>Formen &amp; UI-Elemente</h4>
    <p>Man kommt schnell in Versuchung ein Design ganzeitlich umsetzen zu wollen, doch hierin liegt eine trügerische Sicherheit. Details wie Farben, die konkrete Festlegung
      eines Iconsets und sogar Schriftarten spielen im grundlegenden Designprozess eine
    </p>
    <h4>Typographie</h4>
    <p></p>
    <h4>Farben</h4>
    <p></p>

    <h3>Technische Umsetzung</h3>
    <p>Lorem ipsum dolor sit amet</p>

    <h1>gallerie</h1>
    <p>Lorem ipsum dolor sit amet</p>
  </div>

  <RouterLink
    :to="{  path: '/', hash: '#projects' }"
    class="no-hover-effect block text-center"
  >
    <button class="btn btn-primary">Zurück zur Übersicht</button>
  </RouterLink>
</template>

<style scoped lang="stylus">
  @import '../../styles/config.styl'

  .story
    margin-top 5em

    h1
      margin 0 0 -.25em 0

    h2
      margin 2em 0 .75em 0
      font-size 2em

    h3
      margin 5em 0 .75em 0

    p
      line-height 1.66em
      max-width 40em
      text-align justify
      hyphens auto
      margin-bottom 2em

    a
      color primaryColor
      transition color .2s

      &:after, &:before
        display none
      
      &:hover
        color tintedWhite

    .flex
      div.text p
        flex 3 0 0

  .accent
    position relative

    &:before, &:after
      content ''
      display block
      border-radius 50%
      filter blur(5em)
      position absolute
      z-index -1

    &.accent-1:before
      background primaryColor
      width 150%
      height 40em
      opacity .3
      left -20em
      top -5em

    &.accent-1:after
      background secondaryColor
      width 200%
      height 60em
      opacity .3
      left 15em
      top 0em
</style>