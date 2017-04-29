Vue.component('todo-item', {
    props: ['person'],
    template: '<li>{{ person.name }}</li>'
})