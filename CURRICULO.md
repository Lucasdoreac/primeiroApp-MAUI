# 📚 Currículo Completo - Programação Para Dispositivos Móveis 2026

## Visão Geral do Curso
Curso completo de desenvolvimento mobile com .NET MAUI, cobrindo desde conceitos básicos até interfaces avançadas e navegação complexa.

---

## 🎓 Apostila 01 - Introdução ao Desenvolvimento Mobile

### 📋 Conteúdo
- Histórico do design de interfaces para iPhone, Android e Windows
- Evolução dos aplicativos (apps) ao longo do tempo
- Desafios específicos do mobile:
  - Telas pequenas
  - Ambientes físicos desafiadores
  - Interação touch vs mouse/teclado

### 🎯 Objetivos de Aprendizado
- Compreender o contexto histórico do desenvolvimento mobile
- Identificar os desafios únicos do design mobile
- Entender a evolução das plataformas mobile

### 📁 Deliverables
- ❌ Sem projetos práticos (apostila teórica)

---

## 🎓 Apostila 02 - O que é o .NET MAUI?

### 📋 Conteúdo
- Introdução ao .NET Multi-platform App UI (.NET MAUI)
- Evolução do Xamarin.Forms para .NET MAUI
- Arquitetura multiplataforma
- Requisitos de sistema
- Guia de instalação do Visual Studio 2026
- Configuração do ambiente de desenvolvimento

### 🎯 Objetivos de Aprendizado
- Entender o que é .NET MAUI e suas vantagens
- Configurar o ambiente de desenvolvimento
- Criar o primeiro aplicativo funcional

### 🛠️ Projeto Prático
#### `primeiroApp`
- **Tipo**: Primeira aplicação MAUI funcional
- **Estrutura**:
  ```
  primeiroApp/
  ├── Properties/
  │   └── launchsettings.json
  ├── Platforms/
  │   ├── Android/
  │   │   ├── MainActivity.cs
  │   │   └── MainApplication.cs
  │   ├── iOS/
  │   ├── MacCatalyst/
  │   └── Windows/
  ├── Resources/
  │   ├── AppIcon/
  │   ├── Fonts/
  │   ├── Images/
  │   ├── Raw/
  │   ├── Splash/
  │   └── Styles/
  ├── MauiProgram.cs
  ├── App.xaml
  ├── App.xaml.cs
  ├── AppShell.xaml
  ├── AppShell.xaml.cs
  ├── MainPage.xaml
  ├── MainPage.xaml.cs
  └── primeiroApp.csproj
  ```

### 📁 Deliverables
- ✅ Projeto `primeiroApp` completo
- ✅ Ambiente configurado e funcionando

---

## 🎓 Apostila 03 - Interface do Usuário: Páginas e Layouts

### 📋 Conteúdo
- Grupos de controles fundamentais
- **Pages**: ContentPage, TabbedPage
- **Layouts**: StackLayout, Grid
- Configurações do projeto:
  - Alterar nome do aplicativo
  - Configurar ID do aplicativo
  - Definir versão

### 🎯 Objetivos de Aprendizado
- Dominar os tipos de páginas no MAUI
- Entender e usar layouts principais
- Personalizar configurações do projeto

### 🛠️ Projeto Prático
#### Continuação do `primeiroApp`
- **Modificações**:
  - Personalização de `MainPage.xaml`
  - Alteração de configurações no `.csproj`

### 📁 Deliverables
- ✅ `primeiroApp` com layouts personalizados
- ✅ Configurações de projeto modificadas

---

## 🎓 Apostila 04 - Trabalhando com Imagens

### 📋 Conteúdo
- Importância da resolução em mobile
- **Pixels de densidade independente (dp)**
- Troca de ícone do aplicativo
- Configuração de **Tela de Carregamento (Splash Screen)**

### 🎯 Objetivos de Aprendizado
- Entender resolução e densidade de pixels
- Trabalhar com imagens em diferentes resoluções
- Configurar Splash Screen para Windows e Android

### 🛠️ Projeto Prático
#### Continuação do `primeiroApp`
- **Arquivos Adicionados**:
  ```
  Resources/
  ├── AppIcon/
  │   └── novoicone.svg
  ├── Splash/
  │   └── splash.svg
  └── Images/
      └── bemvindo.svg
  ```
- **Arquivos Modificados**:
  - `primeiroApp.csproj`: Tags `<MauiIcon>` e `<MauiSplashScreen>`
  - `MainPage.xaml`: Elemento `<Image>` com novo `Source`

### 📁 Deliverables
- ✅ Ícone personalizado
- ✅ Splash Screen configurado
- ✅ Imagem de boas-vindas integrada

---

## 🎓 Apostila 05 - Tela Principal (MainPage)

### 📋 Conteúdo
- Limpeza da estrutura padrão do projeto
- Criação de telas personalizadas
- Novas páginas XAML
- Configuração do fluxo de chamada no `App.xaml.cs`
- Propriedades de design:
  - **Margin**
  - **Padding**
  - **BackgroundColor**

### 🎯 Objetivos de Aprendizado
- Remover templates padrão
- Criar interfaces do zero
- Aplicar propriedades de design consistentes

### 🛠️ Projeto Prático
#### Refatoração do `primeiroApp`
- **Arquivos Excluídos**:
  - `MainPage.xaml`
  - `AppShell.xaml`
- **Novos Arquivos**:
  - `NovaPagina.xaml` (ContentPage)
  - `NovaPagina.xaml.cs`
- **Modificações**:
  - `App.xaml.cs`: Propriedade `Window` alterada

### 📁 Deliverables
- ✅ `primeiroApp` com interface personalizada
- ✅ Template padrão removido

---

## 🎓 Apostila 06A - Usando TabbedPage

### 📋 Conteúdo
- Navegação por **abas superiores ou inferiores**
- TabbedPage como container de outras páginas
- Alternância de conteúdo através de guias

### 🎯 Objetivos de Aprendizado
- Implementar navegação por abas
- Estruturar aplicações com múltiplas views
- Organizar código em pastas lógicas

### 🛠️ Projeto Prático
#### `appUsandoTabbedPage`
- **Estrutura**:
  ```
  appUsandoTabbedPage/
  ├── Views/
  │   ├── Principal.xaml (TabbedPage)
  │   ├── Principal.xaml.cs
  │   ├── Tab1.xaml
  │   └── Tab2.xaml
  ├── App.xaml
  ├── App.xaml.cs (modificado)
  └── appUsandoTabbedPage.csproj
  ```
- **Modificações**:
  - `App.xaml.cs`: Configuração do `NavigationPage`

### 📁 Deliverables
- ✅ Projeto `appUsandoTabbedPage` completo
- ✅ Navegação funcional por abas

---

## 🎓 Apostila 06B - Usando FlyoutPage

### 📋 Conteúdo
- **FlyoutPage**: Menu lateral (sanduíche)
- Página de detalhes
- Comportamentos **popover**
- Divisões de tela

### 🎯 Objetivos de Aprendizado
- Criar menus laterais funcionais
- Implementar navegação master-detail
- Tratar comportamentos específicos de plataforma

### 🛠️ Projeto Prático
#### `appUsandoFlyoutPage`
- **Estrutura**:
  ```
  appUsandoFlyoutPage/
  ├── Views/
  │   ├── FlyoutPageMenu.xaml (FlyoutPage)
  │   ├── FlyoutPageMenu.xaml.cs
  │   ├── Menu.xaml (menu lateral)
  │   ├── Menu.xaml.cs
  │   ├── Dandara.xaml (detalhe 1)
  │   ├── Dandara.xaml.cs
  │   ├── Oprah.xaml (detalhe 2)
  │   └── Oprah.xaml.cs
  ├── App.xaml
  └── App.xaml.cs
  ```

### 📁 Deliverables
- ✅ Projeto `appUsandoFlyoutPage` completo
- ✅ Menu lateral funcional

---

## 🎓 Apostila 07 - Visualizações e Edição de Texto

### 📋 Conteúdo
- **Button** e eventos de clique
- **Entry**: Entrada e edição de texto
  - Configurações de teclado
  - Campos de senha
  - Botões de limpeza
- Validação de campos
- Exibição de alertas (`DisplayAlertAsync`)

### 🎯 Objetivos de Aprendizado
- Implementar controles interativos
- Tratar entrada de texto do usuário
- Validar formulários
- Exibir feedback ao usuário

### 🛠️ Projeto Prático
#### `appUsandoEntry` (Cadastro de Carros)
- **Estrutura**:
  ```
  appUsandoEntry/
  ├── Views/
  │   ├── FlyoutPageMenu.xaml
  │   ├── Menu.xaml
  │   ├── Principal.xaml (demonstração Entry)
  │   ├── CadastroDeCarros.xaml (tela principal)
  │   └── CadastroDeCarros.xaml.cs
  ├── App.xaml
  └── App.xaml.cs
  ```
- **Funcionalidades**:
  - Campos: Nome, Placa
  - Botões: Exibir Dados, Limpar, Sair
  - Validação: `string.IsNullOrWhiteSpace`
  - Alertas: `DisplayAlertAsync`

### 📁 Deliverables
- ✅ Projeto `appUsandoEntry` funcional
- ✅ Cadastro de carros completo

---

## 🏆 Exercícios Práticos

### Exercício 01 - Grupo 05
#### `exercicio01Grupo05`
- **Objetivo**: ContentPage com imagem centralizada
- **Arquivo Principal**: `Principal.xaml`
- **Habilidades**: Layout básico e imagens

### Exercício 02 - Grupo 20
#### `exercicio02_Grupo20`
- **Objetivo**: TabbedPage com conteúdo de pizzas
- **Estrutura**:
  ```
  Views/
  ├── Principal.xaml (TabbedPage)
  ├── pizzacalabresa.xaml
  └── pizzaportuguesa.xaml
  ```
- **Habilidades**: Navegação por abas e organização

---

## 📊 Progresso do Curso

| Apostila | Status | Projeto | Entrega |
|----------|--------|---------|---------|
| 01 - Introdução | ✅ Teórico | - | - |
| 02 - Instalação | ✅ Completo | `primeiroApp` | ✅ |
| 03 - Layouts | ✅ Completo | `primeiroApp` | ✅ |
| 04 - Imagens | ✅ Completo | `primeiroApp` | ✅ |
| 05 - MainPage | ✅ Completo | `primeiroApp` | ✅ |
| 06A - TabbedPage | ⚠️ Pendente | `appUsandoTabbedPage` | ❌ |
| 06B - FlyoutPage | ⚠️ Pendente | `appUsandoFlyoutPage` | ❌ |
| 07 - Entry | ⚠️ Pendente | `appUsandoEntry` | ❌ |

---

## 🎯 Certificação e Avaliação

### Critérios de Avaliação
- ✅ Compreensão dos conceitos teóricos
- ✅ Funcionalidade dos projetos práticos
- ✅ Qualidade do código e organização
- ✅ Capacidade de resolver problemas

### Projetos Avaliativos
1. **Exercício 01**: Layout básico
2. **Exercício 02**: Navegação por abas
3. **Projeto Final**: `appUsandoEntry` (Cadastro de Carros)

---

## 📚 Recursos Adicionais

### Documentação Oficial
- [.NET MAUI Documentation](https://docs.microsoft.com/pt-br/dotnet/maui/)
- [Xamarin to MAUI Migration Guide](https://docs.microsoft.com/pt-br/dotnet/maui/migration/)

### Ferramentas
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2026](https://visualstudio.microsoft.com/)
- [Xcode](https://developer.apple.com/xcode/)

### Comunidade
- [.NET MAUI Community](https://github.com/dotnet/maui)
- [Stack Overflow - MAUI Tag](https://stackoverflow.com/questions/tagged/maui)

---

**Nota**: Este currículo segue o conteúdo do NotebookLM "Plano de Ensino: Programação Para Dispositivos Móveis 2026".
