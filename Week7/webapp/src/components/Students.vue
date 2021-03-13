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
                    <tr v-for="student in students" :key="student.studentId">
                        <td>{{ student.studentId }}</td>
                        <td>{{ student.emailAddress }}</td>
                    </tr>
                </tbody>
            </table>
            
            <!-- inject:js -->
            <!-- endinject -->
        </body>
    </div>
</template>

<script>
    import Vue from 'vue'

    export default {
        name: 'students',

        data() {
            return {
                students: [],
                operation: 'list',
                studentId: undefined,
                emailAddress: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },

        methods: {
            getStudents: function() {
                let url = `http://${this.apiServer}/student`;
                console.log(url);

                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            }
        },

        mounted() {
            this.getStudents();
            this.operation = 'list';
        }
    }
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