#!/bin/bash
# 🔧 Instalação MAUI Workload para Mac Catalyst

echo "🚀 Instalando MAUI Workload para .NET no Mac..."

echo "📋 Passo 1: Instalando workload..."
sudo dotnet workload install maccatalyst

if [ $? -eq 0 ]; then
    echo "✅ Workload instalado com sucesso!"

    echo "📋 Passo 2: Verificando instalação..."
    dotnet workload list

    echo "📋 Passo 3: Buildando o app..."
    cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp
    dotnet build --framework net8.0-maccatalyst

    if [ $? -eq 0 ]; then
        echo "🎉 Build bem-sucedido!"
        echo "🚀 Rodando o app..."
        dotnet run --framework net8.0-maccatalyst
    else
        echo "❌ Erro no build"
    fi
else
    echo "❌ Erro na instalação do workload"
    echo "📋 Tente instalar Visual Studio for Mac como alternativa"
fi