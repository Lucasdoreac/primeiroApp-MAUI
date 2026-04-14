#!/bin/bash
# Script para instalar MAUI workload no Mac

echo "🔧 Instalando MAUI workload para .NET..."

# Tentar instalação sem sudo primeiro
dotnet workload install maui --dotnet-dir /usr/local/share/dotnet

if [ $? -ne 0 ]; then
    echo "⚠️ Permissões insuficientes. Tentando com sudo..."
    echo "Você precisará digitar sua senha de administrador."

    # Instalar com sudo
    sudo dotnet workload install maui --dotnet-dir /usr/local/share/dotnet

    if [ $? -eq 0 ]; then
        echo "✅ MAUI workload instalado com sucesso!"

        # Verificar instalação
        echo "📋 Verificando workloads instalados..."
        dotnet workload list

        echo "🚀 Agora você pode rodar o app:"
        echo "cd /Users/lucascardoso/dotnet-maui/src/PrimeiroApp/PrimeiroApp"
        echo "dotnet run --framework net8.0-maccatalyst"
    else
        echo "❌ Falha na instalação. Verifique se o Visual Studio ou Xcode estão instalados."
    fi
else
    echo "✅ MAUI workload instalado com sucesso!"
    dotnet workload list
fi