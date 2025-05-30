# 📌 EKKLESYS

**EKKLESYS** es un prototipo de sistema gestor de eventos y cursos diseñado para iglesias en Valledupar.

---

## 🧰 Tecnologías utilizadas

- Lenguaje: C#
- Frameworks y librerías:
  - .NET
  - FontAwesome.Sharp
  - Telegram.Bot
  - QuestPDF
  - Oracle.ManagedDataAccess
- Base de datos: Oracle 18c Express Edition

---

## 🚀 Características principales

- ✅ Creación, consulta y eliminación de eventos y cursos
- ✅ Registro de usuarios en eventos y cursos
- ✅ Dashboard de seguimiento de registros

---

## 🗃️ Estructura de la base de datos

[Ver la documentación](https://unicesareduco-my.sharepoint.com/:f:/g/personal/mcustodes_unicesar_edu_co/EgBtJ6DiJthIovumm6L1hhIByr2_LWc7FuOvOfcJ3VpAsg?e=1SV0br)

---

## 🧱 Estructura del Proyecto
- Solución "EKKLESYS_V5" (4 de 4 proyectos)
  - Orígenes externos
  - BLL
    - Propiedades
    - Referencias
    - Bot
      - `AuthenticationService.cs`
      - `BaseBotController.cs`
      - `CursoBotController.cs`
      - `EventoBotController.cs`
      - `IBotController.cs`
      - `IRegistrationService.cs`
      - `RegistrationService.cs`
      - `TelegramBotService.cs`
      - `UserState.cs`
      - `UserStateType.cs`
    - Correo
      - `EmailNotificationService.cs`
      - `EmailService.cs`
      - `ReminderSchedulerService.cs`
  - `app.config`
   - `ComunaService.cs`
    - `CursoService.cs`
    - `DashboardService.cs`
    - `EventoService.cs`
    - `UsuarioService.cs`
    - `packages.config`
  - DAL
    - Propiedades
    - Referencias
    - `App.config`
    - `AsistenciaEventoRepository.cs`
    - `ComunaRepository.cs`
    - `ConnectionManager.cs`
    - `CursoRepository.cs`
    - `DashboardRepository.cs`
    - `EventoRepository.cs`
    - `InscripcionCursoRepository.cs`
    - `Oracle.DataAccess.Common.Configuration.Section.xsd`
    - `Oracle.ManagedDataAccess.Client.Configuration.Section.xsd`
    - `packages.config`
    - `UsuarioRepository.cs`
  - ENTITY
    - Propiedades
    - Referencias
    - `Administrador.cs`
    - `Asistencia_evento.cs`
    - `Comuna.cs`
    - `Curso.cs`
    - `CursoDTO.cs`
    - `DashboardDTO.cs`
    - `Evento.cs`
    - `EventoDTO.cs`
    - `Inscripcion_curso.cs`
    - `Usuario.cs`
    - `UsuarioDTO.cs`
  - GUI
    - Propiedades
    - Referencias
    - Forms Admin
      - `FrmAsistentesEvento.cs`
      - `FrmCrearCurso.cs`
      - `FrmCrearEvento.cs`
      - `FrmCursosAdmin.cs`
      - `FrmDashboard.cs`
      - `FrmDetalleCursoAdmin.cs`
      - `FrmDetalleEventoAdmin.cs`
      - `FrmEventosAdmin.cs`
    - `FrmGestionComunas.cs`
      - `FrmInscritosCurso.cs`
      - `FrmPrincipalAdmin.cs`
      - `FrmUsuarios.cs`
    - Forms User
      - `FrmCursosUser.cs`
      - `FrmDetalleCursoUser.cs`
      - `FrmDetalleEventoUser.cs`
      - `FrmEventosUser.cs`
      - `FrmPrincipalUser.cs`
    - Resources
      - `App.config`
    - `FrmAcercaDe.cs`
    - `FrmCambiarPassword.cs`
    - `FrmInicio2.cs`
    - `FrmLogin.cs`
    - `FrmQr.cs`
    - `packages.config`
    - `PerfilForm.cs`
    - `Program.cs`
    - `RegistroForm.cs`
    - `Session.cs`
