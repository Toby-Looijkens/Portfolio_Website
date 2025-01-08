<script></script>

<nav>
  <div id="logo">
    <div id="logo-image"></div>
    <a id="logo-name" href="/">Toby Looijkens</a>
  </div>
  <div id="nav-items">
    <div id="nav-links">
      <a id="home" href="/">Home</a>
      <a id="gallery" href="/Gallery">Gallery</a>
      <a id="about">About</a>
    </div>
    <div id="nav-menu"></div>
  </div>
</nav>
<div id="navigation"></div>

<style>
  @import url("https://fonts.googleapis.com/css2?family=Playfair+Display:wght@500&display=swap");

  nav {
    display: flex;
    min-width: 320px;
    width: 100%;
    height: 70px;
    background-color: rgb(20, 20, 25);
  }

  #nav-items {
    display: flex;
    width: 20%;
    padding-left: 5px;
    justify-content: right;
  }

  #nav-menu {
    visibility: visible;
    width: 30px;
    height: 30px;
    margin-top: auto;
    margin-bottom: auto;
    margin-right: 10px;
    background-image: url(../img/menu_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24.svg);
    background-size: cover;
    color: white;
  }

  #nav-links {
    display: flex;
    position: fixed;
    margin: 0px;
    margin-top: 70px;
    justify-content: right;
  }

  a {
    visibility: hidden;
    width: 0px;
    margin-top: auto;
    margin-bottom: auto;
    margin: 0px;
    padding: 0px;
    padding-right: 10px;
    text-align: center;
    font-family: "Playfair Display", serif;
    font-optical-sizing: auto;
    font-weight: 500;
    font-style: normal;
    color: #e6e6ea;
    text-decoration: none;
  }

  a:hover {
    font-weight: 700;
  }

  #logo {
    display: flex;
    width: 80%;
    margin-left: 1%;
    text-align: left;
  }

  #logo-name {
    visibility: visible;
    width: 60%;
    margin-top: auto;
    margin-bottom: auto;
    margin-left: 5px;
    font-size: 20px;
    text-align: left;
  }

  #logo-image {
    height: 90%;
    margin-top: auto;
    margin-bottom: auto;
    background-image: url(../img/Logo.svg);
    background-size: cover;
    aspect-ratio: 1 /1;
  }

  @media only screen and (min-width: 360px) and (max-width: 560px) {
    #nav-items {
      margin: 0px;
      padding: 0px;
    }

    #logo-name {
      font-size: 25px;
    }
  }

  @media only screen and (min-width: 560px) {
    #nav-menu {
      visibility: hidden;
      position: fixed;
      margin-top: 70px;
    }
    #logo {
      width: 70%;
    }
    #nav-links {
      position: static;
      margin: 0px;
      margin-right: 20px;
      display: flex;
      justify-content: right;
    }
    a {
      margin-top: auto;
      margin-bottom: auto;
      padding-right: 10px;
      text-align: center;
      font-family: "Playfair Display", serif;
      font-optical-sizing: auto;
      font-weight: 500;
      font-style: normal;
      color: #e6e6ea;
      text-decoration: none;
    }

    #home {
      visibility: visible;
      width: 33%;
    }
    #gallery {
      visibility: visible;
      width: 33%;
    }
    #about {
      visibility: visible;
      width: 33%;
    }

    nav {
      display: flex;
      min-width: 360px;
      width: 100%;
      height: 70px;
      background-color: rgb(20, 20, 25);
    }

    #nav-items {
      display: flex;
      width: 30%;
      justify-content: right;
      padding-left: 5px;
    }

    a:hover {
      font-weight: 700;
    }
    #logo {
      width: 70%;
      text-align: left;
      display: flex;
    }
    #logo-name {
      font-size: 25px;
      width: 60%;
      text-align: left;
    }
    #logo-image {
      height: 90%;
      margin-top: auto;
      margin-bottom: auto;
      background-image: url(../img/Logo.svg);
      background-size: cover;
      aspect-ratio: 1 /1;
    }
  }
</style>
