# Docker Networks
* To know IP address of the container:
```docker
docker container inspect --format '{{ .NetworkSettings.IPAddress }}' <container name>
```
This IP address is not same as host IP.<br>
Conatiners on same virtual network can talk to each other without specifying any port using `-p` command. The default virtual network of docker is bridge/ docker0.

*  Viewing all networks<br>
`docker network ls`. The default network is bridge. **host** is a special network which skips through the virtual network and connects directly to the host. **none** is equivalent to a network card connected to no network.

* Inspecting a network<br>
`docker network inspect <network name>` reveals all the currently connected containers on the network.

* Creating a network<br>
`docker network create <network name>` will create a new network with default 'bridge' driver.

* Adding containers to network<br>
`docker container run --network <network name> -d nginx` starts nginx server in specified docker network.<br>
To add existing container: `docker network connect <network name> <container id>`.<br>
To remove existing container: `docker network disconnect <network name> <container id>`