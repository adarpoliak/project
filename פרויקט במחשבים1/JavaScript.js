function OnLoad() {
        toggelClass("Li3");
        toggelClass("Li2");
        toggelClass("Li1");
        toggelClass("Li4");
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

function ContainsClass(name, classname) {
    if (document.getElementById(name).classList.contains(classname)) {
        return true;
    }
    else {
        return false;
    }
}
