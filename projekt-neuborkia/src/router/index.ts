import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";
import ProjectView from "../views/ProjectView.vue";
import ImpressumView from "../views/ImpressumView.vue";
import PrivacyView from "../views/PrivacyView.vue";
import TcgView from '../views/TcgView.vue'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: "/",
      name: "home",
      component: HomeView,
    },
    {
      path: "/project/:id",
      name: "project",
      component: ProjectView,
      props: true,
    },
    {
      path: "/impressum",
      name: "impressum",
      component: ImpressumView,
    },
    {
      path: "/datenschutz",
      name: "privacy",
      component: PrivacyView,
    },
    {
      path: "/tcg/:id?",
      name: "tcg",
      component: TcgView,
      props: true
    }
  ],
  scrollBehavior(to, from, savedPosition) {
    if (savedPosition) {
      return savedPosition;
    }
    if (to.hash) {
      return {
        el: to.hash,
        behavior: "smooth",
      };
    } else {
      return {
        behavior: "smooth",
      };
    }
  },
});

export default router;
