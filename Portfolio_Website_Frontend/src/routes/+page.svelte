<script lang="ts">
  import SegmentedScrollbar from "$lib/Segmented_Scrollbar.svelte";
  import Footer from "$lib/footer.svelte";
  import { onMount } from "svelte";

  var height: number;

  onMount(() => {
    var body = document.body,
      html = document.documentElement;

    height = Math.max(html.offsetHeight);
  });

  const sections = [
    { id: "home" },
    { id: "featured" },
    { id: "other" },
    { id: "extra" },
    { id: "contact" },
  ];

  function InterChange() {}
</script>

<body id="body">
  <section id={sections[0].id}>
    <div id="logo">
      <div id="logo-image"></div>
      <div id="logo-name">Toby Looijkens</div>
    </div>
    <div id="banner-title"></div>
    <div id="banner-text">Bringing creativity to the world of</div>
    <div id="firstinterchange">3D</div>
    <div id="secondinterchange">Software</div>
    <div id="bold-text"></div>
  </section>
  <section id={sections[1].id}></section>
  <section id={sections[2].id}></section>
  <section id={sections[3].id}></section>
  <section id={sections[4].id}></section>
  <SegmentedScrollbar {sections} pageHeight={height}></SegmentedScrollbar>
</body>
<footer>
  <Footer></Footer>
</footer>

<style>
  @import url("https://fonts.googleapis.com/css2?family=Playwrite+CU:wght@100..400&display=swap");
  @import url("https://fonts.googleapis.com/css2?family=PT+Sans:ital,wght@0,400;0,700;1,400;1,700&display=swap");
  @import url("https://fonts.googleapis.com/css2?family=Cinzel:wght@400..900&display=swap");

  :global(html) {
    scrollbar-width: none;
    -ms-overflow-style: none;
    /* scroll-snap-type: y mandatory; */
  }

  body {
    width: 100vw;
    scrollbar-width: 0px;
  }

  section {
    width: 100vw;
    height: 100vh;
    /* scroll-snap-align: start; */
  }

  #home {
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    grid-template-rows: 10% 90%;
  }

  #logo {
    grid-row: 1 / span 1;
    grid-column: 1 / span 12;
    width: 100%;
    display: flex;
  }

  #logo-image {
    height: 90%;
    aspect-ratio: 1 / 1;
    justify-self: center;
    align-self: center;
    background-image: url(../img/Logo.svg);
    background-size: cover;
    margin-left: 1%;
  }

  #logo-name {
    display: flex;
    color: white;
    font-family: "Orbitron", sans-serif;
    font-optical-sizing: auto;
    font-weight: 700;
    font-size: 7vmin;
    align-items: center;
    margin-left: 1%;
    text-shadow: 2px 2px rgba(10, 10, 10, 0.1);
  }

  #banner-text {
    grid-column-start: 2;
    grid-column-end: 5;
    grid-row-start: 2;
    grid-row-end: 2;
    margin-left: 5%;
    justify-self: center;
    align-self: center;
    color: white;
    font-family: "Orbitron", sans-serif;
    font-optical-sizing: auto;
    font-weight: 900;
    font-size: 6.5vmin;
  }

  #firstinterchange {
    grid-column-start: 2;
    grid-column-end: 5;
    grid-row-start: 7;
    grid-row-end: 8;
    margin-left: 5%;
    justify-self: center;
    align-self: center;
    color: white;
    font-family: "Orbitron", sans-serif;
    font-optical-sizing: auto;
    font-weight: 900;
    font-size: 14vmin;
  }

  #secondinterchange {
    grid-column-start: 2;
    grid-column-end: 5;
    grid-row-start: 7;
    grid-row-end: 8;
    margin-left: 5%;
    justify-self: center;
    align-self: center;
    color: white;
    font-family: "Orbitron", sans-serif;
    font-optical-sizing: auto;
    font-weight: 900;
    font-size: 14vmin;
  }

  @media only screen and (min-width: 560px) {
  }

  @media only screen and (min-width: 360px) and (max-width: 560px) {
  }
</style>
