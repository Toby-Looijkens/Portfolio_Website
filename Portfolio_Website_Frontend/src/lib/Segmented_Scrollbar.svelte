<script lang="ts">
  import { onMount } from "svelte";
  import BlackoutBlock from "./blackout-block.svelte";

  export let sections: { id: string }[];
  export let pageHeight: number;
  let headings;
  let scrollIndex = 0;

  onMount(() => {
    headings = document.getElementsByClassName("heading");
    console.log(headings.length);
  });

  if (typeof window !== "undefined") {
    window.onscroll = function UpdateScrollBar() {
      let containerHeight: number =
        document.getElementById("scrollbar")!.offsetHeight;
      let scrollerHeight: number =
        document.getElementById("scroller")!.offsetHeight;

      let maxOffset: number = containerHeight - scrollerHeight;

      console.log(
        (window.pageYOffset /
          (pageHeight -
            document.getElementById(sections[4].id)!.offsetHeight)) *
          maxOffset,
      );

      document.getElementById("scroller")!.style.transform =
        `translate(-20%, ${(window.pageYOffset / (pageHeight - window.innerHeight)) * maxOffset}px`;
    };
  }

  function OpenMenu() {}

  function CloseMenu() {}

  function ScrollOnClick(target: string) {
    var elementToView = document.getElementById(target);
    if (elementToView) {
      elementToView.scrollIntoView({ behavior: "smooth" });
    }
  }
</script>

<div id="menu">
  <div id="headings">
    <h3
      id="nav_home"
      class="heading highlight"
      on:click={() => ScrollOnClick(sections[0].id)}
    >
      Home
    </h3>
    <h3
      id="nav_featured"
      class="heading big"
      on:click={() => ScrollOnClick(sections[1].id)}
    >
      Featured Projects
    </h3>
    <h3
      id="nav_other"
      class="heading medium"
      on:click={() => ScrollOnClick(sections[2].id)}
    >
      Other Projects
    </h3>
    <h3
      id="nav_extra"
      class="heading small"
      on:click={() => ScrollOnClick(sections[3].id)}
    >
      Extras
    </h3>
    <h3
      id="nav_contact"
      class="heading extra_small"
      on:click={() => ScrollOnClick(sections[4].id)}
    >
      Contact
    </h3>
  </div>
  <div id="scrollbar">
    <div id="scroller"></div>
  </div>
</div>

<style>
  @import url("https://fonts.googleapis.com/css2?family=Orbitron:wght@400..900&display=swap");

  #menu {
    width: 30vw;
    height: 30vh;
    position: fixed;
    justify-self: right;
    display: flex;
    margin-right: 1%;
    top: 50%;
    transform: translate(0%, -50%);
  }

  #headings {
    width: 90%;
    height: 96%;
    padding-right: 2%;
    justify-content: right;
    display: grid;
    grid-template-rows: repeat(5, 1fr);
    margin: 2px;
  }

  .heading {
    display: flex;
    margin: 0px;
    width: auto;
    justify-content: flex-end;
    text-align: right;
    align-items: center;
    font-family: "Orbitron", sans-serif;
    color: #a3a5a6;
    font-optical-sizing: auto;
    font-weight: 700;
    padding: 1%;
  }

  #scrollbar {
    width: 2%;
    margin-left: 4%;
    margin-right: 4%;
    height: 100%;
    background-color: #a3a5a6;
    border-radius: 5px;
  }

  #scroller {
    display: inline-block;
    position: absolute;
    width: 3%;
    height: 20%;
    transform: translateX(-50%);
    border-radius: 5px;
    background-color: #d9d9d9;
  }

  #scroller:hover {
    cursor: pointer;
  }

  .heading:hover {
    cursor: pointer;
    color: #dddede;
    padding-right: 2%;
    transition-duration: 350ms;
  }

  .heading.highlight {
    color: white;
    font-size: 2.5vmin;
    padding-right: 2%;
  }

  .heading.highlight:hover {
    padding-right: 3%;
  }

  .heading.big {
    font-size: 2.3vmin;
  }

  .heading.medium {
    font-size: 2.1vmin;
  }

  .heading.small {
    font-size: 1.9vmin;
  }

  .heading.extra_small {
    font-size: 1.7vmin;
  }
</style>
