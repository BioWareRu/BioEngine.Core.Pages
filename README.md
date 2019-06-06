# Модуль Pages

Реализация контентной сущности `Страница` для BioEngine. Подходит для создания страниц с фиксированным адресом, не входящих в разделы и ленты

- Сущность `Page`
- Репозиторий `PagesRepository`
- Провайдера поиска `PagesSearchProvider`
- Провайдер карты сайта `PagesSiteMapNodeService`
- Базовый контроллер и сущность для API 

## Установка

```csharp
bioengine.AddModule<PagesModule>();
```
