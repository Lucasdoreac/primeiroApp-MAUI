# Curso Programação para Dispositivos Móveis 2026

Repositório completo do curso de Programação para Dispositivos Móveis (PDM) com .NET MAUI, contendo todas as apostilas, exercícios e projetos desde o início.

## 📋 Estrutura do Curso

### Apostilas
- **Apostila 01**: Introdução ao Desenvolvimento Mobile
- **Apostila 02**: O que é o .NET MAUI? + Instalação
- **Apostila 03**: Interface do Usuário – Páginas e Layouts
- **Apostila 04**: Trabalhando com Imagens
- **Apostila 05**: Tela Principal (MainPage)
- **Apostila 06A**: Usando TabbedPage
- **Apostila 06B**: Usando FlyoutPage
- **Apostila 07**: Visualizações que Iniciam Comandos e Edição de Texto

### Projetos Principais
- `primeiroApp` - Primeira aplicação MAUI
- `appUsandoTabbedPage` - Navegação por abas
- `appUsandoFlyoutPage` - Navegação por menu lateral
- `appUsandoEntry` - Controles de entrada e botões

### Exercícios
- `exercicio01Grupo05` - ContentPage com imagem
- `exercicio02_Grupo20` - TabbedPage com pizzas

## 🛠️ Ambiente de Desenvolvimento

### Sistema Operacional
- **macOS 15.7.6** (ARM64)
- **8 GB RAM**
- **Xcode 26.2**

### Ferramentas Instaladas
- **.NET SDK 9.0.301**
- **MAUI workload 9.0.120**
- **iOS/MacCatalyst workloads**

### Diferenças da Apostila
- Apostila presume Windows 11 + Visual Studio 2026
- Ambiente atual usa macOS + Xcode + CLI
- .NET 10 (citado na apostila) ainda não lançado
- .NET 9.0.301 é a versão estável mais recente

## 📚 Conteúdo por Apostila

### Apostila 01: Introdução
- Histórico do design de interfaces móveis
- Evolução dos aplicativos
- Desafios do mobile (telas pequenas, ambientes físicos)

### Apostila 02: Instalação
- Introdução ao .NET MAUI
- Instalação do Visual Studio 2026
- Configuração do ambiente
- Criação do primeiro projeto: `primeiroApp`

### Apostila 03: Páginas e Layouts
- Pages (ContentPage, TabbedPage)
- Layouts (StackLayout, Grid)
- Configurações do projeto (nome, ID, versão)

### Apostila 04: Imagens
- Pixels de densidade independente (dp)
- Troca de ícone do aplicativo
- Configuração de Splash Screen
- Projeto: personalização do `primeiroApp`

### Apostila 05: MainPage Personalizada
- Limpeza da estrutura padrão
- Criação de páginas XAML personalizadas
- Propriedades de design (Margin, Padding, BackgroundColor)
- Projeto: refatoração do `primeiroApp`

### Apostila 06A: TabbedPage
- Navegação por abas superiores/inferiores
- Projeto: `appUsandoTabbedPage`
- Estrutura de pastas: Views/

### Apostila 06B: FlyoutPage
- Navegação por menu lateral (sanduíche)
- Projeto: `appUsandoFlyoutPage`
- Comportamentos popover e divisões de tela

### Apostila 07: Controles Interativos
- Button e eventos de clique
- Entry para entrada de texto
- Validação de campos e alertas
- Projeto: `appUsandoEntry` (Cadastro de Carros)

## 🔧 Como Usar Este Repositório

### Clonar o Repositório
```bash
git clone https://github.com/seu-usuario/dotnet-maui.git
cd dotnet-maui
```

### Restaurar Dependências
```bash
dotnet restore
```

### Compilar e Executar
```bash
dotnet build
dotnet run
```

## 📝 Histórico de Commits

Cada apostila corresponde a um ponto no versionamento:
- Commit inicial: Estrutura do repositório
- Apostila 02: Primeiro projeto MAUI
- Apostila 03-04: Personalização e imagens
- Apostila 05: Refatoração do MainPage
- Apostila 06A: Projeto TabbedPage
- Apostila 06B: Projeto FlyoutPage
- Apostila 07: Projeto Entry completo

## 🎯 Próximos Passos

1. Criar projetos individualmente para cada apostila
2. Documentar diferenças entre Windows (apostila) e macOS (atual)
3. Adicionar screenshots e exemplos funcionais
4. Criar guias de troubleshooting para macOS

## 📱 Plataformas Suportadas

- ✅ **iOS** 11+
- ✅ **macOS** 11+ (MacCatalyst)
- ⚠️ **Android** 5.0+ (requer emulador/configuração adicional)
- ❌ **Windows** (requer máquina Windows)

## 👨‍💻 Autor

Curso de Programação para Dispositivos Móveis 2026

---

**Nota**: Este repositório segue o conteúdo do NotebookLM "Plano de Ensino: Programação Para Dispositivos Móveis 2026" (ID: d7c17a87-6c17-4953-aa67-9cacd31e7a35).