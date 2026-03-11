# primeiroApp-MAUI 🚀

Este é o primeiro projeto acadêmico desenvolvido na disciplina de **Programação Para Dispositivos Móveis (PDM)**, seguindo os padrões do **Framework LUDOC**.

## 🛠️ Requisitos Globais (Ambos os Sistemas)

### 1. Bun & Node.js
O framework LUDOC utiliza o **Bun** como gerenciador principal.
- **Instalar Bun**:
  - **Windows**: `powershell -c "irm bun.sh/install.ps1 | iex"`
  - **macOS**: `curl -fsSL https://bun.sh/install | bash`
- **Node.js**: Certifique-se de ter o Node.js (LTS) instalado.

### 2. Gemini CLI
Ferramenta de IA para automação e assistência no terminal:
```bash
npm install -g @google/gemini-cli
```

---

## 💻 Configuração no Windows

### Workloads .NET MAUI
Abra o terminal como Administrador e execute:
```powershell
dotnet workload install maui-android maui-windows aspnetcore-support
```

### Visual Studio
Certifique-se de ter o **Visual Studio 2022/2026** com a carga de trabalho ".NET Multi-platform App UI development".

### Como Executar
```powershell
dotnet build -t:Run -f net10.0-windows10.0.19041.0
```

---

## 🍎 Configuração no macOS

### Homebrew
Caso não tenha o Homebrew instalado:
```bash
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
```

### Xcode & Ferramentas
1. Instale o **Xcode** pela App Store.
2. Aceite os termos e instale os componentes adicionais.
3. No terminal: `xcode-select --install`

### Workloads .NET MAUI
```bash
dotnet workload install maui-ios maui-maccatalyst maui-android
```

### Como Executar
```bash
# Para macOS (MacCatalyst)
dotnet build -t:Run -f net10.0-maccatalyst

# Para Simulador iOS
dotnet build -t:Run -f net10.0-ios
```

---

## 📐 Estrutura do Projeto
- `primeiroApp/`: Código-fonte principal.
- `Platforms/`: Arquivos nativos (Android, iOS, Windows, Mac).
- `Resources/`: Imagens, ícones e estilos globais.
- `MEMORIA.md`: Log de decisões e evolução técnica.

## 🤝 Contribuição (LUDOC Flow)
1. Faça o pull: `git pull origin main`
2. Crie sua branch: `feat/minha-feature`
3. Commit convencional: `feat: add new button`
4. Push e Sync.

---
**Professor:** Msc Rafael Soares de Almeida
**Status:** Repositório Inicializado e Configurado 🚀



  🍎 Guia de Configuração: .NET MAUI no macOS (Sem Xcode IDE)


  Para desenvolver no Mac sem usar o Xcode como editor principal, o padrão de elite é utilizar o Visual Studio Code ou JetBrains Rider.


  1. Requisitos de Sistema
   * macOS: Atualizado (Sequoia ou Sonoma preferencialmente).
   * Xcode (Command Line Tools): Mesmo que você não use a IDE Xcode, os compiladores da Apple são obrigatórios para builds de iOS/MacCatalyst.
       xcode-select --install


  2. Instalação do SDK e Workloads
  Instale o .NET 10.0 (conforme o padrão do projeto) e as cargas de trabalho do MAUI via terminal:


   # Instalar o .NET SDK (via Homebrew é mais rápido)
   brew install --cask dotnet-sdk

   # Instalar as workloads do MAUI
   sudo dotnet workload install maui-android maui-ios maui-maccatalyst


  3. Configuração da IDE (VS Code)
  Para ter uma experiência próxima ao Visual Studio 2022/2026:
   1. Instale a extensão ".NET MAUI" da Microsoft.
   2. Instale o "C# Dev Kit".
   3. Configuração do Emulador: Instale o Android Studio apenas para gerenciar o simulador Android (AVD Manager).

  4. Como Rodar o Projeto via CLI
  No Mac, você pode compilar e rodar sem abrir nenhuma IDE pesada:


   # Rodar no Simulador Android
   dotnet build -t:Run -f net10.0-android

   # Rodar como Aplicativo Nativo de Mac (MacCatalyst)
   dotnet build -t:Run -f net10.0-maccatalyst


  5. Checklist de Verificação (Pós-Aula 03)
  Certifique-se que o seu primeiroApp.csproj no Mac reflete as alterações que fizemos:
   * ApplicationTitle: Primeiro Aplicativo
   * ApplicationId: br.edu.udf.primeiroApp
   * ApplicationDisplayVersion: 1.0.0
   * ApplicationVersion: 100


  O repositório já contém o .gitignore correto para não subir pastas bin, obj ou arquivos temporários do macOS (.DS_Store).

