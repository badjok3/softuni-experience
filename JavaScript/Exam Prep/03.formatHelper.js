function format(text) {
    text = text[0].replace(/[ ]*([.,!?:;])[ ]*/g, (match, grp1) => `${grp1} `)
        .replace(/\. (?=[0-9])/g, '.')
        .replace(/" *(.+?) *"/g, (match, grp1) => `"${grp1}"`)
        .replace(/([.,!?:;]) (?=[.,!?:;])/g, (match, grp1) => grp1 );

    return text;
}

console.log(format(['Terribly formatted text      .  With chaotic spacings." Terrible quoting   "! Also this date is pretty confusing : 20   .   12.  16 .']));