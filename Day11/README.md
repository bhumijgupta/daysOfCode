# Docker networks

**Note**: Do not use IP address to communicate between containers.

By default a new bridged network will have DNS setup. The hostnames will be container names by default. However, the default bridged network doesnot have DNS setup.  

## Pinging container in same network

```bash
docker container exec -it mynginx ping new_nginx
```
Note - nginx doesnot have ping instlled by default. To install ping
```bash
apt-get update
apt-get install iputils-ping
```

## `--rm` flag

`--rm` can be used to remove container and its files once the container exists

```bash
docker container run -it --name auto_delete --rm nginx
```