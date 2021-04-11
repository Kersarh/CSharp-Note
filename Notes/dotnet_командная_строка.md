Создать новое консольное приложение
```cmd
dotnet new console
```
Для запуска
```cmd
dotnet run
```

Сборка проекта и его зависимостей:

```bash
dotnet build
```

Сборка проекта и его зависимостей с помощью конфигурации Release:

```bash
dotnet build --configuration Release
```

Сборка проекта и его зависимостей для конкретной среды выполнения (в данном примере Ubuntu 18.04):

```bash
dotnet build --runtime ubuntu.18.04-x64
```

Выполните сборку проекта и используйте указанный источник пакета NuGet во время операции восстановления.

```bash
dotnet build --source c:\packages\mypackages
```

Выполните сборку проекта и задайте версию 1.2.3.4 для сборки с помощью параметра `-p`

```bash
dotnet build -p:Version=1.2.3.4
```

Публикация приложение и его зависимостей в папке для развертывания

```bash
dotnet publish
```
```bash
dotnet publish -c Release -r win-x64
```

```bash
dotnet publish -c Release -r win-x64 --output myapp
```

```bash
dotnet publish --self-contained -c release -r win10-x64 -p:PublishTrimmed=True -p:TrimMode=Link -p:PublishSingleFile=true -p:IncludeAllContentForSelfExtract=true
```