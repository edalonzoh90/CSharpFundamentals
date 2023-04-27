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



