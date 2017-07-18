let expect = require('chai').expect;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

document.body.innerHTML = `<body>
    <div id="wrapper">
    <input type="text" id="name">
    <input type="text" id="income">
    </div>
</body>`;

let sharedObject = {
    name: null,
    income: null,
    changeName: function (name) {
        if (name.length === 0) {
            return;
        }
        this.name = name;
        let newName = $('#name');
        newName.val(this.name);
    },
    changeIncome: function (income) {
        if (!Number.isInteger(income) || income <= 0) {
            return;
        }
        this.income = income;
        let newIncome = $('#income');
        newIncome.val(this.income);
    },
    updateName: function () {
        let newName = $('#name').val();
        if (newName.length === 0) {
            return;
        }
        this.name = newName;
    },
    updateIncome: function () {
        let newIncome = $('#income').val();
        if (isNaN(newIncome) || !Number.isInteger(Number(newIncome)) || Number(newIncome) <= 0) {
            return;
        }
        this.income = Number(newIncome);
    }
};

describe('sharedObject', function () {
    describe('inital variables', function () {
        it('initial value should be null', function () {
            expect(sharedObject.name).to.be.equal(null);
            expect(sharedObject.income).to.be.equal(null);
        });
    });
    describe('changeName', function () {
        it('should return null for empty parameter', function () {
            sharedObject.changeName('');
            let nameTxtVal = $('#name');
            expect(nameTxtVal.val()).to.be.equal('');
        });
        it('should return a valid new name for valid parameter', function () {
            sharedObject.changeName('Artyom');
            let nameTxtVal = $('#name');
            expect(nameTxtVal.val()).to.be.equal('Artyom');
        });
    });
    describe('changeIncome', function () {
        it('should return null for string parameter', function () {
            sharedObject.changeIncome('some');
            expect(sharedObject.income).to.be.equal(null);
        });
        it('shouldn\'t change for negative number parameter', function () {
            sharedObject.changeIncome(5);
            sharedObject.changeIncome(-4);
            expect(sharedObject.income).to.be.equal(5);
        });
        it('shouldn\'t change for floating point parameter', function () {
            sharedObject.changeIncome(5);
            sharedObject.changeIncome(4.11);
            expect(sharedObject.income).to.be.equal(5);
        });
        it('should return null for zero parameter', function () {
            sharedObject.changeIncome(10);
            sharedObject.changeIncome(0);
            expect(sharedObject.income).to.be.equal(10);
        });
        it('should return a valid new income for valid parameter', function () {
            sharedObject.changeIncome(535);
            expect(sharedObject.income).to.be.equal(535);
        });
    });
    describe('updateName', function () {
        it('no changes should be made for empty string parameter', function () {
            sharedObject.changeName('Viktor');
            let nameEl = $('#name');
            nameEl.val('');
            sharedObject.updateName();
            expect(sharedObject.name).to.be.equal('Viktor');
        });
        it('should update the name for valid parameters', function () {
            sharedObject.changeName('Viktor');
            let nameEl = $('#name');
            nameEl.val('Zdravko');
            sharedObject.updateName();
            expect(sharedObject.name).to.be.equal('Zdravko');
        });
    });
    describe('updateIncome', function () {
       it('no changes should be made for invalid parameter', function () {
           sharedObject.changeIncome(5);
           let incomeEl = $('#income');
           incomeEl.val('get some');
           sharedObject.updateIncome();
           expect(sharedObject.income).to.be.equal(5);
       });
       it('no changes should be made for negative parameter', function () {
           sharedObject.changeIncome(3);
           let incomeEl = $('#income');
           incomeEl.val(-3);
           sharedObject.updateIncome();
           expect(sharedObject.income).to.be.equal(3);
       });
        it('no changes should be made for zero parameter', function () {
            sharedObject.changeIncome(35);
            let incomeEl = $('#income');
            incomeEl.val(0);
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(35);
        });
       it('no changes should be made for floating point parameter', function () {
           sharedObject.changeIncome(54);
           let incomeEl = $('#income');
           incomeEl.val(3.99);
           sharedObject.updateIncome();
           expect(sharedObject.income).to.be.equal(54);
       });
       it('should change income for valid parameter', function () {
          sharedObject.changeIncome(54);
          let incomeEl = $('#income');
          incomeEl.val(76);
          sharedObject.updateIncome();
          expect(sharedObject.income).to.be.equal(76);
       });
    });
});