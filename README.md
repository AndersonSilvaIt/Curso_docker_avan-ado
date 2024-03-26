## Curso de Docker  Desenvolvedor.IO

Para criar um novo container, atravéz de uma imagem já existente

### Criar um cointainer

**Imagem Nome:** `docker/welcome-to-docker:latest` <br/>
**Porta Interna:** `80`<br/>
**Porta Externa:** `8088`  `Acesso externo` <br/>
* *No caso das portras, primeiro preciso informar qual a porta que minha aplicação ficará disponível para acesso externo, depois informo qual a porta interna será mapeada* <br/>

`docker run --name NOME_CONTAINER -d -p PORTA NOME_IMAGEM` <br/>
*   `docker run --name meu-container -d -p 8088:80 docker/welcome-to-docker:latest`


### Iniciar um container

`docker start CONTAINER_NAME`<br/>
`docker start ID_CONTAINER`
*   `docker start meu-container`


### Interagir com um Container

`docker exec -it CONTAINER_NAME/ID /bin/bash` --> Executa um comando dentro do container informado
 > **/bash/sh**  ➜ ShellScript Womdows
 >
 > **/bin/bash** ➜ Sshell Linux
`
<br/>

* `docker exec -it meu-container /bin/sh`
* `docker logs CONTAINER`  ➜ Mostra os logs do container
* `docker inspect CONTAINER` ➜ Mostra os arquivos de dentro do container

* `docker cp CONTAINER_NAME:FILE_A_COPIAR DENSTINO_NOME`
    *  `docker cp meu-container:/usr/share/nginx/html/index.html c:\temp\index.html`
        > **meu-container** : Nome container
        >
        > **usr/share....index.html** : Arquivo que será copiado para a máquina local
        >
        > **c:temp....index.html** : Local em minha máquina que o arquivo será copiado, posso usar outro nome, "index2.html"  
        > **Obs**: Verificar se existe o caminho "c:/temp" primeiro, caso não existir, irá apresentar erro
* `more File_Name` ➜ Mostra o conteúdo de um arquivo

### Comandos Úteis

| Command           | Description                                           |
| --------               | ---                                                   |
| `-d`              | Desatacha o prompt de comando, se eu rodar um comando para criar o docker por exemplo, ele me libera o terminal para fazer outra coisa |
| `-p`        |  Informa em qual porta o docker estará rodando |
| `--name`    | Informa um nome para o container a ser criado |
| `start`     | Inicia um container existente|
| `ps`        | Lista os dockers em execução |
| `-a`        | Lista todos os dockers, em execução ou não |
| `rm`        | Deleta os containers em execução |
| `prune`     | Deleta os contaners que estão parados |
| `stats`     | Obtém os status dos containers |
| `exec`      | Executa um comando dentro do container |
| `-it `      | Modo "iterativo", o que acontecer no terminal do container, irá mostrar no terminal atual |
| `exit`      | Sai do terminal do container e volta para o terminal de sua máquina|
| `logs`      | Mostra os logs do container |
| `inspect`   | Inspeciona os arquivos do docker |
| `cp`        | Copiar algum arquivo do docker para a máquina local|
| `more`      | Mostra o conteúdo de um arquivo do container|
