const chai = require("chai");
const expect = chai.expect;

describe("nested file",()=>{
    it("nested pending test");
    it("testing environment",()=>{
        console.log("ENV:" , process.env.NODE_ENV);
        if(process.env.NODE_ENV === "development"){
            console.log("Inside development env");
        }
    })
})