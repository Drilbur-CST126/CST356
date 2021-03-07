<template>
  <div>
    <head>
        <title>Home Page</title>
        
        <!--removeIf(production)-->
        <link rel="stylesheet" type="text/css" href="styles/style.css">
        <!--endRemoveIf(production)-->
        
        <!-- inject:css -->
        <!-- endinject -->
    </head>

    <body>
        <h1 id="main-heading">MAIN HEADING:</h1>

        <div id="paragraph-1">
            <h3>First Subheading</h3>
            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos, quasi illum. Modi nulla dolorum dolor similique, quae illum. Modi, ipsam mollitia ad nulla incidunt sed commodi tempora quod voluptates itaque?</p>
        </div>

        <div id="paragraph-2">
            <h3>Second Subheading</h3>
            <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quae omnis quisquam, non labore officia numquam amet blanditiis? Eum, maxime? Necessitatibus in fuga suscipit inventore labore, maiores ipsam expedita totam eligendi!</p>
        </div>

        <div id="paragraph-3">
            <h3>Third Subheading</h3>
            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Illum sapiente odio possimus cupiditate laboriosam repellat, enim iure sunt. Eligendi nobis culpa perspiciatis possimus illo numquam necessitatibus porro qui aut et!</p>
        </div>

        <img src="../assets/Screenshot.png"/>

        <br />
        <button id="extra-thing">Useless Button</button>
    </body>
  </div>
</template>

<script>
export default {
  name: 'Home'
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
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
