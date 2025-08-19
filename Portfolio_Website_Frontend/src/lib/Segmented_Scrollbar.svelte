<script lang="ts">
  import { onMount } from "svelte";

  let headings;
  let scrollIndex = 0;

  onMount(() => {
    headings = document.getElementsByClassName("heading");
    console.log(headings.length);
  });

  window.onscroll = function UpdateScrollBar() {
    document.body.scrollTop;
  };

  function OpenMenu() {}

  function CloseMenu() {}
</script>

<div id="menu">
  <div id="headings">
    <div class="heading_container">
      <h3 id="home" class="heading highlight">Home</h3>
    </div>
    <div class="heading_container">
      <h3 id="featured" class="heading big">Featured Works</h3>
    </div>
    <div class="heading_container">
      <h3 id="other" class="heading medium">Other Projects</h3>
    </div>
    <div class="heading_container">
      <h3 id="extra" class="heading small">Extras</h3>
    </div>
    <div class="heading_container">
      <h3 id="contact" class="heading extra_small">Contact</h3>
    </div>
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
    height: 100%;
    padding-right: 2%;
    text-align: right;
    display: grid;
    grid-template-rows: repeat(5, 1fr);
    margin: 2px;
  }

  .heading {
    margin: 0px;
    align-content: center;
    font-family: "Orbitron", sans-serif;
    color: #a3a5a6;
    font-optical-sizing: auto;
    font-weight: 700;
  }

  .heading_container {
    align-content: center;
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
    width: 120%;
    height: 20%;
    transform: translate(-5%, 0);
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
    padding-right: 1%;
  }

  .heading.highlight:hover {
    padding-right: 2%;
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
