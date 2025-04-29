<script setup lang="ts">
import MainTable from '@/components/MainTable.vue';
import { ref } from 'vue';
const value = ref('')
</script>

<template>
  <div class="p-4">
    <UInput v-model="value" placeholder="Enter stock ticket"></UInput>
  </div>
  <MainTable></MainTable>
</template>
