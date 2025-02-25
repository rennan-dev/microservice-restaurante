# Microservice Restaurante

Programa feito para treinar o aprendizado em microsserviços, o usuário pode adicionar um restaurante em Restaurante-Service e ele aparece de forma assíncrona em Item-Service feita pelo mensageiro rabbit mq

## 📑 Requisitos

- **Docker** instalado e em execução. 
- Certifique-se de que o Docker esteja em execução antes de continuar. Você pode verificar se o Docker está em execução com o comando:

    ```bash
    docker info
    ```

    Caso o Docker não esteja em execução, inicie o serviço do Docker com o comando:

    - **No Linux:**

        ```bash
        sudo systemctl start docker
        ```

    - **No Windows ou macOS:** Basta abrir o Docker Desktop e aguardar até que o Docker esteja pronto para ser usado.

## Comandos para serem executados no docker

### rabbitmq:
```
docker run -d --hostname rabbitmq-service --name rabbitmq-service --network alura-bridge rabbitmq:3-management
```

### MySQL:
```
docker run --name=mysql -e MYSQL_ROOT_PASSWORD=mysql -d --network alura-bridge mysql:latest
```

### Item-Service(Necessário estar dentro da solução):
```
docker run --name item-service -d -p 5001:80 --network alura-bridge microserviceitem:1.3
```

### Restaurante-Service(Necessário estar dentro da solução):
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
