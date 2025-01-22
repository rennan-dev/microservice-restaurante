# Microservice Restaurante

Programa feito para treinar o aprendizado em microsserviços, o usuário pode adicionar um restaurante em Restaurante-Service e ele aparece de forma assíncrona em Item-Service feita pelo mensageiro rabbit mq

## Comandos para serem executados no docker

### rabbitmq:
```
docker run -d --hostname rabbitmq-service --name rabbitmq-service --network alura-bridge rabbitmq:3-management
```

### MySQL:
```
docker run --name=mysql -e MYSQL_ROOT_PASSWORD=mysql -d --network alura-bridge mysql:latest
```

### Item-Service:
```
docker run --name item-service -d -p 5001:80 --network alura-bridge microserviceitem:1.3
```

### Restaurante-Service:
```
docker run --name restaurante-service -d -p 5101:80 --network alura-bridge microservicerestaurante:1.3
```

## Testar a solução no navegador de sua preferência:

```
http://localhost:5101/swagger/index.html
```

```
http://localhost:5001/swagger/index.html
```
