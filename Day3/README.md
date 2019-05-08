### Install mochajs
```bash
npm i mocha -g
```

### Require assert (won't be using)
This is the built in assert library in node
```javascript
const assert = require("assert");
```

### Basic Syntax
```javascript
describe("file to be tested", () => {
    context("function to be tested", () => {
        it("test goes here", () => {
            assert.equal(1, 2);
        });
        it("should do something else", () => {
            // Comparing objects
            assert.deepEqual({
                name: "Rahul"
            }, {
                name: "Rahul"
            })
        });

        // Pending test
        it("is a pending test");
    })
})
```

### Run test 
```javascript 
mocha test.js
```

### Before and after
Runs these before and after running the tests
```javascript
describe("file to be tested", () => {
    context("function to be tested", () => {
        before(() => {
            console.log("=====before");
        });

        after(() => {
            console.log("=====after");
        });

        it("test goes here", () => {
            assert.equal(1, 1);
        });
    });
});
```

### BeforeEach and afterEach
These are run before and after each test<br>
**NOTE** These test don't run for pending tests.
``` javascript
describe("file to be tested", () => {
    context("function to be tested", () => {
        beforeEach(() => {
            console.log("-----beforEach");
        });

        afterEach(() => {
            console.log("-----afterEach");
        });

        it("test goes here", () => {
            assert.equal(1, 1);
        });
        it("is a pending test");
    })
})
```

### Setup Chai.js
This is advanced assert library for node.js
```bash
npm i chai --save-dev
```
### Basic Example
```javascript
const chai = require("chai");
const expect = chai.expect;

describe("chai test", () => {
    context("function name", () => {
        it("should compare values", () => {
            expect(1).to.equal(1);
        })
        it("test basic syntax", () => {
            expect({
                name: "foo"
            }).to.deep.equal({
                name: "foo"
            });
            expect({
                name: "foo"
            }).to.have.property("name").to.equal("foo");
            expect(5 > 8).to.be.false;
            expect({}).to.be.a("object");
            expect("foo").to.be.a("string");
            expect(3).to.be.a("number");
            expect("bar").to.be.a("string").with.lengthOf(3);
            expect([1, 2, 3, 4].length).to.equal(4);
            expect(null).to.be.null;
            expect(undefined).to.not.exist;
            expect(1).to.exist;
        })
    })
})
```