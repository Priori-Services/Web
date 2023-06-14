# Website Priori Services 

Uma parte do projeto de TCC [Priori Services](https://github.com/Priori-Services)

## Execução

Este website depende de sua [API](https://github.com/Priori-Services/API), e seu banco de dados, as informações para a execução de ambos estão especificados seu [README.md](https://github.com/Priori-Services/API/blob/develop/README.md) 

### Windows

1. Copie o arquivo start.cmd.example para start.cmd
2. Altere as variáveis de ambiente para seus valores adequados
3. Execute!

### Docker

Para rodar o website em nosso ambiente docker, algo como o comando abaixo vai te ajudar!

```sh
docker run -p 5248:5248 \
    -e PRIORI_API_ENDPOINT= \
    -e PRIORI_EMAIL_USERNAME= \ 
    -e PRIORI_EMAIL_PASSWORD= \ 
    -e PRIORI_EMAIL_HOST= \ 
    -e PRIORI_EMAIL_PORT=
    -d --pull="always" \
    ghcr.io/priori-services/priori-web:latest
```

Depois de executar estes três passos, o website deve estar funcionando bem na sua máquina. 

> ALIÁS: Emails só serão enviados se estiverem especificados nas variáveis de ambiente do projeto, favor verifica-las!
