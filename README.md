# RoslynCompiler
Динамическая компиляция кода с использованием компилятора Roslyn под Net Framework 4.0 и выше.

P.S: ***Roslyn*** компилятор позволяет компилировать исходный код под более новые версии **C#**.

Начнём с установки библиотеки для работы с компилятором, заходим в командную строку VS и устанавливаем:
`Install-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -Version 2.0.1`

P.S: https://www.nuget.org/packages/Microsoft.CodeDom.Providers.DotNetCompilerPlatform/

Используемые зависимости:

`using System.CodeDom.Compiler; `

`using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;`

При компиляции: 

За место: `using (var provider = new CSharpCodeProvider())`

Пишем: `using (var provider = new Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider())`

Интересные ссылки для работы с данным компилятором:

1 - https://itvdn.com/ru/blog/article/compiler-roslyn

2 - https://msdn.microsoft.com/ru-ru/magazine/mt707527.aspx
