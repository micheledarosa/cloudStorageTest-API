# Cloud Storage API ☁️

Este é um projeto de exemplo demonstrando como realizar o upload de arquivos para o Google Drive usando ASP.NET Core Web API.

O projeto foi realizado com o professor [Welisson Arley](https://github.com/welissonArley) durante o evento *C# na Prática* da [Rocketseat](https://www.rocketseat.com.br/).

## Descrição 📙

O projeto consiste em uma aplicação ASP.NET Core Web API que permite o upload de arquivos para o Google Drive. Ele inclui endpoints REST para upload de arquivos e utiliza o Google Drive como serviço de armazenamento na nuvem.

## Tecnologias Utilizadas 💻

- ASP.NET Core Web API
- Google Drive API
- Microsoft.Extensions.DependencyInjection
- Microsoft.AspNetCore.Http
- Microsoft.Extensions.Configuration

## Funcionalidades 🧰

- Upload de arquivos para o Google Drive
- Verificação do tipo do arquivo antes do upload
- Uso de tokens de acesso para autenticação no Google Drive

## Verificação do tipo do arquivo antes do upload 🖼️

![Imgur](https://i.imgur.com/BAIuNUx.png)

A imagem mostra um cenário onde ocorre a verificação do tipo de arquivo antes do upload para o Google Drive. No exemplo, o arquivo não é uma imagem válida, e como resultado, uma exceção é lançada. A exceção indica que o arquivo não atende aos critérios de verificação de tipo de arquivo esperado para o upload no sistema.