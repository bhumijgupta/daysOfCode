const express = require("express");
const app = express();
const puppeteer = require("puppeteer");
const bodyParser = require("body-parser");
const fs = require("fs");
const helmet = require("helmet");

app.use(helmet());
app.set("view-engine", "ejs");

app.use(bodyParser.urlencoded({
    extended: true
}));

// To download file
app.get("/get/:id", (req, res) => {
    res.set("Content-Type", "application/pdf");
    // res.set("Content-Disposition", "attachment; filename=bhumij.pdf")
    res.sendFile("/page.pdf", {
        root: __dirname
    });
    // res.download("./page.pdf", `id.pdf`);
});

// POST route to form also scraping
app.post("/create", (req, res) => {
    let name = req.body.name;
    if (name == null) {
        res.status(400);
        res.send("Name cannot be empty");
    } else {
        name = name.split(" ").join("-");
        startScrape(name);

        res.status(200);
        res.send(name);
    }
});

// Generates badges
app.get("/create/:name", (req, res) => {
    let name = req.params.name;
    name = name.split("-").join(" ");
    res.render("template.ejs", {
        name: name
    });
});

app.listen(3000, () => {
    console.log("Server listening on port 3000");
});

var startScrape = async (name) => {
    const browser = await puppeteer.launch();
    const page = await browser.newPage();
    await page.goto(`http://localhost:3000/create/${name}`);
    await page.setViewport({
        width: 297,
        height: 210,
        isLandscape: true
    })
    await page.pdf({
        width: '297mm',
        height: '210mm',
        path: './page.pdf',
        headerTemplate: '<span class="title"></span>'
    });

    await browser.close();
};