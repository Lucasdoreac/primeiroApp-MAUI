# Guia de Execução de Testes - App Usando Entry

## Estrutura dos Testes

O projeto de testes está organizado em 3 categorias principais:

### 1. Testes Unitários (`Validators/`)
- **CadastroValidatorTests.cs**: Validação de campos individuais
- 15 testes cobrindo todos os cenários de validação
- Testes rápidos (< 1ms cada)

### 2. Testes de Helpers (`Helpers/`)
- **CadastroHelperTests.cs**: Transformações e formatações
- 20 testes cobrindo formatação de texto e limpeza
- Testes de lógica de apresentação

### 3. Testes de Integração (`ViewModels/`, `Integration/`)
- **CadastroViewModelTests.cs**: Comportamento do ViewModel
- **CadastroWorkflowTests.cs**: Fluxos completos de cadastro
- 25+ testes de integração e workflow

## Execução dos Testes

### Via Visual Studio
```bash
# 1. Abrir a solução
open appUsandoEntry.sln

# 2. No VS: Test > Run All Tests
# Ou: Test Explorer > Run All
```

### Via CLI (dotnet test)
```bash
# Executar todos os testes
dotnet test

# Executar com detalhes
dotnet test --logger "console;verbosity=detailed"

# Executar com cobertura de código
dotnet test --collect:"XPlat Code Coverage"

# Executar apenas uma classe de testes
dotnet test --filter "FullyQualifiedName~CadastroValidatorTests"

# Executar apenas testes específicos
dotnet test --filter "FullyQualifiedName~ValidarNome_CampoVazio_DeveRetornarErro"
```

## Estrutura do Projeto de Testes

```
appUsandoEntry.Tests/
├── Validators/
│   └── CadastroValidatorTests.cs      # Validação de campos
├── Helpers/
│   └── CadastroHelperTests.cs         # Helpers de formatação
├── ViewModels/
│   └── CadastroViewModelTests.cs      # ViewModel
├── Integration/
│   └── CadastroWorkflowTests.cs       # Fluxos completos
└── appUsandoEntry.Tests.csproj        # Projeto de testes
```

## Cobertura de Testes

### Funcionalidades Cobertas
✅ Validação de campo Nome
✅ Validação de campo Placa
✅ Validação de campo Ano
✅ Limpeza de formulário
✅ Transformação de texto para maiúsculas
✅ Exibição de mensagens de erro
✅ Exibição de dados do carro
✅ Comportamento de foco
✅ Fluxos completos de cadastro
✅ Múltiplos cadastros consecutivos

### Estatísticas
- **Total de Testes**: 60+ testes
- **Tempo de Execução**: < 2 segundos
- **Cobertura Estimada**: 80%+ do código de validação

## Categorias de Testes por Prioridade

### CRÍTICOS (Devem sempre passar)
- Validação de campos obrigatórios
- Exibição de alertas de erro
- Limpeza de formulário

### IMPORTANTES
- Formatação de dados
- Comportamento de foco
- Fluxos completos

### DESEJÁVEIS
- Múltiplos cadastros
- Caracteres especiais
- Casos extremos

## Interpretação dos Resultados

### ✓ Teste Passou (Verde)
Comportamento conforme esperado

### ✗ Teste Falhou (Vermelho)
Comportamento diferente do esperado
- Verificar se requirements mudaram
- Verificar se implementação está correta
- Atualizar teste se comportamento esperado mudou

### ! Teste Pulado (Amarelo)
Teste não executado (geralmente por configuração)

## Próximos Passos

### 1. Testes de UI (Futuro)
Considerar adicionar:
- **MAUI.UITesting**: Testes de interface real
- **Appium**: Testes de automação mobile
- **Xamarin.UITest**: Testes de UI compatíveis

### 2. Mocks Avançados (Futuro)
- Mock de `INavigation`
- Mock de `IDisplayAlert`
- Mock de serviços externos

### 3. Testes de Performance (Futuro)
- Tempo de resposta de validação
- Memória utilizada
- Performance de múltiplos cadastros

## Troubleshooting

### Erro: "Project not found"
```bash
# Adicionar projeto à solução
dotnet sln add appUsandoEntry.Tests/appUsandoEntry.Tests.csproj
```

### Erro: "Package restore failed"
```bash
# Restaurar pacotes
dotnet restore
```

### Erro: "Test not discovered"
```bash
# Limpar e recompilar
dotnet clean
dotnet build
```

## Boas Práticas

1. **Executar testes antes de commits**
   ```bash
   dotnet test && git commit
   ```

2. **Executar testes em CI/CD**
   - GitHub Actions
   - Azure DevOps
   - Jenkins

3. **Manter testes rápidos**
   - Testes unitários: < 100ms
   - Testes de integração: < 1s
   - Testes de UI: < 10s

4. **Revisar cobertura regularmente**
   ```bash
   dotnet test --collect:"XPlat Code Coverage"
   reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coverage
   ```

## Conclusão

Esta suite de testes fornece cobertura abrangente das funcionalidades principais do app de cadastro de carros, com foco em testes executáveis e práticos que não dependem de infraestrutura complexa de UI.
