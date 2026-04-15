#!/bin/bash
# 🔧 SOLUÇÃO CORRIGIDA para Mac

echo "🚀 Instalando workload MAUI CORRETO..."
echo "📋 Isso vai levar 5-10 minutos"

# Instalar o workload correto
sudo dotnet workload install maui-maccatalyst

if [ $? -eq 0 ]; then
    echo "✅ Workload instalado!"
    echo "🔨 Buildando projeto..."

    cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp

    # Tentar build
    dotnet build --framework net9.0-maccatalyst

    if [ $? -eq 0 ]; then
        echo "🎉 Build bem-sucedido!"
        echo "🚀 Rodando app..."
        dotnet run --framework net9.0-maccatalyst
    else
        echo "❌ Erro no build"
        echo "📋 Tentando alternativa..."

        # Alternativa: usar net8.0
        sed -i '' 's/<TargetFramework>net9.0<\/TargetFramework>/<TargetFramework>net8.0<\/TargetFramework>/g' PrimeiroApp.csproj
        sed -i '' 's/Version="9.0.0"/Version="8.0.7"/g' PrimeiroApp.csproj

        dotnet build --framework net8.0-maccatalyst

        if [ $? -eq 0 ]; then
            echo "🎉 Build bem-sucedido com net8.0!"
            dotnet run --framework net8.0-maccatalyst
        fi
    fi
else
    echo "❌ Erro na instalação do workload"
    echo "📋 Alternativa: Usar Visual Studio for Mac"
    echo "📦 Download: https://visualstudio.microsoft.com/vs/mac/"
fi