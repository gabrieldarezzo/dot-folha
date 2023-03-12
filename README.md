# Dot-Folha
O Dot folha é um sistema de ponto com fim acadêmicos, desenvolvido em C#.

## Run in Local:

### up Just mysql
```shell
docker-compose up db
```

## Run in Local:
```shell
dotnet run
```  

Check in url:   
http://localhost:3000/users  


# Database Migrations 
This project use CODE-FIRST workflow.

You'll need:
- https://learn.microsoft.com/en-us/ef/core/cli/dotnet
(Cli commands to create/run and improve database)


#### Install dotnet-ef
```shell
dotnet tool install --global dotnet-ef
```

#### Run all migrations:
```shell
dotnet ef database update
```


##### Example of create migration:
```shell
dotnet ef migrations add users
```


## Docker 
### Up .net + mysql-server
```shell
docker-compose up --build
```  


### Build (aws || azure)?
```shell
docker build -t dotnetservice .
```

### run cointainer
```shell
docker container run -it --rm -p 3000:80 --name dotnetservicecontainer dotnetservice
```

### Debug in container:

#### Install ping
```shell
docker exec -it dotnetservicecontainer bash
apt update && apt upgrade && apt install iputils-ping
ping db
```  

#### Check database
```shell
docker exec -it db bash
mysql -uroot -proot homestead
```  



