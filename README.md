# InventoryAspCore
Sample app using AspNet Core MVC and Razor Pages

## Database installation
- Download Docker Desktop
- Execute:
```docker run --name InventoryDb -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Strong@Password" -p 11433:1433 -d mcr.microsoft.com/mssql/server:2019-latest```
- Download Sql Server Management Studio https://aka.ms/ssmsfullsetup
and connect to `localhost,11433`

## Aproximación database-first
###### Crear contexto
```dotnet ef dbcontext scaffold "Data Source=localhost,11433; Initial Catalog=InventoryDb;user Id=sa; password=Strong@Password;Trust Server Certificate=true" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models```

## Aproximación code-first
Creamos el modelo
###### Generar un cambio en BD
dotnet ef migrations add initialCreate --verbose --project Infrastructure -s .\InventoryAspCore\
###### Actualizar la BD
dotnet ef database update --verbose --project Infrastructure -s .\InventoryAspCore\



migrationBuilder.UpdateData(
    table: "RequestValidationErrors", 
    keyColumn: "WordCode", 
    keyValue: "RequestValidationError.MoreThanOneItemFound", 
    column: "IsBreaking", 
    value: false);


public override void Up()
{
    AddColumn("dbo.RequestValidationErrors", "IsBreaking", c => c.Boolean(nullable: false, default: true));
    Sql("UPDATE dbo.RequestValidationErrors SET IsBreaking = 0 WHERE WordCode = \"RequestValidationError.MoreThanOneItemFound\"");
}




