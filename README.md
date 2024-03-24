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

### Comandos Úteis

| Command           | Description                                           |
| --------               | ---                                                   |
| `-d`              | Desatacha o prompt de comando, se eu rodar um comando para criar o docker por exemplo, ele me libera o terminal para fazer outra coisa |
| `-p`        |  Informa em qual porta o docker estará rodando |
| `--name`    | Informa um nome para o container a ser criado |
| `start`     | Inicia um container existente|