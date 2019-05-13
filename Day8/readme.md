## Checking if the window is opened in incognito
File system is disabled in incognito mode. The status of the window can be guessed by tring to access file system.
```javascript
let fs = window.webkitRequestFileSystem || window.RequestFileSystem
fs(window.TEMPORARY, 100, () => {
    console.log("Not in incognito")
}, () => {
    console.log("In incognito")
});
```
`window.TEMPORARY` tells that the browser can automatically delete files if storage runs out<br>
`100` is the size of storage to be allocated<br>
Link: https://developer.mozilla.org/en-US/docs/Web/API/Window/requestFileSystem
