<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>NLayer Boilerplate</title>
</head>
<body>
    <div id="app">
        <ol>
            <person-item v-for="item in people" v-bind:person="item"></person-item>
        </ol>
    </div>
    @Scripts.Render("~/bundles/scripts")
</body>
</html>