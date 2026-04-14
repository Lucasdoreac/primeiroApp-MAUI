# 🍎 Instruções para Rodar no Mac Catalyst

## 🔧 **Opção 1: Instalar Workload MAUI**

### **Passo 1: Executar Script de Instalação**
```bash
cd /Users/lucascardoso/dotnet-maui
./install_maui_workload.sh
```

### **Passo 2: Rodar o App**
```bash
cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp
dotnet run --framework net8.0-maccatalyst
```

---

## 🖥️ **Opção 2: Visual Studio for Mac (Mais Fácil)**

### **Requisitos:**
- Visual Studio for Mac 2022 (ou superior)
- Xcode (última versão)
- macOS 12 (Monterey) ou superior

### **Passos:**
1. **Baixar Visual Studio for Mac:**
   - Acessar: https://visualstudio.microsoft.com/vs/mac/
   - Download Visual Studio 2022

2. **Instalar Workloads:**
   - Durante instalação, selecionar: **.NET MAUI**
   - Ou após instalação: Visual Studio → Installer → Adicionar Workloads → .NET MAUI

3. **Abrir Projeto:**
   ```bash
   open -a "Visual Studio"
   # File → Open → selecionar PrimeiroApp.sln
   ```

4. **Rodar:**
   - Selecionar projeto → **Start** (▶️)
   - Ou **F5**

---

## 🍎 **Opção 3: Usar Xcode Diretamente (Desenvolvimento Native)**

### **Passos:**
1. **Abrir Xcode:**
   ```bash
   open -a Xcode
   # File → Open → selecionar PrimeiroApp.csproj
   ```

2. **Selecionar Target:**
   - **myapp (Mac Catalyst)** ou **myapp.MacCatalyst**

3. **Rodar:**
   - ▶️ (Run button)
   - Ou **Cmd + R**

---

## 🐛 **Solução de Problemas Comuns**

### **Erro: "MAUI workload not installed"**
```bash
# Instalar workload manualmente
dotnet workload install maui
```

### **Erro: "No Apple Developer account found"**
- Xcode → Preferences → Accounts
- Adicionar Apple ID

### **Erro: " Provisioning profile required"**
- Xcode → Signing & Capabilities
- Selecionar "Automatically manage signing"

---

## 🎯 **Opção Mais Rápida (Recomendada para Aula)**

### **Usar Visual Studio for Mac:**
1. Install Visual Studio for Mac 2022
2. Selecionar workload ".NET MAUI" durante instalação
3. Abrir `PrimeiroApp.sln`
4. Apertar **F5**

**Visual Studio for Mac** gerencia automaticamente todas as dependências e workloads!

---

## 📱 **App Funciona Perfeitamente Em:**
- ✅ **Windows** (Visual Studio 2022) - RECOMENDADO
- ✅ **Mac** (Visual Studio for Mac ou Xcode)
- ✅ **iOS Simulator** (Mac + Xcode)
- ✅ **Android** (Visual Studio 2022 + Emulador)

---

**Para sua aula, o Windows com Visual Studio 2022 é a opção mais simples e rápida!**