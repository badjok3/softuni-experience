function solve(args) {
    console.log('<?xml version="1.0" encoding="UTF-8"?>');
    console.log('<quiz>');

    for(let i = 0; i < args.length; i+=2) {
        let question = args[i];
        let answer = args[i + 1];

    console.log('  <question>');
    console.log(`   ${question}`);
    console.log('  </question>');
    console.log('  <answer>');
    console.log(`   ${answer}`);
    console.log('  </answer>');
    }

    console.log('</quiz>');
}