# TODO

Create migrations:
```console
dotnet ef migrations add [MIGRATION_NAME] --project TODO.Infrastructure --startup-project TODO.Api --output-dir Database\Migrations
```

Run migrations:

```console
dotnet ef database update --project TODO.Infrastructure --startup-project TODO.Api
```