// 1. Area of triangle

function FindArea(b,h){
    console.log(0.5*h*b);
}

FindArea(7,3);

// 2. Triangle pattern

for (let i = 1; i <= 5; i++){
    let p = "";
    for (let j = 0; j < i; j++){
        p += "* ";        
    }
    console.log(p);
}

// 3. Check Leap year

function IsLeapYear(year){
    if ((year%4 == 0 && year % 100 != 0) || year % 400 == 0 ){
        console.log("leap year");
    }
    else{
        console.log("Not a leap year");
    }
}

IsLeapYear(1900);

// 4. Independence day calculator

function daysUntilIndependenceDay() {
    let today = new Date();
    let year = today.getFullYear();

    let independenceDay = new Date(year, 7, 15);

    if (today > independenceDay) {
        independenceDay = new Date(year + 1, 7, 15);
    }

    let diff = independenceDay - today;
    let daysLeft = Math.ceil(diff / (1000 * 60 * 60 * 24));
    console.log(daysLeft + " days left until Independence Day");
}

daysUntilIndependenceDay();