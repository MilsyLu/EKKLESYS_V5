using System;
using System.Collections.Generic;

namespace ENTITY
{
    public class DashboardDTO
    {
        // Estadísticas de Usuarios
        public int TotalUsuarios { get; set; }
        public int TotalMiembros { get; set; }
        public int TotalAdministradores { get; set; }
        public int UsuariosRegistradosEsteMes { get; set; }

        // Estadísticas de Cursos
        public int TotalCursos { get; set; }
        public int CursosActivos { get; set; }
        public int TotalInscripciones { get; set; }
        public int InscripcionesEsteMes { get; set; }

        // Estadísticas de Eventos
        public int TotalEventos { get; set; }
        public int EventosProximos { get; set; }
        public int TotalAsistencias { get; set; }
        public int AsistenciasEsteMes { get; set; }

        // Listas para mostrar detalles
        public List<CursoPopularDTO> CursosMasPopulares { get; set; }
        public List<EventoProximoDTO> ProximosEventos { get; set; }
        public List<UsuarioRecienteDTO> UsuariosRecientes { get; set; }

        public DashboardDTO()
        {
            CursosMasPopulares = new List<CursoPopularDTO>();
            ProximosEventos = new List<EventoProximoDTO>();
            UsuariosRecientes = new List<UsuarioRecienteDTO>();
        }
    }

    public class CursoPopularDTO
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int NumeroInscripciones { get; set; }
        public DateTime FechaInicio { get; set; }
        public int CapacidadMaxima { get; set; }
        public decimal PorcentajeOcupacion { get; set; }
    }

    public class EventoProximoDTO
    {
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Lugar { get; set; }
        public int NumeroAsistentes { get; set; }
        public int CapacidadMaxima { get; set; }
        public int DiasRestantes { get; set; }
    }

    public class UsuarioRecienteDTO
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string EsMiembro { get; set; }
        public string EsAdministrador { get; set; }
    }

    public class EstadisticaMensualDTO
    {
        public int Mes { get; set; }
        public string NombreMes { get; set; }
        public int Cantidad { get; set; }
    }
}
