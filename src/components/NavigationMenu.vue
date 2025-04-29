<script setup lang="ts">
import type { BreadcrumbItem } from '@nuxt/ui'
import { ref } from 'vue';

const items = ref<BreadcrumbItem[]>([
  {
    label: 'Home',
    icon: 'i-lucide-house',
    to: '/'
  },
  {
    label: 'Stock',
    icon: 'i-lucide-trending-up',
    to: '/stock'
  }
])
</script>

<template>
  <div class="w-full">
    <UNavigationMenu color="neutral" variant="link" :items="items" />
    <USeparator />
  </div>
</template>
