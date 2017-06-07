function escape(args) {
    console.log('<ul>');
    for (let i = 0; i < args.length; i++) {
        let line = args[i];
        console.log(`    <li>${line.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;')
            }</li>`);

    }
    console.log('</ul>');
}