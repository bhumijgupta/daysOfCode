const puppeteer = require("puppeteer");

let run = async () => {
    const browser = await puppeteer.launch({
        headless: false,
        slowMo: 500,
        devtools: true
    });
    const page = await browser.newPage();
    await page.goto('https://www.google.com');
    await page.screenshot({
        path: "github.png"
    });
    await page.pdf({
        path: 'github.pdf',
        format: 'A4'
    });

    await browser.close();
};

run();