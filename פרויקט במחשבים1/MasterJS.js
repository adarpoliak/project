function Open_Menu() {
    if (document.getElementById("mainNav").classList.contains("open"))
        document.getElementById("mainNav").classList.remove("open");
    else
        document.getElementById("mainNav").classList.add("open");
    
}

function Close() {
    document.getElementById("pop").classList.add("hide");
    document.getElementById("pop").classList.remove("show");
}

function Show() {
    document.getElementById("pop").classList.add("show");
    document.getElementById("pop").classList.remove("hide");
}
