document.getElementById("leap_year").addEventListener("click", function() {
    const year = parseInt(document.getElementById("userinput").value);
    const results = leap_year(year);
    document.getElementById("result").innerText = results;
});




function leap_year(year) {
    if (year % 4 == 0) {
        if (year % 100 == 0) {
            if (year % 400 == 0) {
                return(`${year} is a leap year`);
            } 
            else {
                return(`${year} is not a leap year`);
            }
        } 
        else {
            return(`${year} is a leap year`);
        }
    } 
    else {
        return(`${year} is not a leap year`);
    }
}

