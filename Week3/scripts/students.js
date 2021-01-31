const students = '{ "students": [ \
    {"id": 918244474, "email": "jordan.clark@oit.edu"}, \
    {"id": 918123456, "email": "test.student@oit.edu"}, \
    {"id": 918555555, "email": "second.test@oit.edu"} ] }'

function get_students()
{
    return JSON.parse(students).students
}

function init_students()
{
    const student_arr = get_students()

    display_students(student_arr)
}

function display_students(student_arr)
{
    var table_rows = ""
    const heading = ' \
    <tr> \
        <th class="heading">Student ID</th> \
        <th class="heading">Email Address</th> \
    </tr>'
    table_rows += heading
    for (i = 0; i < student_arr.length; i++)
    {
        const id = student_arr[i].id
        const email = student_arr[i].email
        table_rows += "<tr><td>" + id + "</td><td>" + email + "</td></tr>"
        document.getElementById("student-table").innerHTML = table_rows
    }
}