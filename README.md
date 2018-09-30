# RoslynCompiler
Динамическая компиляция кода с использованием компилятора Roslyn под Net Framework 4.0.

P.S: ***Roslyn*** компилятор позволяет компилировать исходный код под более новые версии **C#**.
### Загрузка Microsoft Visual Studio 2017 Pro + Keys
Для начала работы потребуется студия которую Вы можете загрузить [Здесь](https://visualstudio.microsoft.com/ru/downloads/). Выбераем *Professional Free* версию и загружаем. 
После устанавливаем нужные компоненты и запускаем саму студию. 

Активируем студию при помощи ключа: 
* KBJFW-NXHK6-W4WJM-CRMQB-G3CDH
* HMGNV-WCYXV-X7G9W-YCX63-B98R2

### Установка Roslyn
Предусловия: В компиляторе были замечены некоторые баги о которых я сейчас расскажу:

Начнём с установки библиотеки для работы с компилятором, заходим в командную строку VS и устанавливаем:
`Install-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -Version 2.0.1`
- https://www.nuget.org/packages/Microsoft.CodeDom.Providers.DotNetCompilerPlatform/
В этой библиотеки есть баг в котором не находит путь до папки Roslyn

Способ решения для первой библиотеки:

```
public static void FixRoslynPath(CSharpCodeProvider CSCP)
{
   try
   {
     object compilerSettings = typeof(CSharpCodeProvider).
     GetField("_compilerSettings", BindingFlags.Instance |
     BindingFlags.NonPublic).GetValue(CSCP);
     FieldInfo compilerSettingsFullPathField = compilerSettings.
     GetType().GetField("_compilerFullPath", BindingFlags.Instance |
     BindingFlags.NonPublic);
     compilerSettingsFullPathField.SetValue(compilerSettings, ((string)compilerSettingsFullPathField.
     GetValue(compilerSettings)).Replace(@"bin\roslyn\", @"roslyn\"));
   }
   catch (Exception Error)
   {
     File.WriteAllText("FixerPath_Error.txt", $"{Error.ToString()}");
   }
}
```
После используем так:
Используемые зависимости:
```
using System.CodeDom.Compiler;
using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;

 using (var provider = new CSharpCodeProvider())
 {
    FixRoslynPath(provider); // Теперь папка bin\roslyn будет работать корректно
    ...
 }
```
Или же используйте BinFix библиотеку в которой уже пофиксен данный баг:

`Install-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform.BinFix -Version 1.0.0`

Интересные ссылки для работы с данным компилятором:

- https://itvdn.com/ru/blog/article/compiler-roslyn
- https://msdn.microsoft.com/ru-ru/magazine/mt707527.aspx
