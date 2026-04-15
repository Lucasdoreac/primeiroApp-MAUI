# 🔧 Setup Cursor para .NET MAUI

## 📊 **Status Atual:**
- ✅ **Cursor 2.3.35** instalado
- ✅ **.NET SDK 9.0.301** instalado
- ✅ **Xcode 26.2** instalado
- ❌ **Extensões .NET** precisam ser instaladas manualmente

## 🔍 **Problema:**
Extensões Microsoft não estão disponíveis via CLI no Cursor. Precisa instalar manualmente.

## ✅ **Solução - Instalação Manual:**

### **Passo 1: Abrir Cursor**
```bash
cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp
cursor .
```

### **Passo 2: Instalar Extensões Manualmente**

No Cursor:
1. **Cmd + Shift + X** (Extensions)
2. Pesquisar e instalar:

#### **Essencial:**
- **C# Dev Kit** (ms-dotnettools.cscode)
- **C#** (ms-dotnettools.csharp)

#### **Recomendado:**
- **NuGet Package Manager** (jmrog.vscode-nuget-package-manager)
- **XML Tools** (DotJoshJohnson.xml)

### **Passo 3: Abrir Projeto**
No Cursor:
- **File → Open Folder**
- Selecionar: `/Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp`

## 🚀 **Para Desenvolver:**

### **Comandos Úteis no Terminal Integrado:**
```bash
# Build
dotnet build

# Run (se workstation configurado)
dotnet run

# Clean
dotnet clean
```

## 🎯 **Limitações do Cursor vs Visual Studio:**

**Cursor (VS Code fork):**
- ✅ Leve e rápido
- ✅ Bom para editar código
- ❌ **SEM designer XAML visual**
- ❌ **SEM debugging MAUI fácil**
- ❌ **SEM IntelliSense completo para XAML**

**Visual Studio 2022 (Windows):**
- ✅ Designer XAML visual
- ✅ Debugging completo
- ✅ IntelliSense completo
- ✅ Hot reload
- ✅ É a ferramenta oficial MAUI

## 🎯 **Para Sua Aula:**

**Use Windows + Visual Studio 2022!**
- Cursor é bom para **editar código**
- Mas VS 2022 é necessário para **desenvolver MAUI profissionalmente**
- Designer visual + debugging + hot reload

**Cursor pode ser usado no Mac** para:
- Editar código C#
- Ver arquivos XAML
- Fazer pequenos ajustes

Mas para **desenvolvimento sério**, VS 2022 é muito melhor!

## 📋 **Resumo:**
✅ **Cursor configurado** (extensões instalar manualmente)
✅ **Pode editar código**
⚠️ **Para desenvolver MAUI: Use VS 2022 no Windows**