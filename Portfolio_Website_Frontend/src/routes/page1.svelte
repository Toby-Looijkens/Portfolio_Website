<script lang="ts">
  import BlackoutBlock from "$lib/blackout-block.svelte";
  import Gallerycard from "$lib/gallerycard.svelte";
  import { onMount } from "svelte";

  let hasClicked = false;
  let totalRipples = 3;

  let rippleX = "0px";
  let rippleY = "0px";

  const ripples = ["small-ripple", "small-ripple", "big-ripple"];

  onMount(() => {
    const blackout = document.getElementById("blackout");
    blackout?.style.grid;
    //@ts-ignore
    blackout.addEventListener("mousemove", (event) => {
      rippleX = event.clientX.toString() + "px";
      rippleY = event.clientY.toString() + "px";
    });
  });

  function Ripple() {
    if (hasClicked) {
      return;
    }

    var rippleLocation = document.getElementById("ripple-location");
    //@ts-ignore
    rippleLocation.style.left = rippleX;
    //@ts-ignore
    rippleLocation.style.top = rippleY;

    for (var i = 0; i < totalRipples; i++) {
      var ripple = document.createElement("div");
      ripple.classList.add("ripple");
      ripple.classList.add(ripples[i]);
      ripple.style.position = "fixed";
      ripple.style.left = rippleX;
      ripple.style.top = rippleY;
      ripple.style.transitionDelay = (0.2 * (i + 1)).toString() + "s";
      ripple.style.aspectRatio = " 1 / 1";
      rippleLocation?.appendChild(ripple);
      void ripple.offsetWidth;
      ripple.classList.add("ripple-expand");

      ripple.addEventListener("transitionend", () => {
        ripple.remove();
      });
    }
    hasClicked = true;
    //@ts-ignore
    document.getElementsById("blackout").style.opacity = "0";
  }
</script>

<body>
  <!--<div id="blackout" on:click={() => Ripple()}>
    <div id="ripple-location"></div>
  </div>-->
  <div id="main">
    <div id="banner">
      <div id="banner-text">
        <h1>Toby Looijkens</h1>
        <p>3D Modelling | Programming</p>
      </div>
    </div>
    <div id="works">
      <div id="selectbar">
        <h3 id="personal-works">Personal works</h3>
        <h3 id="advertisements"></h3>
        <h3 id="architecture"></h3>
      </div>
      <div id="projects">
        <Gallerycard></Gallerycard>
      </div>
      <h3 id="see-more">-- See more --</h3>
    </div>
    <div id="hiring"></div>
  </div>
</body>

<style>
  @import url("https://fonts.googleapis.com/css2?family=Playwrite+CU:wght@100..400&display=swap");
  @import url("https://fonts.googleapis.com/css2?family=PT+Sans:ital,wght@0,400;0,700;1,400;1,700&display=swap");
  @import url("https://fonts.googleapis.com/css2?family=Cinzel:wght@400..900&display=swap");

  #main {
    margin: 0px;
  }

  #blackout {
    margin-top: -70px;
    position: fixed;
    width: 100%;
    height: 100%;
    visibility: visible;
    background-color: rgba(15, 15, 15, 0.8);
  }

  :global(.small-ripple) {
    background-image: url(../img/Water-Small-Ripple.svg);
  }

  :global(.big-ripple) {
    background-image: url(../img/Water-Ripple.svg);
  }

  #ripple-location {
    position: fixed;
    width: 5%;
    height: 5%;
    left: -2.5%;
    top: -2.5%;
  }

  :global(.ripple) {
    background-size: cover;
    position: fixed;
    width: 4%;
    transform: translate(-50%, -50%) scale(0);
    aspect-ratio: 1 /1;
    transition: 1s;
    transform-origin: center;
    transition-timing-function: cubic-bezier(0.27, 0.56, 0.78, 0.63);
  }

  :global(.ripple-expand) {
    transform: translate(-50%, -50%) scale(5);
    opacity: 0%;
  }

  #banner {
    display: flex;
    align-items: center;
    min-width: 320px;
    max-height: 750px;
    height: 82vh;
    background-color: rgb(136, 175, 220);
  }

  #banner-text {
    margin-left: auto;
    margin-right: auto;
    font-family: "PT Sans", sans-serif;
    font-weight: 400;
    font-style: normal;
    text-align: center;
  }

  #works {
    min-width: 320px;
    background-color: rgb(20, 20, 25);
  }

  #selectbar {
    display: flex;
    margin-left: auto;
    margin-right: auto;
    text-align: center;
  }

  #projects {
    display: flex;
    justify-content: center;
    margin-bottom: 10px;
  }

  #see-more {
    margin: 0px;
    padding-bottom: 10px;
    padding-top: 5px;
  }

  #hiring {
    /*background-image: url(../img/Render.png);*/
    background-color: red;
    height: 500px;
    min-width: 320px;
  }

  h1 {
    margin: 0%;
    margin-top: 20px;
    font-size: 35px;
    color: rgb(240, 240, 240);
    font-family: "Cinzel", serif;
    font-weight: 700;
    font-style: normal;
  }

  h3 {
    text-align: center;
    font-family: "Playfair Display", serif;
    font-optical-sizing: auto;
    font-weight: 500;
    font-style: normal;
    color: #e6e6ea;
  }

  h3:hover {
    font-weight: 700;
  }

  p {
    margin-top: 0px;
    color: white;
    font-family: "PT Sans", sans-serif;
    font-weight: 400;
    font-style: normal;
  }

  @media only screen and (min-width: 560px) {
    h1 {
      margin: 0%;
      margin-top: 20px;
      font-size: 50px;
      color: rgb(240, 240, 240);
      font-family: "Cinzel", serif;
      font-weight: 700;
      font-style: normal;
    }
  }

  @media only screen and (min-width: 360px) and (max-width: 560px) {
    h1 {
      margin: 0%;
      margin-top: 20px;
      font-size: 40px;
      color: rgb(240, 240, 240);
      font-family: "Cinzel", serif;
      font-weight: 700;
      font-style: normal;
    }
  }
</style>
