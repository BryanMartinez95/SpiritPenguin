#SpiritPenguin

##Useful Database Commands
dotnet ef migrations add {MIGRATION_NAME} --add migration
dotnet ef database update  --update database
dotnet ef database update {MIGRATION_NAME} -- target a specific migration
dotnet ef migrations remove -- removes last migration
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/providers <- look over if i want to multiple databases