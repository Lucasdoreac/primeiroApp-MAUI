# primeiroApp-MAUI 🚀

Este é o primeiro projeto acadêmico desenvolvido na disciplina de **Programação Para Dispositivos Móveis (PDM)**, seguindo os padrões do **Framework LUDOC**.

## 🍎 Guia de Configuração: .NET MAUI no macOS (CLI Agent)

Para rodar este projeto em um Mac via terminal (ou através de um agente), siga estes passos:

### 1. Requisitos de Sistema
* **Xcode Command Line Tools**: Essencial para os compiladores Apple.
  \\\ash
  xcode-select --install
  \\\
* **Homebrew**: Para gerenciar pacotes.
  \\\ash
  /bin/bash -c \"\\"
  \\\

### 2. Instalação do SDK e Workloads
Instale o .NET 10.0 e as cargas de trabalho necessárias:
\\\ash
# Instalar o .NET SDK via Homebrew
brew install --cask dotnet-sdk

# Instalar as workloads do MAUI para Apple
sudo dotnet workload install maui-ios maui-maccatalyst maui-android
\\\

### 3. Como Rodar via CLI
Navegue até a pasta do projeto e execute:

* **Para macOS (Desktop Nativo):**
  \\\ash
  dotnet build -t:Run -f net10.0-maccatalyst
  \\\
* **Para Simulador iOS (iPhone):**
  \\\ash
  # Listar simuladores disponíveis
  dotnet build -t:Run -f net10.0-ios
  \\\

### 4. Estrutura de Identidade (Apostila 03)
O projeto está configurado com:
* **ID**: \r.edu.udf.primeiroApp\
* **Título**: \Primeiro Aplicativo\
* **Versão**: \1.0.0 (Build 100)\

---
**Professor:** Msc Rafael Soares de Almeida
**Status:** Repositório Inicializado e Configurado 🚀

# PDM 2026 — UDF

Monorepo academico para Programacao Para Dispositivos Moveis.
