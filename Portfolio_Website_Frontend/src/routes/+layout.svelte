<script>
  import Header from "$lib/header.svelte";
  import Footer from "$lib/footer.svelte";
  import Linkbar from "$lib/linkbar.svelte";
</script>

<header>
  <Header></Header>
</header>
<slot></slot>
<footer>
  <Footer></Footer>
</footer>

<style>
</style>
