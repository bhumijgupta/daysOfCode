## Practises
Create `<filename>.test.js` in the same directory as file name

## npm test
To use npm test to test all files, replace the test command in `package.json`

```json
"scripts": {
    "test": "mocha './**/*.test.js'"
  }
```

## Setting NODE_ENV
To set node_env

1. Install cross-env

```bash
npm i cross-env --save
```

2. Set environment in npm test

```json
"scripts": {
    "test": "cross-env NODE_ENV=development mocha './**/*.test.js'"
  }
```

To test NODE_ENV, use `process.env.NODE_ENV`