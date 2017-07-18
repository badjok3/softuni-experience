function getModel() {
    let input1, input2, result;

    function init(num1Sel, num2Sel, resultSel) {
        input1 = $(num1Sel);
        input2 = $(num2Sel);
        result = $(resultSel);
    }

    function add() {
        result.val(+input1.val() + +input2.val());
    }

    function subtract() {
        result.val(+input1.val() - +input2.val());
    }

    return {
        init,
        add,
        subtract
    };
}