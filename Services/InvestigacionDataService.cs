using InvestigacionFront.Models;

namespace InvestigacionFront.Services;

public class InvestigacionDataService
{
    public List<string> Universidades { get; } = new()
    {
        "Universidad de Antioquia",
        "Universidad Nacional",
        "ITM",
        "UPB"
    };

    public List<string> Categorias { get; } = new() { "A1", "A", "B", "C", "Reconocido" };
    public List<string> Ambitos { get; } = new() { "Local", "Regional", "Nacional", "Internacional" };
    public List<string> Docentes { get; } = new() { "1039456789", "71717171", "43219876", "90011223" };
    public List<string> RolesGrupo { get; } = new() { "Director", "Investigador", "Co-investigador", "Auxiliar" };
    public List<string> RolesSemillero { get; } = new() { "Tutor", "Director", "Coordinador" };
    public List<string> LineasInvestigacion { get; } = new() { "IA aplicada", "Transformación digital", "Educación", "Sostenibilidad" };
    public List<string> AreasAplicacion { get; } = new() { "Salud", "Industria", "Educación", "Movilidad" };
    public List<string> AreasConocimiento { get; } = new() { "Ingeniería", "Ciencias Sociales", "Matemáticas", "Tecnología" };
    public List<string> Ods { get; } = new() { "ODS 4", "ODS 8", "ODS 9", "ODS 11" };

    private readonly List<GrupoInvestigacion> _grupos = new()
    {
        new() { Id = 1, Nombre = "GI Innovación Digital", UrlGruplac = "https://grupLAC.example/1", Categoria = "A1", Convocatoria = "2024", FechaFundacion = new DateTime(2018, 5, 10), Universidad = "ITM", Interno = true, Ambito = "Nacional" },
        new() { Id = 2, Nombre = "GI Analítica Aplicada", UrlGruplac = "https://grupLAC.example/2", Categoria = "B", Convocatoria = "2023", FechaFundacion = new DateTime(2020, 8, 25), Universidad = "UPB", Interno = false, Ambito = "Regional" }
    };

    private readonly List<Semillero> _semilleros = new()
    {
        new() { Id = 1, Nombre = "Semillero DataLab", FechaFundacion = new DateTime(2021, 2, 15), GrupoInvestigacionId = 1 },
        new() { Id = 2, Nombre = "Semillero InnovaTec", FechaFundacion = new DateTime(2022, 7, 20), GrupoInvestigacionId = 2 }
    };

    private readonly List<ParticipaGrupo> _participaGrupos = new()
    {
        new() { Id = 1, DocenteCedula = "1039456789", GrupoInvestigacionId = 1, Rol = "Director", FechaInicio = new DateTime(2022, 1, 15) },
        new() { Id = 2, DocenteCedula = "71717171", GrupoInvestigacionId = 2, Rol = "Investigador", FechaInicio = new DateTime(2023, 2, 10) }
    };

    private readonly List<ParticipaSemillero> _participaSemilleros = new()
    {
        new() { Id = 1, Docente = "43219876", SemilleroId = 1, Rol = "Tutor", FechaInicio = new DateTime(2024, 1, 12) },
        new() { Id = 2, Docente = "90011223", SemilleroId = 2, Rol = "Director", FechaInicio = new DateTime(2024, 4, 3) }
    };

    private readonly List<RelacionSimple> _relaciones = new()
    {
        new() { Id = 1, TipoRelacion = "grupo_linea", Origen = "GI Innovación Digital", Destino = "IA aplicada" },
        new() { Id = 2, TipoRelacion = "semillero_linea", Origen = "Semillero DataLab", Destino = "Transformación digital" },
        new() { Id = 3, TipoRelacion = "aa_linea", Origen = "IA aplicada", Destino = "Industria" },
        new() { Id = 4, TipoRelacion = "ac_linea", Origen = "Sostenibilidad", Destino = "Ingeniería" },
        new() { Id = 5, TipoRelacion = "ods_linea", Origen = "Educación", Destino = "ODS 4" }
    };

    public List<GrupoInvestigacion> GetGrupos() => _grupos.OrderBy(x => x.Id).ToList();
    public void AddGrupo(GrupoInvestigacion item)
    {
        item.Id = _grupos.Any() ? _grupos.Max(x => x.Id) + 1 : 1;
        _grupos.Add(item);
    }
    public void UpdateGrupo(GrupoInvestigacion item)
    {
        var current = _grupos.First(x => x.Id == item.Id);
        current.Nombre = item.Nombre;
        current.UrlGruplac = item.UrlGruplac;
        current.Categoria = item.Categoria;
        current.Convocatoria = item.Convocatoria;
        current.FechaFundacion = item.FechaFundacion;
        current.Universidad = item.Universidad;
        current.Interno = item.Interno;
        current.Ambito = item.Ambito;
    }
    public void DeleteGrupo(int id) => _grupos.RemoveAll(x => x.Id == id);

    public List<Semillero> GetSemilleros() => _semilleros.OrderBy(x => x.Id).ToList();
    public void AddSemillero(Semillero item)
    {
        item.Id = _semilleros.Any() ? _semilleros.Max(x => x.Id) + 1 : 1;
        _semilleros.Add(item);
    }
    public void UpdateSemillero(Semillero item)
    {
        var current = _semilleros.First(x => x.Id == item.Id);
        current.Nombre = item.Nombre;
        current.FechaFundacion = item.FechaFundacion;
        current.GrupoInvestigacionId = item.GrupoInvestigacionId;
    }
    public void DeleteSemillero(int id) => _semilleros.RemoveAll(x => x.Id == id);

    public List<ParticipaGrupo> GetParticipaGrupos() => _participaGrupos.OrderBy(x => x.Id).ToList();
    public void AddParticipaGrupo(ParticipaGrupo item)
    {
        item.Id = _participaGrupos.Any() ? _participaGrupos.Max(x => x.Id) + 1 : 1;
        _participaGrupos.Add(item);
    }
    public void UpdateParticipaGrupo(ParticipaGrupo item)
    {
        var current = _participaGrupos.First(x => x.Id == item.Id);
        current.DocenteCedula = item.DocenteCedula;
        current.GrupoInvestigacionId = item.GrupoInvestigacionId;
        current.Rol = item.Rol;
        current.FechaInicio = item.FechaInicio;
        current.FechaFin = item.FechaFin;
    }
    public void DeleteParticipaGrupo(int id) => _participaGrupos.RemoveAll(x => x.Id == id);

    public List<ParticipaSemillero> GetParticipaSemilleros() => _participaSemilleros.OrderBy(x => x.Id).ToList();
    public void AddParticipaSemillero(ParticipaSemillero item)
    {
        item.Id = _participaSemilleros.Any() ? _participaSemilleros.Max(x => x.Id) + 1 : 1;
        _participaSemilleros.Add(item);
    }
    public void UpdateParticipaSemillero(ParticipaSemillero item)
    {
        var current = _participaSemilleros.First(x => x.Id == item.Id);
        current.Docente = item.Docente;
        current.SemilleroId = item.SemilleroId;
        current.Rol = item.Rol;
        current.FechaInicio = item.FechaInicio;
        current.FechaFin = item.FechaFin;
    }
    public void DeleteParticipaSemillero(int id) => _participaSemilleros.RemoveAll(x => x.Id == id);

    public List<RelacionSimple> GetRelaciones() => _relaciones.OrderBy(x => x.Id).ToList();
    public void AddRelacion(RelacionSimple item)
    {
        item.Id = _relaciones.Any() ? _relaciones.Max(x => x.Id) + 1 : 1;
        _relaciones.Add(item);
    }
    public void UpdateRelacion(RelacionSimple item)
    {
        var current = _relaciones.First(x => x.Id == item.Id);
        current.TipoRelacion = item.TipoRelacion;
        current.Origen = item.Origen;
        current.Destino = item.Destino;
    }
    public void DeleteRelacion(int id) => _relaciones.RemoveAll(x => x.Id == id);

    public string GetNombreGrupo(int id) => _grupos.FirstOrDefault(x => x.Id == id)?.Nombre ?? "N/D";
    public string GetNombreSemillero(int id) => _semilleros.FirstOrDefault(x => x.Id == id)?.Nombre ?? "N/D";
}
