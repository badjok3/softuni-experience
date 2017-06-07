function solve(args) {
    let number = args[0];

    function cook(number) {
        for (let i = 1; i < args.length; i++) {
            let op = args[i];

            switch (op) {
                case 'chop':
                    number /= 2;
                    break;
                case 'dice':
                    number = Math.sqrt(number);
                    break;
                case 'spice':
                    number++;
                    break;
                case 'bake':
                    number *= 3;
                    break;
                case 'fillet':
                    number -= number * 0.2;
                    break;
            }

            console.log(number);
        }
    }

    cook(number)
}