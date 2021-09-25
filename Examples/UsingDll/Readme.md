Для VS studio

Создадим новый проект Class Library
Создаем в нем необходимую нам логику и собираем проект.

В основном проекте - ПКМ (по проекту) - Добавить - Ссылка на проект.

Если есть только dll то жмем на кнопку обзор внизу.



В файле *.csproj основного поекта в секции <ItemGroup> прописываем путь к проекту с DLL.

```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\MyDll\MyDll.csproj" />
  </ItemGroup>

</Project>

```

 Если есть только dll

```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

<ItemGroup>
    <Reference Include="MyDll">
      <HintPath>..\MyDll\bin\Debug\net5.0\MyDll.dll</HintPath>
    </Reference>
  </ItemGroup>

</Project>
```

