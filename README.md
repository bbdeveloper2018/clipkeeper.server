# ClipKeeper Server

## Database
Entity Framework Core is used with SQLite.  To created the migration scripts, ensure the following:

* Startup project is set to ClipKeeper.Server.WebService
* The Default project in the Package Manager Console is ClipKeeper.Server.Data
* A successful solution build

### For First Migration script:
```
PM> add-migration initial
```

### For Updates to schema script:
```
PM> update-migration
```

### Automatic Migration
Whenever the server starts up, it will ensure the database is created automatically.

