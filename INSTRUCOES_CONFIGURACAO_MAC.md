# 🍎 Configuração Mac para Rodar .NET MAUI

## 📊 **Status Atual do Mac**

### ✅ **Já Instalado:**
- **Xcode 26.2** ✅ (Build 17C52)
- **macOS 15.7.6** ✅ (Monterey)
- **.NET SDKs:** ✅
  - 9.0.301
  - 11.0.100-preview.3.26207.106
- **Xcode Developer Tools:** ✅
- **MacOSX SDK:** ✅ (`/Applications/Xcode.app/Contents/Developer/Platforms/MacOSX.platform/Developer/SDKs/MacOSX.sdk`)

### ❌ **Falta Instalar:**
- **MAUI Workload** ❌ (necessário para Mac Catalyst)

---

## 🔧 **Opção 1: Instalar Workload MAUI (Recomendado)**

### **Passo 1: Executar Script**
```bash
cd /Users/lucascardoso/dotnet-maui
./instrucoes_mac.sh
```

**O que o script faz:**
1. Instala `maccatalyst` workload (requer senha de admin)
2. Verifica instalação
3. Builda o projeto
4. Roda o app

### **Passo 2: Build Manual (se script falhar)**
```bash
# Instalar workload manualmente
sudo dotnet workload install maccatalyst

# Verificar instalação
dotnet workload list

# Buildar projeto
cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp
dotnet build --framework net8.0-maccatalyst

# Rodar app
dotnet run --framework net8.0-maccatalyst
```

---

## 🖥️ **Opção 2: Visual Studio for Mac (Mais Fácil)**

### **Requisitos:**
- Visual Studio for Mac 2022 (ou superior)
- Xcode (já instalado ✅)
- macOS 12 (Monterey) ou superior ✅

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

## 🚀 **Opção 3: Usar Xcode Diretamente**

### **Passos:**
1. **Build com .NET:**
   ```bash
   cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp
   dotnet build --framework net8.0-maccatalyst
   ```

2. **Abrir no Xcode:**
   ```bash
   open -a Xcode
   # File → Open → selecionar PrimeiroApp.csproj
   ```

3. **Selecionar Target:**
   - **myapp (Mac Catalyst)** ou **myapp.MacCatalyst**

4. **Rodar:**
   - ▶️ (Run button)
   - Ou **Cmd + R**

---

## 🎯 **Recomendação Para Sua Aula**

### **Windows (Visual Studio 2022) - Mais Fácil:**
1. Clonar repositório no Windows
2. Abrir `PrimeiroApp.sln`
3. Build & Run (F5)

**Visual Studio 2022 já vem com .NET MAUI configurado!**

### **Mac (Para Testar Localmente):**
- **Opção mais rápida:** Instalar workload com `./instrucoes_mac.sh`
- **Opção mais fácil:** Visual Studio for Mac

---

## 📊 **Resumo Tópico de Hardware/Software**

### ✅ **Hardware/SO OK:**
- **Mac:** macOS 15.7.6 (Monterey)
- **Xcode:** 26.2 (última versão)
- **Compilador:** Clang/LLVM integrado
- **SDK:** MacOSX SDK completo

### ⚠️ **Só Precisa:**
- **MAUI Workload** (5-10 minutos de instalação)
- Ou **Visual Studio for Mac** (30 minutos download + install)

---

## 🔥 **Para Testar Imediatamente:**

```bash
# Tente rodar o script (vai pedir senha de admin)
cd /Users/lucascardoso/dotnet-maui
./instrucoes_mac.sh
```

**Se pedir senha de admin:** entre com sua senha de usuário do Mac.

**Se funcionar:** O app vai abrir automaticamente no Mac!

---

**Especificação v1.0 - 15/04/2026**
**Status: Pronto para configurar**
**Opção recomendada: Windows (VS 2022) para aula, Mac para testes locais**