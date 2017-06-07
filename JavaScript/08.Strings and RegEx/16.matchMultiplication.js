function matchMutiplication(bill) {
    function repl(match, p1, p2) {
        return p1 * p2;
    }

    bill = bill.replace(/(-?\d+)\s*\*\s*(-?\d*\.\d*)/g, repl);
    return bill;
}