# Docker alias
By default, the dns name of the container is same to it's container name. But we can configure multiplr servers to respond to same alias name using `--net-alias` command.<br>

```bash
# create new network
docker network create dns_alias

docker container run -d --net dns_alias --net-alias search elasticsearch 
docker container run -d --net dns_alias --net-alias search elasticsearch
```