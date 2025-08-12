<script>
  import { title } from "process";
  import { onMount } from "svelte";

  export let data;
  onMount(async () => {
    const url = "http://127.0.0.1:27777/api/GalleryManager/GetAllGalleryItems";
    const res = await fetch(url);
    data = await res.json();
    console.log(data);
    return data;
  });
</script>

<body>
  <h1>Gallery {data.title}</h1>
</body>

<style>
  body {
    background-color: rgb(20, 20, 25);
    border-top: solid 2px white;
  }
</style>
