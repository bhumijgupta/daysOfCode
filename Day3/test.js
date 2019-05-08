const assert = require("assert");

describe("file to be tested", () => {
    context("function to be tested", () => {
        // before(() => {
        //     console.log("=====before");
        // });

        // after(() => {
        //     console.log("=====after");
        // });

        // beforeEach(() => {
        //     console.log("-----beforEach");
        // });

        // afterEach(() => {
        //     console.log("-----afterEach");
        // });

        it("test goes here", () => {
            assert.equal(1, 1);
        });
        it("should do something else", () => {
            assert.deepEqual({
                name: "Rahul"
            }, {
                name: "Rahul"
            })
        });
        it("is a pending test");
    })
    context("Another function", () => {
        it("should do something else", () => {
            assert.equal(2, 2);
        });
    });
})