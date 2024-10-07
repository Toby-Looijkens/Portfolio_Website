<script>
</script>

<div id="card">
  <div id="titlecard">
    <h4></h4>
    <p></p>
  </div>
</div>

<style>
  #card {
    min-width: 150px;
    min-height: 150px;
    max-width: 250px;
    max-height: 250px;
    background-image: url(../img/Render.png);
    border-radius: 5px;
    background-position: center;
    aspect-ratio: 1 / 1;
    margin: 3px;
    overflow-x: hidden;
    cursor: pointer;
  }

  #titlecard {
    width: 100%;
    height: 30%;
    margin-top: 70%;
    margin-left: -100%;
    border-radius: 0px 0px 5px 5px;
    background-color: rgba(10, 10, 10, 0.65);
    transition: 0.2s;
  }

  #card:hover #titlecard {
    transition-delay: 0.4s;
    margin-left: 0%;
  }

  h4 {
    margin: 0;
  }

  p {
    margin: 0;
  }
</style>
