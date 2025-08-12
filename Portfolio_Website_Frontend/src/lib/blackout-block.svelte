<script>
  export function Shrink() {
    const block = document.getElementById("block");
    // @ts-ignore
    block.style.width = "0px";
    // @ts-ignore
    block.style.height = "0px";
  }
</script>

<div id="block"></div>

<style>
  #block {
    width: 100%;
    height: 100%;
    background-color: black;
    transition-duration: 0.2s;
    transition-timing-function: cubic-bezier(1, 0.3, 0.6, 0);
  }
</style>
