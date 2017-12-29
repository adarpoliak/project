function OnLoad() {
        toggelClass("Li3");
        toggelClass("LogOut");
        toggelClass("Li2");

}

function toggelClass(name) {
    if (document.getElementById(name).classList.contains("loged-in")) {
        document.getElementById(name).classList.remove("loged-in");
        document.getElementById(name).classList.add("loged-out");
    }
    else if (document.getElementById(name).classList.contains("loged-out")) {
        document.getElementById(name).classList.remove("loged-out");
        document.getElementById(name).classList.add("loged-in");
    }
}
