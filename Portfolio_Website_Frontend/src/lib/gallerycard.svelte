<script>
</script>

<div id="card">
  <div id="titlecard">
    <h4>Test</h4>
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
    overflow-y: hidden;
    cursor: pointer;
  }

  #titlecard {
    width: 100%;
    height: 30%;
    margin-top: 100%;
    border-radius: 0px 0px 5px 5px;
    background: linear-gradient(
      360deg,
      rgba(10, 10, 10, 0.65) 0%,
      rgba(0, 0, 0, 0.1) 85%,
      rgba(0, 0, 0, 0) 100%
    );
    transition: 0.5s;
    transition-timing-function: cubic-bezier(0.27, 0.56, 0.31, 0.84);
  }

  h4 {
    color: white;
    padding-left: 3%;
    padding-top: 5%;
  }

  #card:hover #titlecard {
    transition-delay: 0.1s;
    margin-top: 70%;
  }

  h4 {
    margin: 0;
  }

  p {
    margin: 0;
  }
</style>
