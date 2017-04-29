var app = new Vue({
    el: '#app',
    data: {
        people: {}
    },
    created: function () {
        this.people = $.ajax("api/people").done(function (data) { console.log(data) })
    }
})