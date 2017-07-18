function readyTheCrew(worker) {
    if(!worker.handsShaking) {
        return worker;
    }
    worker.bloodAlcoholLevel += (0.1 * worker.experience) * worker.weight;
    worker.handsShaking = false;
    return worker;
}

console.log(readyTheCrew({ weight: 95,
    experience: 3,
    bloodAlcoholLevel: 0,
    handsShaking: false }
));