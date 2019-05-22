# Instructions
1. Enable sudo environment and navigate to sites-available directory
```bash
sudo su
cd /etc/apache2/sites-available
```
2. Create new **`<site name>`.conf** file for apache2. Copy template from **000-default.conf**
```bash
# Here site name is mysite.blah
cp 000-default.conf newsite.blah.conf
```

3. Edit **`<site name>`.conf**
``` bash
vim newssite.blah.conf
```
**Tip**: To edit the file press `i`<br>
To save the changes press `Esc` + `:wq`
```apacheconf
ServerAdmin webmaster@mysite.blah       # website@sitename.domain
ServerName mysite.blah                  # sitename.domain
ServerAlias www.mysite.blah             # www.sitename.domain
DocumentRoot /home/tatech/Desktop/php   # root directory, where website files are present
```

4. If your Document root is outside `/var/www` then give permission to apache2 to read the files in the directory.
```bash
vim /etc/apache2/apache2.conf
```
```apacheconf
<Directory /home/tatech/Desktop/php/>
        Options Indexes FollowSymLinks
        AllowOverride All
        Require all granted
</Directory>
```

5. Enable configuration files
```bash
a2dissite 000-default.conf
a2enssite mysite.blah.conf
```

6. Restart apache2 server
```bash
systemctl apache2 restart
```

7. Add host to hosts file
```bash
vim /etc/hosts
```
```bash
[...]
127.0.0.1       mysite.blah
[...]
```

8. Go to **mysite.blah** in your browser of choice