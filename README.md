# 🚚 Aplicativo de Delivery

Aplicativo de delivery simples desenvolvido com **.NET MAUI** para a interface mobile e **ASP.NET** para o backend e a comunicação com o servidor. O sistema permite o gerenciamento e o acompanhamento de pedidos de acordo com o perfil de cada usuário: cliente, entregador (motoqueiro) e administrador.

## 📋 Funcionalidades

### 🔐 Autenticação e conta

* **Login:** acesso ao sistema por meio de credenciais cadastradas.
* **Cadastro:** criação de novas contas de usuário.
* **Recuperação de senha:** funcionalidade para recuperar o acesso à conta.

### 👤 Cliente

* Listar e visualizar seus pedidos.
* Cancelar pedidos, conforme as regras definidas pelo sistema.

### 🏍️ Entregador

* Listar pedidos disponíveis ou atribuídos ao entregador.
* Marcar pedidos como entregues após a conclusão da entrega.

### 🛠️ Administrador

* Listar e visualizar os pedidos cadastrados no sistema.
* Acompanhar os pedidos para auxiliar no gerenciamento das entregas.

## 🧰 Tecnologias utilizadas

* **.NET MAUI:** desenvolvimento da aplicação mobile multiplataforma.
* **C#:** linguagem utilizada no desenvolvimento do aplicativo e do backend.
* **ASP.NET:** construção da API responsável pela comunicação entre o aplicativo e o servidor.
* **REST API / HTTP:** comunicação entre o aplicativo e o backend.
* **JSON:** formato de troca de dados entre o aplicativo e a API.

> A utilização de banco de dados, ORM, bibliotecas de autenticação e outras tecnologias depende da implementação específica do projeto.

## 🏗️ Arquitetura do projeto

O sistema é dividido em duas partes principais:

* **Aplicativo mobile (.NET MAUI):** responsável pelas telas, autenticação, listagem de pedidos e interação com o usuário.
* **Backend (ASP.NET):** responsável pelo processamento das requisições, gerenciamento dos pedidos, autenticação e aplicação das regras de negócio.

O aplicativo realiza requisições HTTP para a API ASP.NET, que processa as operações e retorna os dados em formato JSON.

## 🔄 Fluxo básico de funcionamento

1. O usuário realiza o cadastro ou efetua login.
2. O sistema identifica o perfil de acesso: cliente, entregador ou administrador.
3. Cada perfil visualiza a listagem de pedidos correspondente às suas permissões.
4. O cliente pode cancelar um pedido, quando permitido.
5. O entregador pode marcar um pedido como entregue.
6. O administrador pode consultar os pedidos para acompanhar as operações.

*Observação: a estrutura acima é uma sugestão e pode variar de acordo com a organização real do repositório.*

## ⚙️ Como executar o projeto

### Pré-requisitos

* .NET SDK compatível com a versão utilizada no projeto.
* Visual Studio com a carga de trabalho de desenvolvimento .NET MAUI.
* Ferramentas necessárias para executar a aplicação ASP.NET.
* Emulador Android, dispositivo físico ou outra plataforma compatível com o projeto.
* Banco de dados configurado, caso seja utilizado pelo backend.

### 1. Clonar o repositório

```bash
git clone <URL_DO_REPOSITORIO>
cd <PASTA_DO_PROJETO>
```

### 2. Executar a API ASP.NET

Entre na pasta do backend e execute:

```bash
dotnet restore
dotnet run
```

Verifique a URL em que a API está sendo executada e configure o aplicativo mobile para utilizá-la.

### 3. Configurar a conexão no aplicativo

Defina o endereço-base da API de acordo com o ambiente de execução.

Exemplos de configuração:

* **Emulador Android:** utilize o endereço acessível pelo emulador para alcançar o servidor executado no computador.
* **Dispositivo físico:** utilize o endereço IP local do computador, caso ambos estejam na mesma rede e o servidor permita conexões externas.
* **Servidor remoto:** utilize o endereço HTTPS disponibilizado para a API.

Evite utilizar `localhost` indiscriminadamente no aplicativo mobile, pois ele pode apontar para o próprio dispositivo, e não para o computador onde a API está sendo executada.

### 4. Executar o aplicativo MAUI

Abra a solução no Visual Studio, selecione o projeto MAUI como projeto de inicialização, escolha o dispositivo ou emulador e execute a aplicação.

## 🔒 Controle de acesso

As funcionalidades devem respeitar o perfil autenticado:

* **Cliente:** consulta seus pedidos e pode cancelar pedidos permitidos.
* **Entregador:** consulta os pedidos aos quais tem acesso e pode registrar a conclusão da entrega.
* **Administrador:** consulta os pedidos para acompanhamento e gerenciamento.

As permissões devem ser validadas também no backend ASP.NET, e não apenas na interface do aplicativo.

## 🎯 Objetivo do projeto

O objetivo é desenvolver uma solução de delivery simples, com funcionalidades essenciais para autenticação, consulta e acompanhamento de pedidos, utilizando .NET MAUI no aplicativo mobile e ASP.NET na API de comunicação com o servidor.

---

**Status do projeto:** em desenvolvimento.

**Tipo:** aplicação mobile integrada a uma API.

**Plataformas:** conforme os destinos configurados no projeto .NET MAUI.
