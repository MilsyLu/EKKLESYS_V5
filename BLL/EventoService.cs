﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class EventoService
    {
        private readonly EventoRepository eventoRepository;
        private readonly AsistenciaEventoRepository asistenciaEventoRepository;
        private readonly UsuarioRepository usuarioRepository;
        private readonly EmailNotificationService emailNotificationService;
        private readonly string connectionString;

        public EventoService()
        {
            connectionString = "Data Source=localhost;Initial Catalog=IglesiaDB;Integrated Security=True";
            var connectionManager = new ConnectionManager();
            usuarioRepository = new UsuarioRepository(connectionManager);
            eventoRepository = new EventoRepository(connectionManager);
            asistenciaEventoRepository = new AsistenciaEventoRepository(connectionManager, usuarioRepository);
            emailNotificationService = new EmailNotificationService();
        }

        public string Guardar(Evento evento)
        {
            try
            {
                if (evento.fecha_inicio_evento > evento.fecha_fin_evento)
                {
                    return "Error al guardar: La fecha de inicio no puede ser posterior a la fecha de fin";
                }

                eventoRepository.Guardar(evento);

                try
                {
                    emailNotificationService.NotificarCreacionEvento(evento);
                    Console.WriteLine($"Notificaciones de nuevo evento enviadas para: {evento.nombre_evento}");
                }
                catch (Exception emailEx)
                {
                    Console.WriteLine($"Error al enviar notificaciones de nuevo evento: {emailEx.Message}");
                }

                return $"Evento {evento.nombre_evento} guardado exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al guardar: {ex.Message}";
            }
        }

        public string GuardarEventoComoAdmin(Evento evento, int idUsuario)
        {
            try
            {
                if (evento.fecha_inicio_evento > evento.fecha_fin_evento)
                {
                    return "Error al guardar: La fecha de inicio no puede ser posterior a la fecha de fin";
                }

                int idAdministrador = eventoRepository.ObtenerIdAdministradorPorUsuario(idUsuario);
                evento.id_administrador = idAdministrador;

                eventoRepository.Guardar(evento);
                // *** NUEVA FUNCIONALIDAD: Enviar notificación de nuevo evento ***
                Task.Run(() =>
                {
                    try
                    {
                        var emailNotificationService = new EmailNotificationService();
                        emailNotificationService.NotificarCreacionEvento(evento);
                    }
                    catch (Exception emailEx)
                    {
                        Console.WriteLine($"Error al enviar notificaciones de nuevo evento: {emailEx.Message}");
                    }
                });
                return $"Curso {evento.nombre_evento} guardado exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al guardar: {ex.Message}";
            }
        }

        public string Modificar(Evento evento)
        {
            try
            {
                var eventoExistente = eventoRepository.BuscarPorId(evento.id_evento);
                if (eventoExistente == null)
                {
                    return $"Error al modificar: El evento con ID {evento.id_evento} no existe";
                }

                if (evento.fecha_inicio_evento > evento.fecha_fin_evento)
                {
                    return "Error al modificar: La fecha de inicio no puede ser posterior a la fecha de fin";
                }

                return eventoRepository.ActualizarConProcedimiento(evento);
            }
            catch (Exception ex)
            {
                return $"Error al modificar: {ex.Message}";
            }
        }

        public string Eliminar(int idEvento)
        {
            try
            {
                var evento = eventoRepository.BuscarPorId(idEvento);
                if (evento == null)
                {
                    return $"Error al eliminar: El evento con ID {idEvento} no existe";
                }

                eventoRepository.Eliminar(idEvento);
                return $"Evento {evento.nombre_evento} eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar: {ex.Message}";
            }
        }

        public int ObtenerIdAdministradorPorUsuario(int idUsuario)
        {
            return eventoRepository.ObtenerIdAdministradorPorUsuario(idUsuario);
        }

        public Evento BuscarPorId(int idEvento)
        {
            var evento = eventoRepository.BuscarPorId(idEvento);
            if (evento != null)
            {
                evento.Asistentes = asistenciaEventoRepository.ConsultarAsistentesPorEvento(idEvento);
            }
            return evento;
        }

        public List<Evento> Consultar()
        {
            var eventos = eventoRepository.ConsultarTodos();
            foreach (var evento in eventos)
            {
                evento.Asistentes = asistenciaEventoRepository.ConsultarAsistentesPorEvento(evento.id_evento);
            }
            return eventos;
        }

        public List<Evento> ConsultarProximosEventos()
        {
            var eventos = eventoRepository.ConsultarProximosEventos();
            foreach (var evento in eventos)
            {
                evento.Asistentes = asistenciaEventoRepository.ConsultarAsistentesPorEvento(evento.id_evento);
            }
            return eventos;
        }

        public List<EventoDTO> ConsultarDTO()
        {
            var eventos = Consultar();
            var eventosDTO = new List<EventoDTO>();

            foreach (var evento in eventos)
            {
                eventosDTO.Add(new EventoDTO
                {
                    id_evento = evento.id_evento,
                    nombre_evento = evento.nombre_evento,
                    lugar_evento = evento.lugar_evento,
                    descripcion_evento = evento.descripcion_evento,
                    fecha_inicio_evento = evento.fecha_inicio_evento,
                    fecha_fin_evento = evento.fecha_fin_evento,
                    capacidad_max_evento = evento.capacidad_max_evento,
                    NumeroAsistentes = evento.NumeroAsistentes,
                    ruta_imagen_evento = evento.ruta_imagen_evento
                });
            }

            return eventosDTO;
        }

        public List<EventoDTO> ConsultarProximosEventosDTO()
        {
            var eventos = ConsultarProximosEventos();
            var eventosDTO = new List<EventoDTO>();

            foreach (var evento in eventos)
            {
                eventosDTO.Add(new EventoDTO
                {
                    id_evento = evento.id_evento,
                    nombre_evento = evento.nombre_evento,
                    lugar_evento = evento.lugar_evento,
                    descripcion_evento = evento.descripcion_evento,
                    fecha_inicio_evento = evento.fecha_inicio_evento,
                    fecha_fin_evento = evento.fecha_fin_evento,
                    capacidad_max_evento = evento.capacidad_max_evento,
                    NumeroAsistentes = evento.NumeroAsistentes
                });
            }

            return eventosDTO;
        }

        public string RegistrarAsistencia(int idUsuario, int idEvento)
        {
            try
            {
                var usuario = usuarioRepository.BuscarPorId(idUsuario);
                if (usuario == null)
                {
                    return $"Error al registrar asistencia: El usuario con ID {idUsuario} no existe";
                }

                var evento = eventoRepository.BuscarPorId(idEvento);
                if (evento == null)
                {
                    return $"Error al registrar asistencia: El evento con ID {idEvento} no existe";
                }

                if (asistenciaEventoRepository.ExisteAsistencia(idUsuario, idEvento))
                {
                    return $"Error al registrar asistencia: El usuario ya está registrado para este evento";
                }

                evento.Asistentes = asistenciaEventoRepository.ConsultarAsistentesPorEvento(idEvento);
                if (evento.NumeroAsistentes >= evento.capacidad_max_evento)
                {
                    return $"Error al registrar asistencia: El evento ha alcanzado su capacidad máxima";
                }

                var asistencia = new Asistencia_evento
                {
                    id_usuario = idUsuario,
                    id_evento = idEvento
                };
                asistenciaEventoRepository.Guardar(asistencia);

                return $"Asistencia al evento {evento.nombre_evento} registrada exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al registrar asistencia: {ex.Message}";
            }
        }

        public string CancelarAsistencia(int idUsuario, int idEvento)
        {
            try
            {
                var usuario = usuarioRepository.BuscarPorId(idUsuario);
                if (usuario == null)
                {
                    return $"Error al cancelar asistencia: El usuario con ID {idUsuario} no existe";
                }

                var evento = eventoRepository.BuscarPorId(idEvento);
                if (evento == null)
                {
                    return $"Error al cancelar asistencia: El evento con ID {idEvento} no existe";
                }

                if (!asistenciaEventoRepository.ExisteAsistencia(idUsuario, idEvento))
                {
                    return $"Error al cancelar asistencia: El usuario no está registrado para este evento";
                }

                asistenciaEventoRepository.Eliminar(idUsuario, idEvento);

                return $"Asistencia al evento {evento.nombre_evento} cancelada exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al cancelar asistencia: {ex.Message}";
            }
        }

        public List<Usuario> ConsultarAsistentes(int idEvento)
        {
            return asistenciaEventoRepository.ConsultarAsistentesPorEvento(idEvento);
        }

        public List<Evento> ConsultarEventosPorUsuario(int idUsuario)
        {
            return asistenciaEventoRepository.ConsultarEventosPorUsuario(idUsuario, eventoRepository);
        }
    }
}