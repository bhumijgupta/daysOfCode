const chai = require("chai");
const expect = chai.expect;

describe("ïndex", ()=>{
    it("data type syntax",()=>{
        expect("3").to.be.a("string");
    });
    it("null and undefined", ()=>{
        expect(null).to.be.null;
        expect(undefined).to.not.exist;
    });
})
