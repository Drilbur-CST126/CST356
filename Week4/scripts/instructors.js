const instructors = '{ "instructors": [ \
    {"first": "Gerald", "middle": "N/A", "last": "Aden"}, \
    {"first": "Peter", "middle": "N/A", "last": "Meyers"}, \
    {"first": "Paula", "middle": "N/A", "last": "Hannan"} ] }'

function get_instructors()
{
    return JSON.parse(instructors).instructors
}

function init_instructors()
{
    if (document.getElementById("instructor-table") != null)
    {
        const instructor_arr = get_instructors()
    
        display_instructors(instructor_arr)
    }
}

function display_instructors(instructor_arr)
{
    var table_rows = ""
    const heading = ' \
    <tr> \
        <th class="heading">First Name</th> \
        <th class="heading">Middle Initial</th> \
        <th class="heading">Last Name</th> \
    </tr>'
    table_rows += heading
    for (i = 0; i < instructor_arr.length; i++)
    {
        const first = instructor_arr[i].first
        const middle = instructor_arr[i].middle
        const last = instructor_arr[i].last
        table_rows += "<tr><td>" + first + "</td><td>" + middle + "</td><td>" + last + "</td></tr>"
        document.getElementById("instructor-table").innerHTML = table_rows
    }
}

init_instructors()