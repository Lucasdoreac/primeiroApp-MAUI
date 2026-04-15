#!/bin/bash
# 🔧 Script para configurar Mac para rodar .NET MAUI

echo "🚀 Configurando Mac para .NET MAUI..."
echo "📋 Você precisará de privilégios de administrador (sudo)"

# 1. Instalar workload MAUI
echo "📦 Passo 1: Instalando MAUI workload..."
sudo dotnet workload install maccatalyst

if [ $? -eq 0 ]; then
    echo "✅ Workload instalado com sucesso!"
else
    echo "❌ Erro ao instalar workload"
    echo "📋 Tente alternativa: Visual Studio for Mac"
    exit 1
fi

# 2. Verificar instalação
echo "📋 Passo 2: Verificando instalação..."
dotnet workload list

# 3. Build do projeto
echo "🔨 Passo 3: Buildando projeto..."
cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp
dotnet build --framework net8.0-maccatalyst

if [ $? -eq 0 ]; then
    echo "🎉 Build bem-sucedido!"
    echo "🚀 Rodando o app..."
    dotnet run --framework net8.0-maccatalyst
else
    echo "❌ Erro no build"
fi