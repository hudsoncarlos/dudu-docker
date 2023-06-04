# Praticando Docker
=====================
Este reposítório foi criado para aplicar aprendizados sobre docker.
### $$DOCKER FUNDAMENTOS - Tutorial: https://www.youtube.com/watch?v=np_vyd7QlXk&t=189s

## Deixe uma estrela! :star:
Se o projeto te ajudou ou se achou interessante, deixe uma estrela ;)

## Como usar:
- Você precisará do Visual Studio 2022 ou mais recentes dependendo do momento que visualizar esta página.
- É possível também utilizar o VS Code para rodar o projeto.

Segue o link para auxiliar na configuração do ambiente de trabalho: https://dotnet.microsoft.com/pt-br/download

Baixar docker para máquina: https://www.docker.com/products/docker-desktop

# $$ COMANDOS DOCKER

docker run -it -p 302:80 --name ubuntu-docker ubuntu					=> Cria e manipula o terminar de uma imagem do Ubuntu.

docker run -it -p 302:80 --name node-docker node 							=> Cria e manipula o terminal de uma imagem do Node.

docker run -d -p 302:80 --name nginx-docker nginx							=> Roda o container em background.

docker ps																											=> Lista todos os containers ativos.

docker ps -a 																									=> Lista todos os containers executados nessa máquina.

docker stop 02f9e76c2259																			=> Parar um container em execução em segundo plano pelo id.	

docker run -d -p 80:80																				=> Expondo uma porta para acesso ao docker.

docker start d8c9e405acaf																			=> Comando para iniciar um container que foi para sem ter criar um novo pelo id.

docker rename d8c9e405acaf nginx-docker												=> Renomeando um container criado pelo id.

docker logs nginx-docker																			=> Exibindo arquivos de logs do container pelo nome.

docker rm 86549635e4a0																				=> Remover um container docker pelo id

docker build -t node-image .																	=> Procura um Dockerfile para buildar essa imagem no diretório atual nomeando ela para "node-docker-image".

docker image ls																								=> Comando para listar todas imagens no meu sistema atual.

docker image rm 4f8d916aefc7																	=> Remover uma imagem pelo id da imagem.

docker rmi 4f8d916aefc7																				=> Remover uma imagem pelo id da imagem.

docker run -p 3000:3000 -d --name node-container node-image		=> Rodando docker apartir de uma imagem criada.

docker system prune																						=> Remove coisas que não estão sendo utilizadas liberando espaço.	

___________________
npm init -y																										=> Crindo projeto em node, precisa ter no node instalado.

npm install express																						=> Instando o framework Express.

## Technologies implemented:

- .NET Core 3.1
- Docker
