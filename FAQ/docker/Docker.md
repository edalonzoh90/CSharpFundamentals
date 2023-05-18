**1. What is docker container?**
- Consist of applications and all their dependencies.
- They share the kernel and system resources with other containers and run as isolated systems in the host operating system.
- It's a running image
  
**2. What are docker images?**  
They are executable packages for the purpose of creating containers.

**3. What is a DockerFile?**  
It is a text file that has all commands needed to run for building a image.

**4. What is the docker command that lists the status of all docker containers?**  
docker ps -a


**5. What is docker image registry?**   
It's an area where the docker images are stored. Instead of converting the applications to containers each and every time, a developer can directly use the images stored in the registry.

**6. Differentiate between virtualization and containerization**
- Virtualization 	Containerization
    - Helps developers to run and host multiple OS on the hardware of a single physical server.	
    - Hypervisors provide overall virtual machines to the guest operating systems. 
    - These virtual machines form an abstraction of the system hardware layer this means that each virtual machine on the host acts like a physical machine.

- Containerization
    - This helps developers to deploy multiple applications using the same operating system on a single virtual machine or server.
    - Containers ensure isolated environment/ user spaces are provided for running the applications. Any changes done within the container do not reflect on the host or other containers of the same host.
    - Containers form abstraction of the application layer which means that each container constitutes a different application.  

**7. Differentiate between COPY and ADD**  
COPY provides just the basic support of copying local files into the container whereas ADD provides additional features like remote URL and tar extraction support.

**8. Differences between a Image and Layer**  
Image is built up from a series of layers of instructions. An image corresponds to the container and is used for speedy operation due to the caching mechanism of each step.

Layer corresponds to an instruction of the image’s Dockerfile. The layer is also an image but it is the image of the instructions run.


## Cheat sheet ##
| Command | Description |
| --- | --- |
| **Proccess Management** |--
| `docker build -t <name>:<tag>` . | Create an image |
| `docker ps` | List running container |
| `docker ps -a` | List history of created containers |
| `docker run <image>:<tag>` | Run a container |
| `docker run <image>:<tag>` --name <name> | Run a container adding a custom name |
| `docker run --rm <image>:<tag>` | Run a container and delete when stop |
| `docker run -it <image>:<tag>` | Run a container and connect to it |
| `docker run -d <image>:<tag>` | Run a container in the background |
| `docker start <image>:<tag>` | Run a container in the background |
| `docker start -a -i <image>:<tag>` | Run a container in the background and interact with it |
| `docker exec <container><command>` | Execute a command into a running container  |
| `docker stop -d <container>` | Stop a container |
| `docker kill <container>` | Kill a container |
| `docker attach <container>` | Get container output |
| `docker logs <container>` | Get container output history |
| `docker logs -f <container>` | Get container output with history |
| `docker rm <container>` | remove container |
| `docker rm -f $(docker ps -a -q)` | remove all container |
| `docker rmi <image>` | remove image |
| `docker image prune -a` | remove all images |
| `docker inspect <image>` | Inspect the layers of a image |
| **Images Repository** |--
| `docker login` | Login to remote hub |
| `docker build -t <repository>/<image>` | Kind of stage changes |
| `docker tage <local_image> <repository>/<image>` | Rename to match with an remote repository |
| `docker push <repository>/<image>` | push to remote repository |
| `docker pull <repository>/<image>` | pull image from remote repository |
| `docker run <repository>/<image>` | pull image from remote and run it |
| **Volumes** |--
| `docker volume ls` | list volume |
| `docker volume prune` | remove all anonymous volume |
| `docker volume rm <volume_name>` | remove specific volume |
| `docker run -v /app/data` | Create anonymous volume |
| `docker run -v data:/app/data` | Create named volume |
| `docker run -v /data:/app/data` | Create mount bind |
| `docker run -p 80:80 -d --name app -v -rm -v feedback:/app/feedback feedback-node`| correct way to create a volume
| `docker run -d -p 80:80 --rm --name feedback-app -v "/home/daniel/docker/node-app/logs/:/app/feedback/" feedback-node` | Create a Mount bind |
| **Networking** |--  
| `host.docker.internal` | To connect to localhost service |
| `docker network create favorites-net` | Create a new network |
| `docker network ls` | List networks created |
| `docker run -network my-network --name cont1 my-image` `docker run -network my-network --name cont2 my-other-image` | Running containers in the same network |
  
  


