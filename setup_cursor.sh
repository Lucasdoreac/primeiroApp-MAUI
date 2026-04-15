#!/bin/bash
# 🔧 Setup Cursor para .NET MAUI no Mac

echo "🚀 Configurando Cursor para .NET MAUI..."
echo "📋 Isso vai instalar as extensões necessárias"

# 1. Extensão C# (Essencial)
echo "📦 Instalando C# Dev Kit..."
cursor --install-extension ms-dotnettools.cscode

# 2. Extensão C# (Alternativa se acima falhar)
if [ $? -ne 0 ]; then
    echo "📦 Tentando C# extension alternativa..."
    cursor --install-extension ms-dotnettools.csharp-dev-kit
fi

# 3. .NET Install Tool (Para gerenciar SDKs)
echo "📦 Instalando .NET Install Tool..."
cursor --install-extension ms-dotnettools.vscode-dotnet-runtime

# 4. NuGet Package Manager
echo "📦 Instalando NuGet Package Manager..."
cursor --install-extension jmrog.vscode-nuget-package-manager

# 5. XML Tools (para .csproj)
echo "📦 Instalando XML Tools..."
cursor --install-extension DotJoshJohnson.xml

# 6. MAUI Extension (Se disponível)
echo "📦 Verificando extensão MAUI..."
# Nota: MAUI extension pode não estar disponível para Cursor, apenas para VS

echo "✅ Extensões instaladas!"
echo "🔨 Abrindo projeto..."

cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp

# Abrir Cursor no projeto
cursor .