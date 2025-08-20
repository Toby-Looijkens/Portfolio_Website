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
</script>

<body id="body">
  <section id={sections[0].id}></section>
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
  }

  body {
    width: 100vw;
    display: grid;
    grid-template-columns: repeat(1fr, 12);
    scrollbar-width: 0px;
  }

  section {
    width: 100vw;
    height: 100vh;
    border: 1px solid white;
  }

  @media only screen and (min-width: 560px) {
  }

  @media only screen and (min-width: 360px) and (max-width: 560px) {
  }
</style>
