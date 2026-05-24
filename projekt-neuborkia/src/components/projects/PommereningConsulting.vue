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
    <div class="flex">
      <div class="image">
        <img src="@/assets/images/projects/pommereningconsulting/story/LogoVision.webp" />
        <span class="caption">Das Logo symbolisiert den direkten Austausch mit dem Kunden</span>
      </div>
      <div class="text">
        <p>
          Das finale Logo zeigt ein stilisiertes blaues „P“ und stellt so einen direkten Bezug zum Firmennamen her. Spiegelt man das „P“ auf beiden Achsen erkennt man eine sinnbildliche Person,
          ähnlich wie auf den klassischen Platzhaltern für Profilfotos. Gleichzeitig bilden die beiden größeren Elemente eine Art Konversation zweier Sprechblasen. <br/> All das zusammen ergibt 
          ein Logo, welches alle Aspekte der klassischen Consulting-Arbeit ineinander vereint: Bei Pommerening Consulting führt die direkte Kommunikation mit dem Kunden immer zum bestmöglichen 
          Ergebnis, denn nur wenn für beide Seiten die Ziele klar sind wird eine effiziente und lösungsorientierte Umsetzung der ursprünglichen Vision ermöglicht.
        </p>
      </div>
    </div>

    <h3>Corporate Identity</h3>
    <p>
      Eine Corporate Identity, die individuelle Identität, setzt sich aus verschiedenen Elementen zusammen, die alle auf ihre eigene Art wichtig sind. Dazu zählen Elemente, die direkt ins Auge
      stechen, wie die Auswahl der Farben, aber auch subtilere Elemente, wie die Schriftart.
    </p>

    <h3>Design System</h3>
    <p>Lorem ipsum dolor sit amet</p>

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
  @import '../../assets/config.styl'

  .story
    margin-top 5em

    h1
      margin 8em 0 3em 0

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

      &:after
        display none
      
      &:hover
        color secondaryColor

    .flex
      gap 10em
  
      div.image
        flex 1 0 0
        display flex
        flex-direction column
        justify-content center
        align-items center

        img
          width 80%

        span.caption
          font-size .75em
          color rgba(#fff, .75)
          padding 1em 0

      div.text p
        flex 3 0 0

</style>