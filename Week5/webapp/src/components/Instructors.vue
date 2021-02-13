<template>
    <div>
        <head>
            <title>Instructor Page</title>
        </head>

        <body>
            <table id="instructor-table">
                <thead>
                    <tr>
                        <th>First</th>
                        <th>Middle</th>
                        <th>Last</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="instructor in instructors" v-bind:key="instructor">
                        <td>{{ instructor.first }}</td>
                        <td>{{ instructor.middle }}</td>
                        <td>{{ instructor.last }}</td>
                    </tr>
                </tbody>
            </table>
        </body>
    </div>
</template>

<script>
export default 
    {
        name: 'Home',
        mounted() {
            this.instructors = getInstructors();
        },
        data() {
            return {
                instructors: []
            }
        }
    }

    function getInstructors()
    {
        return JSON.parse(instructors)
    }

    var instructors = '[ \
    {"first": "Gerald", "middle": "N/A", "last": "Aden"}, \
    {"first": "Peter", "middle": "N/A", "last": "Meyers"}, \
    {"first": "Paula", "middle": "N/A", "last": "Hannan"} ]'
</script>

<style scoped>
.heading
{
    background-color: cornflowerblue;
    color: white;
    font-size: large;
}

.err
{
    color: red;
}

#main-heading
{
    font-style: italic;
    text-decoration: underline;
    font-size: xx-large;
    color: darkblue;
}

p
{
    text-indent: 3%;
    color: darkslategray;
}

button
{
    font-size: x-large;
    font-style: oblique;
    padding: 1%;
}
</style>