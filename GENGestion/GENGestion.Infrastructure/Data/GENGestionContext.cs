using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GENGestion.Infrastructure.Data
{
    public partial class GENGestionContext : DbContext
    {
        public GENGestionContext()
        {
        }

        public GENGestionContext(DbContextOptions<GENGestionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Consultas> Consultas { get; set; }
        public virtual DbSet<Diagnosticos> Diagnosticos { get; set; }
        public virtual DbSet<DiagnosticosConsultas> DiagnosticosConsultas { get; set; }
        public virtual DbSet<DiagnosticosInformes> DiagnosticosInformes { get; set; }
        public virtual DbSet<Estudios> Estudios { get; set; }
        public virtual DbSet<Informes> Informes { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<Medicaciones> Medicaciones { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<ObrasSociales> ObrasSociales { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<TiposDePacientes> TiposDePacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TFUC6LR\\SQLEXPRESS;Database=GENGestion;Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultas>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeAntecedenteEnfermedadActual)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeExamenFisico)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeIndicaciones)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeMotivoConsulta)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeTratamiento)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FeConsulta).HasColumnType("datetime");

                entity.Property(e => e.MedicoId).HasColumnName("MedicoID");

                entity.Property(e => e.PacienteId).HasColumnName("PacienteID");

                entity.HasOne(d => d.Medico)
                    .WithMany(p => p.Consultas)
                    .HasForeignKey(d => d.MedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultaMedico");

                entity.HasOne(d => d.Paciente)
                    .WithMany(p => p.Consultas)
                    .HasForeignKey(d => d.PacienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultaPaciente");
            });

            modelBuilder.Entity<Diagnosticos>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeCodigoDiagnostico)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DeDiagnostico)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DiagnosticosConsultas>(entity =>
            {
                entity.HasKey(e => new { e.DiagnosticoId, e.ConsultaId })
                    .IsClustered(false);

                entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");

                entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");

                entity.HasOne(d => d.Consulta)
                    .WithMany(p => p.DiagnosticosConsultas)
                    .HasForeignKey(d => d.ConsultaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultaDiagCons");

                entity.HasOne(d => d.Diagnostico)
                    .WithMany(p => p.DiagnosticosConsultas)
                    .HasForeignKey(d => d.DiagnosticoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiagnosticoDiagCons");
            });

            modelBuilder.Entity<DiagnosticosInformes>(entity =>
            {
                entity.HasKey(e => new { e.DiagnosticoId, e.InformeId })
                    .IsClustered(false);

                entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");

                entity.Property(e => e.InformeId).HasColumnName("InformeID");

                entity.HasOne(d => d.Diagnostico)
                    .WithMany(p => p.DiagnosticosInformes)
                    .HasForeignKey(d => d.DiagnosticoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiagnosticoInfCons");

                entity.HasOne(d => d.Informe)
                    .WithMany(p => p.DiagnosticosInformes)
                    .HasForeignKey(d => d.InformeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeInfCons");
            });

            modelBuilder.Entity<Estudios>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeCodigoEstudio)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DeEstudio)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Informes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeDescripcionPreparacion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeEquipoUsado)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeHallazgo)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DeMotivoInforme)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.EstudioId).HasColumnName("EstudioID");

                entity.Property(e => e.FeInforme).HasColumnType("datetime");

                entity.Property(e => e.MedicacionId).HasColumnName("MedicacionID");

                entity.Property(e => e.MedicoAnestesistaId).HasColumnName("MedicoAnestesistaID");

                entity.Property(e => e.MedicoReferenteId).HasColumnName("MedicoReferenteID");

                entity.Property(e => e.MedicoTratanteId).HasColumnName("MedicoTratanteID");

                entity.Property(e => e.PacienteId).HasColumnName("PacienteID");

                entity.Property(e => e.TiEstado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Estudio)
                    .WithMany(p => p.Informes)
                    .HasForeignKey(d => d.EstudioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeEstudio");

                entity.HasOne(d => d.Medicacion)
                    .WithMany(p => p.Informes)
                    .HasForeignKey(d => d.MedicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeMedicacion");

                entity.HasOne(d => d.MedicoAnestesista)
                    .WithMany(p => p.InformesMedicoAnestesista)
                    .HasForeignKey(d => d.MedicoAnestesistaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeMedicoAnestesista");

                entity.HasOne(d => d.MedicoReferente)
                    .WithMany(p => p.InformesMedicoReferente)
                    .HasForeignKey(d => d.MedicoReferenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeMedicoReferente");

                entity.HasOne(d => d.MedicoTratante)
                    .WithMany(p => p.InformesMedicoTratante)
                    .HasForeignKey(d => d.MedicoTratanteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeMedicoTratante");

                entity.HasOne(d => d.Paciente)
                    .WithMany(p => p.Informes)
                    .HasForeignKey(d => d.PacienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformePaciente");
            });

            modelBuilder.Entity<Localidades>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeCdPostal).HasMaxLength(9);

                entity.Property(e => e.DeLocalidad).HasMaxLength(100);

                entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Localidades)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProvinciasLocalidad");
            });

            modelBuilder.Entity<Medicaciones>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeMedicacion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeApellido)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeCelular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DeDomicilio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeEmail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeNombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeNumeroAfiliado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeOcupacion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeSexo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DeTelefono)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DeTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FeAlta).HasColumnType("datetime");

                entity.Property(e => e.FeNacimiento).HasColumnType("datetime");

                entity.Property(e => e.LocalidadId).HasColumnName("LocalidadID");

                entity.Property(e => e.NuMatricula)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Localidad)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.LocalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicoLocalidad");
            });

            modelBuilder.Entity<ObrasSociales>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeCodigoObraSocial)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DeObraSocial)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Pacientes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeApellido)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeCelular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DeDomicilio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeEmail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeNombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeNumeroAfiliado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeOcupacion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeSexo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DeTelefono)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DeTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FeAlta).HasColumnType("datetime");

                entity.Property(e => e.FeNacimiento).HasColumnType("datetime");

                entity.Property(e => e.LocalidadId).HasColumnName("LocalidadID");

                entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");

                entity.Property(e => e.TipoPacienteId).HasColumnName("TipoPacienteID");

                entity.HasOne(d => d.Localidad)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.LocalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacienteLocalidad");

                entity.HasOne(d => d.ObraSocial)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.ObraSocialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacienteObraSocial");

                entity.HasOne(d => d.TipoPaciente)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.TipoPacienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacienteTipoPaciente");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeProvincia).HasMaxLength(20);
            });

            modelBuilder.Entity<TiposDePacientes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeTipoPaciente)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
