# Docker Images
 
 ## Image History
 ```docker
 docker image history <image name>
 ```
 shows the  history of image layers. The image starts with blank layer called scratch.
 

 Every layer is identified by its unique SHA ID. Every change we make to the base layer using dockerfile or any other command is implemented in form of a new layer on top of base layer. 

 The advantage of having layers of changes are:-
 * If some image needs the same layer of any other image, it doesnot need to download the whole layer again but can utilise the same layer from the cache.
 * Saves time of downloading and uploading the image to the other size. As the same layers are not transferred again
 
 The base layer is a read-only layer. If we change anything in the base layer, the file is copied to the container layer and changed there. This is called **Copy on Write**

 ## Image Inspect
 ```docker
 docker image inspect <image name>
```
shows all the details of the image. It contains metadata on hoe the image is to be run and its configuration.