<template>
  <div class="col md-12">
<tree :data="data" :node-text="name" :type="tree" style="max-width: 500px; max-height:500px"> 
</tree></div>
</template>

<script>
import {tree} from 'vued3tree'

export default {
  components: {
    tree
  },
  data() {
    return {data:null}
  },
  created(){
    fetch('https://localhost:44319/api/app/tree/tree')
  .then(response => response.json())
  .then(data => this.data=data);

  }
}
    </script>