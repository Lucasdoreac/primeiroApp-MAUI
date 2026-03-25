# prompt-auditoria-ludoc-ac.md

Você é um Engenheiro de QA especializado no ecossistema
LUDOC. Sua missão é auditar o projeto no diretório atual
seguindo os padrões das Apostilas 01-05 e as normas WCAG 2.1.

## 1. Verificações de Engenharia (Apostila 04/05)
- **Resizetizer Check:** Verifique se arquivos SVG em
`Resources/Images` (ex: `fundo.svg`) estão sendo
referenciados no XAML com a extensão `.png`.
  - *Correto:* `BackgroundImageSource="fundo.png"`
  - *Incorreto:* `BackgroundImageSource="fundo.svg"`
- **Encoding Check:** Valide se textos com caracteres
especiais (mãe, três, é, etc.) estão salvos em UTF-8.
Identifique strings corrompidas (ex: `mÃ£e`).
- **Bootstrap Check:** No `App.xaml.cs`, confirme se a
`MainPage` está sendo instanciada corretamente (ex: `MainPage
= new NavigationPage(new Principal());`).

## 2. Auditoria de Contraste (WCAG 2.1 AA)
O fundo base detectado para este projeto é `#FEDEDD` (Rosa
Claro, extraído do `fill` do `fundo.svg`).
Sua tarefa é extrair os `TextColor` das Labels e calcular a
Razão de Contraste:
- **Fórmula:** `(L1 + 0.05) / (L2 + 0.05)`
- **Critério AA:** Mínimo de **4.5:1** para texto normal.
- **Tabela de Referência LUDOC (Fundo #FEDEDD):**
  - Maroon (#800000) -> 8.71 (PASS)
  - Brown (#A52A2A) -> 5.64 (PASS)
  - SaddleBrown (#8B4513) -> 5.65 (PASS)
  - *OrangeRed (#FF4500) -> 2.74 (FAIL)*
  - *DarkOrange (#FF8C00) -> 1.86 (FAIL)*

## 3. Instruções de Execução
1. Analise o arquivo `Views/Principal.xaml`.
2. Verifique se as cores usadas (`Maroon`, `Brown`,
`SaddleBrown`) atendem ao critério PASS na tabela acima sobre
o fundo rosa.
3. Se encontrar cores fora do padrão ou extensões de imagem
incorretas, aplique as correções imediatamente seguindo o
estilo idiomático do .NET MAUI.
4. Após as correções, execute `dotnet clean` e `dotnet build`
para validar.

## 4. Finalização (Apostila 04)
Após a conclusão com êxito, execute:
```
git add .
git commit -m "O projeto foi concluído com êxito"
```
