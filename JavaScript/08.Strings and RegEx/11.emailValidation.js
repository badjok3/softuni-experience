function validateEmail(email) {
    let regex = /^[A-Za-z0-9]+@[a-z]+\.[a-z]+?/g;
    if (email.match(regex)) {
        return 'Valid';
    }
    return 'Invalid';
}