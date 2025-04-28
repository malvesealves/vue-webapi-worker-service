import { describe, it, expect } from 'vitest'

import { mount } from '@vue/test-utils'
import NavigationMenu from '../NavigationMenu.vue'

describe('HelloWorld', () => {
  it('renders properly', () => {
    const wrapper = mount(NavigationMenu, { props: { msg: 'Welcome to HomePage' } })
    expect(wrapper.text()).toContain('Welcome to HomePage')
  })
})
