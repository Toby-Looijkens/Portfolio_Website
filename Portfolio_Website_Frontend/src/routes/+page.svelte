<script>
  import Gallerycard from "$lib/gallerycard.svelte";
</script>

<body>
  <div id="main">
    <div id="banner">
      <div id="banner-text">
        <h1>Toby Looijkens</h1>
        <p>3D Modelling | Animation | 3D concepts</p>
      </div>
    </div>
    <div id="works">
      <div id="selectbar">
        <h3 id="personal-works">Personal works</h3>
        <h3 id="advertisements">ad</h3>
        <h3 id="architecture">arch</h3>
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
