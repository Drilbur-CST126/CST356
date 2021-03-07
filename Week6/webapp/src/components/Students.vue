<template>
    <div>
        <head>
            <title>Student Page</title>
            
            <!-- inject:css -->
            <!-- endinject -->
        </head>

        <body>
            <table id="student-table">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Email</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="student in students" v-bind:key="student">
                        <td>{{ student.id }}</td>
                        <td>{{ student.email }}</td>
                    </tr>
                </tbody>
            </table>
            
            <!-- inject:js -->
            <!-- endinject -->
        </body>
    </div>
</template>

<script>
    export default {
        name: 'Home',
        mounted() {
            this.students = getStudents();
        },
        data() {
            return {
                students: []
            }
        }
    }

    function getStudents()
    {
        return JSON.parse(students)
    }

    var students = '[ \
    {"id": 918244474, "email": "jordan.clark@oit.edu"}, \
    {"id": 918123456, "email": "test.student@oit.edu"}, \
    {"id": 918555555, "email": "second.test@oit.edu"} ]'
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