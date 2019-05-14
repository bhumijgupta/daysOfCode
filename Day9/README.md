## Docker
Container are just processes running inside host VM.<br>

`docker top <name of container>` shows running processes inside the container.<br>
Since the containers are just processes, they can also be viewed using `ps aux`.<br><br>

`-e` can be used to set environment variables.

## Some useful commands
* `docker port <container_name>` : Displays open port in the container
* `docker container inspect` : Detail of how container started in JSON format
* `docker container stats` : Displays real time CPU and memory consumption of container

## Executing commands inside container
* `docker container run -it --name nginxServer nginx bash`<br>
`-it` refers interactive and TTY. TTY is similar to SSH.<br>
**Note** Container stops running after exiting CLI

* `docker container exec -it <container name> bash` : Runs bash inside container