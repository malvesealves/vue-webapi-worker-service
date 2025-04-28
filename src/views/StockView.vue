<script setup lang="ts">
import MainTable from '@/components/MainTable.vue';
import { ref } from 'vue';
const value = ref('')
</script>

<template>
  <div>
    <UInput v-model="value" placeholder="Enter stock ticket"></UInput>
    <MainTable></MainTable>
  </div>
</template>
