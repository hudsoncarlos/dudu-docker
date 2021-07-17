# Criando uma imagem que a base dela é node.
FROM node

# O diretório de trabalho dessa imagem la no container vai ser.
WORKDIR /usr/src/app

# Vou copiar o package.json que contem as dependencias necessárias para o WORKDIR, pode usar o nome "/usr/src/app" ou somente ".".
COPY package.json /usr/src/app

# Instalar os pacotes npm por meio da diretiva RUN.
RUN npm install

# Agora eu vou copiar todos os diretórios da minha aplicação para o WORKDIR
COPY . /usr/src/app 

# Expor a porta da aplicação que no caso aqui foi a 3000
EXPOSE 3000

# Comando para dar start na aplicação deve ficar por ultimo.
CMD ["node", "index.js"]