# Sistema de Gerenciamento de Equipes

Esse código é o meu projeto de portifólio, para testar as minhas capacidades de desenvolvimento de um sistema complexo, que atenderá uma demanda real em uma rede local (não tem segurança suficiente para ser exposto).

O sistema consiste em uma aplicação web que atenderá alguns setores

1. **AUTENTICAÇÃO:** sistema de autenticação para controle de acesso com persistência de credencial com JWT.
2. **COMPOSIÇÃO:** formulário para registro diário de equipes despachadas para campo, com registro da viatura, motorista e ajudante e supervisor responsável, além do identificador do espelho e tipo de serviço.

Para iniciar o servidor em modo de desenvolvimento é só executar o comando abaixo:

```bash
sudo docker compose --env-file ./.env.dev up -d
```

Para entrar no terminal interativo do MySQL, execute os comando abaixo:

```bash
docker cp database.sql container_id:/
sudo docker exec -it mysql /bin/bash
mysql -u root -p
```

```bash
sudo docker exec -i mysql /bin/mysql -u $USERDB -p $PASSDB aplicacao < database.sql
```

Projeto montado com base nos tutoriais:
1. [Como criar containers com PHP, MySQL e NGINX utilizando o Docker Compose](https://dev.to/jrnunes1993/como-criar-containers-com-php-mysql-e-nginx-utilizando-o-docker-compose-964) de [Antonio Nunes Moreira Junior](https://dev.to/jrnunes1993) em 26 fev. 2022;
2. [How To Use the Official NGINX Docker Image](https://www.docker.com/blog/how-to-use-the-official-nginx-docker-image/) de [PETER MCKEE](https://www.docker.com/author/pmckee/) em 13 ago. 2020;