function fight(medenkas) {
    let naskorDmg = 0;
    let viktorDmg = 0;

    for(let i = 0; i < medenkas.length; i++) {
        let params = medenkas[i].split(' ');
        [amount, type] = params;
        let attacks = 1;

        for(let j = 0; j < amount; j++) {
            if (type === 'white') {
                if(attacks % 2 === 0) {
                    viktorDmg += 10*2.75;
                    attacks = 1;
                } else {
                    viktorDmg += 10;
                    attacks++;
                }
            } else {
                if (attacks % 5 === 0) {
                    naskorDmg += 60*4.5;
                    attacks++;
                } else {
                    naskorDmg += 60;
                    attacks++;
                }
            }
        }
        attacks = 1;
    }

    let result = '';
    if(viktorDmg > naskorDmg) {
        result += `Winner - Viktor\nDamage - ${viktorDmg}`;
    } else {
        result += `Winner - Naskor\nDamage - ${naskorDmg}`;
    }

    return result;
}

console.log(fight(['5 white medenkas',
    '5 dark medenkas',
    '4 white medenkas']));