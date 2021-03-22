Создать новое консольное приложение
```cmd
dotnet new console
```
Для запуска
```cmd
dotnet run
```



Сборка проекта и его зависимостей:

```dotnetcli
dotnet build
```

Сборка проекта и его зависимостей с помощью конфигурации Release:

```dotnetcli
dotnet build --configuration Release
```

Сборка проекта и его зависимостей для конкретной среды выполнения (в данном примере Ubuntu 18.04):

```dotnetcli
dotnet build --runtime ubuntu.18.04-x64
```

Выполните сборку проекта и используйте указанный источник пакета NuGet во время операции восстановления.

```dotnetcli
dotnet build --source c:\packages\mypackages
```

Выполните сборку проекта и задайте версию 1.2.3.4 для сборки с помощью параметра `-p`

```dotnetcli
dotnet build -p:Version=1.2.3.4
```

Публикация приложение и его зависимостей в папке для развертывания

```
dotnet publish
```
```
dotnet publish -c Release -r win-x64
```

```
dotnet publish -c Release -r win-x64 --output myapp
```

