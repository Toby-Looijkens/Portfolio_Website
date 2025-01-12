<script>
  import { onMount } from "svelte";
  export let data;

  onMount(async () => {
    const url = "http://localhost:27777/api/GalleryManager/GetAllGalleryItems";
    const res = await fetch(url);
    console.log(res);
    const product = await res.json();
    return { props: { data } };
  });
</script>

<body>
  <h1>Gallery {data}</h1>
</body>

<style>
  body {
    background-color: rgb(20, 20, 25);
    border-top: solid 2px white;
  }
</style>
