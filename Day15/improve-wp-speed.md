# Increasing Wordpress Website Speed

1. **Remove unnecessary plugins and pages**
2. **Use updated plugins**
3. **Optimize Database**<br>
Wordpress database can be optimized using **WP-Sweep** Plugin. It removes all the unnecessary and temporary data from database and defragments tables.<br>
Alternate: WP-Optimize
4. **Reduce number of post revisions**<br>
We can reduce the number of post revisions wordpress saves by editiong `wp-config.php` file.
```php
// wp-config.php
define( 'WP_POST_REVISIONS', 4 );
```
5. **Compress Images**<br>
All the images can be compressed to reduce load time. One such way to compress images is using [TinyPNG](https://tinypng.com/) free service.

6. **Use CDN to deliver static resources**<br>
CDN can be used to deliver static resources faster. One such free service is **Site Accelerator** in photon plugin.<br>
In dashboard `Jetpack → Settings→ Performance`<br>
In the Performance & speed section, toggle on “Enable site accelerator.”

7. **Enable Lazy loading**<br>
Lazy loading priortizes loading resources in visible area first. **Lazy Load by WP Rocket** takes care of the lazy loading for the website.

8. **Using caching**<br>
Caching website can increase speed from 1.5x to 2x. But it should be done in the last to ensure maximum optimization. **WP Super Cache** plugin takes care of the caching for us.
