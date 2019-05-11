# Docker

**Image** - Instance we want to run<br>
**Container** - Instance of image running as a process<br>

## Basic Commands

* Running a container
```docker
docker container run --publish <port on local>:<port of container> --detach --name <name of container> <name of image>
```
`-detach` or `-d` runs container in background<br>
`--name` is optional

* List running container
```docker
docker container ls
```
`-a` list all (running + stopped) container

* Stop running container
```docker
docker container stop <containerID>
```

* Remove all stopped container
```docker
docker container prune
```
To remove specific container use,
```docker
docker container rm -f <containerID>
```
`-f` denotes force remove

* View logs of detached container
```docker
docker container logs <name of container>
```
