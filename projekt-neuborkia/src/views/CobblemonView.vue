<script lang="ts">

export default {
  data() {
    return {
      basiswertsumme: 0,
      dv: {
        att: 0,
        spAtt: 0,
        def: 0,
        spDef: 0,
        hp: 0,
        init: 0
      },
      level: 0,
      rarity: 0,
      evo: 0,
      maxEvo: 1,
      isShiny: false,
      shinyMultiplier: 5,
      isStarter: false,
      starterMultiplier: 2,
      score: 0
    };
  },
  methods: {
    calcScore: function() {
      const getDvSum = () => {
        const { att, def, spAtt, spDef, hp, init } = this.dv;

        return att + def + spAtt + spDef + hp + init;
      };

      const getLevelSum = () => {
        return (this.level * (this.evo / this.maxEvo)) / 10;
      };

      const shinyMultiplier = this.isShiny ? this.shinyMultiplier : 0;
      const starterMultiplier = this.isStarter ? this.starterMultiplier : 0;

      this.score = Math.round(((this.basiswertsumme + getDvSum()) / 100 + getLevelSum() + this.rarity + shinyMultiplier + starterMultiplier) * 1000) / 1000;
    }
  }
};
</script>

<template>
  <div>
    <h1>Angel-Turnier</h1>
    <div class="cm_fishing">
      <div class="basiswerte">
        <div class="col-2">
          <label>Basiswertsumme</label>
          <input type="number" v-model="basiswertsumme" />
        </div>
        <div class="col-2">
          <label>Level</label>
          <input type="number" v-model="level" />
        </div>
        <div class="rarity">
          <label>Seltenheit</label>
          <select v-model="rarity">
            <option v-bind:value="1">Häufig</option>
            <option v-bind:value="2">Ungewöhnlich</option>
            <option v-bind:value="3">Selten</option>
            <option v-bind:value="4">Ultraselten</option>
          </select>
        </div>
        <div class="col-2" style="margin-top: 1em">
          <div>
            <label>Entwicklungsstufe</label>
            <select v-model="evo">
              <option v-bind:value="1">Basis</option>
              <option v-bind:value="2">Stufe 1</option>
              <option v-bind:value="3">Stufe 2</option>
            </select>
          </div>
          <div>
            <label>Max. Stufe</label>
            <select v-model="maxEvo">
              <option v-bind:value="1">Basis</option>
              <option v-bind:value="2">Stufe 1</option>
              <option v-bind:value="3">Stufe 2</option>
            </select>
          </div>
        </div>
        <div className="col-2">
          <div>
            <input type="checkbox" id="shiny" v-model="isShiny">
            <label>Shiny</label>
          </div>
          <div>
            <input type="checkbox" id="starter" v-model="isStarter">
            <label>Starter</label>
          </div>
        </div>
      </div>
      <div class="dv">
        <div class="wrapper">
          <div class="hex">
            <div>DV</div>
            <div>Werte</div>
          </div>
          <div class="att">
            <label>Angriff</label>
            <input type="number" v-model="dv.att" />
          </div>
          <div class="def">
            <label>Verteidigung</label>
            <input type="number" v-model="dv.def" />
          </div>
          <div class="spAtt">
            <label>Spezial-Angriff</label>
            <input type="number" v-model="dv.spAtt" />
          </div>
          <div class="spDef">
            <label>Spezial-Vert.</label>
            <input type="number" v-model="dv.spDef" />
          </div>
          <div class="hp">
            <label>KP</label>
            <input type="number" v-model="dv.hp" />
          </div>
          <div class="init">
            <label>Initiative</label>
            <input type="number" v-model="dv.init" />
          </div>
        </div>
      </div>
    </div>
  </div>

  <div class="result">
    <button class="btn btn-primary" @click="calcScore()">Score berechnen</button>

    <div class="score">
      {{ score.toLocaleString("de-DE") }}
    </div>
  </div>
</template>

<style scoped lang="stylus">
h2
  font-size .75em
  opacity .8

input[type="number"]
  border 1px solid #ffffff
  background rgba(255, 255, 255, .1)
  padding 1em
  border-radius 1em
  color #FFF
  appearance textfield
  text-align center

input[type="checkbox"]
  margin-right 1em

select
  padding 1em
  background rgba(255, 255, 255, .1)
  border-radius 1em
  color #0acd76
  border 1px solid #fff

  option
    background #333

.cm_fishing
  display flex

  > div
    flex 1 0 0

  .basiswerte
    max-width 20em
    margin-right 10em
    margin-top 2em

    > div.col-2
      display flex
      justify-content space-between
      align-items center
      margin-bottom 1em

      input[type="number"]
        width 5em

      select
        margin-top .5em
        width calc(100% - 1em)
        max-width 10em

      > div:last-child select,
      > div:last-child label
        float right

    > .rarity
      display flex
      justify-content space-between

      select
        width 12em

  .wrapper
    width 14em
    height 14em
    padding 4em 0 0 0
    margin 2em 0 0 5em
    position relative

    .hex
      aspect-ratio: cos(30deg);
      clip-path: polygon(-50% 50%, 50% 100%, 150% 50%, 50% 0);
      position relative
      background rgba(255, 255, 255, .1)
      display flex
      flex-direction column
      align-items center
      justify-content center

      > div:first-child
        font-size 2em
        font-weight 800

      > div:last-child
        text-transform uppercase
        font-weight bold
        font-size .8em

    > div:not(.hex)
      display flex
      flex-direction column
      gap .5em
      width 10em

      &.att
        align-items center
        position absolute
        right -10em
        top 5em

      &.def
        align-items center
        position absolute
        right -10em
        top 15em

      &.hp
        align-items center
        position absolute
        top -2em
        margin auto
        left 0
        right 0

      &.init
        align-items center
        position absolute
        bottom -7em
        margin auto
        left 0
        right 0

      &.spAtt
        align-items center
        position absolute
        left -10em
        top 5em

      &.spDef
        align-items center
        position absolute
        left -10em
        top 15em

      input
        width 4em

.result
  width 20em
  display flex
  flex-direction column;
  gap 3em
  align-items center
  justify-content center

  .score
    font-size 5em
    font-weight 800
    background rgba(255, 255, 255, .05)
    border 1px solid rgba(255, 255, 255, .3)
    border-radius .25em
    padding .25em .66em

</style>