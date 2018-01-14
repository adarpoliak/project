var select = document.getElementById("color-select");

document.addEventListener("DOMContentLoaded",function () {
    document.getElementById("color-select").onchange(function () {
        var productColor = document.getElementById("color-select").index(document.getElementById("color-select").selectedIndex).id;

        document.getElementByClassName("active").classList.remove("active");
        document.getElementById(productColor).classList.add("active");
        this.classList.add("active");
    });
},
function () {
    for (var i = 0; i < select.options.length; i++)
    {
    if(document.getElementById("color-select")[i].text == "" || document.getElementById("color-select")[i].text == " ")
        document.getElementById("color-select")[i].style.visibility = "hidden";
    } 
});



