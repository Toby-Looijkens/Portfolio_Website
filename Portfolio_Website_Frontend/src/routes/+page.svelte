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
    <div id="viewer3D">

    </div>
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
    grid-template-rows: 6% 6% 88%;
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
    font-size: 4vmin;
    align-items: center;
    margin-left: 1%;
    text-shadow: 2px 2px rgba(10, 10, 10, 0.1);
  }

  #viewer3D {
    grid-row: 3 / span 1;
    grid-column: 1 / span 12;
    margin-left: 2%;
    width: 60%;
    height: 80%;
    background-color: rgba(100, 10, 10, 0);
    border-radius: 5%;
    border: 5px solid rgba(10, 10, 10, 0.5);
    box-shadow: 0px 0px 5px 5px rgba(10, 10, 10, 0.5);
  }

  @media only screen and (min-width: 560px) {
  }

  @media only screen and (min-width: 360px) and (max-width: 560px) {
  }
</style>
