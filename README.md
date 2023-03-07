# Dot-Folha
O Dot folha é um sistema de ponto com fim acadêmicos, desenvolvido em C#.

## Run in Local:
```shell
docker build -t dotnetservice .
```

## Docker 
### Up Cointainer
```shell
docker build -t dotnetservice .
```

### Run Cointainer
```shell
docker container run -it --rm -p 3000:80 --name dotnetservicecontainer dotnetservice
```


## Run in Local:
```shell
dotnet run
```  
http://localhost:3000/users


### Install ping
```shell
apt update && apt upgrade && apt install iputils-ping
```  

### Check Database
```shell
docker exec -it db bash
mysql -uroot -proot homestead
```  



