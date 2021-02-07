function init()
{
    if (document.getElementById("username-err") != null)
    {
        const username_err = document.getElementById("username-err")
        const password_err = document.getElementById("password-err")
        username_err.style.visibility = "hidden"
        password_err.style.visibility = "hidden"
    }
}

function validate()
{
    const username_err = document.getElementById("username-err")
    const password_err = document.getElementById("password-err")
    username_err.style.visibility = "hidden"
    password_err.style.visibility = "hidden"

    const username = document.getElementById("username").value
    const password = document.getElementById("password").value

    console.debug("Username == " + username)
    
    if (username == '')
    {
        username_err.style.visibility = "visible"
    }
    
    if (password == '')
    {
        password_err.style.visibility = "visible"
    }

    // Storing password in plaintext because I don't know how to hash in JS; I would not do in real code
    document.cookie = `username=${username}; password=${password}; expires=31 Dec 2024 12:00:00 UTC; path=/`;
}

init()