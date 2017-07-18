function personalBMI(name, age, kgWeight, cmHeight) {
    let person = {
        name: name,
        personalInfo: {
            age: age,
            weight: kgWeight,
            height: cmHeight
        }
    };
    let bmi = calculateBMI(kgWeight, cmHeight);
    let status;
    if(bmi < 18.5) {
        status = 'underweight';
    } else if (bmi < 25) {
        status = 'normal';

    } else if (bmi < 30) {
        status = 'overweight';
    } else {
        status = 'obese';
    }
    person.BMI = bmi;
    person.status = status;
    if(status === 'obese') {
        person.recommendation = 'admission required'
    }

    return person;

    function calculateBMI(mass, height) {
        return Math.round(mass / Math.pow(height / 100, 2));
    }
}

let chart = personalBMI('Peter', 9, 57, 137);
console.log(chart);