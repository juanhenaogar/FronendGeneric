# InvestigacionFront

Proyecto base en **Blazor Web App** para **.NET 9** con CRUD de front-end del módulo de investigación.

## Incluye

- Grupos de investigación
- Semilleros
- Participación de docentes en grupos
- Participación de docentes en semilleros
- Relaciones de líneas (`grupo_linea`, `semillero_linea`, `aa_linea`, `ac_linea`, `ods_linea`)

## Cómo ejecutarlo

```bash
dotnet restore
dotnet run
```

## Notas

- No requiere backend.
- Todos los datos están en memoria dentro de `Services/InvestigacionDataService.cs`.
- Si luego quieres conectarlo a API, puedes conservar las páginas y reemplazar ese servicio.
