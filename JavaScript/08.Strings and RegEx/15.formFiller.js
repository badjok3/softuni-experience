function fillForm(username, email, phone, form) {

    function repl(match, p1) {
        switch (p1) {
            case '!': return username;
            case '@': return email;
            case '+': return phone;
        }
    }

    form.forEach(line => {
        line = line.replace(/<([!@+])[a-zA-Z]+[!@+]>/g, repl);

        console.log(line);
    });
}