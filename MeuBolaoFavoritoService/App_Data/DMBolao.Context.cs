﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeuBolaoFavoritoService.App_Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_BOLAO : DbContext
    {
        public DB_BOLAO()
            : base("name=DB_BOLAO")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TARQUIVO> TARQUIVO { get; set; }
        public virtual DbSet<TBOLAO> TBOLAO { get; set; }
        public virtual DbSet<TDICIONARIO> TDICIONARIO { get; set; }
        public virtual DbSet<TIDIOMA> TIDIOMA { get; set; }
        public virtual DbSet<TJOGO> TJOGO { get; set; }
        public virtual DbSet<TPACOTE> TPACOTE { get; set; }
        public virtual DbSet<TPACOTE_TRECURSO> TPACOTE_TRECURSO { get; set; }
        public virtual DbSet<TPALPITE> TPALPITE { get; set; }
        public virtual DbSet<TRECURSO> TRECURSO { get; set; }
        public virtual DbSet<TREGRA> TREGRA { get; set; }
        public virtual DbSet<TTIME> TTIME { get; set; }
        public virtual DbSet<TUSUARIO> TUSUARIO { get; set; }
        public virtual DbSet<TUSUARIO_RECURSO> TUSUARIO_RECURSO { get; set; }
        public virtual DbSet<TUSUARIO_TBOLAO> TUSUARIO_TBOLAO { get; set; }
        public virtual DbSet<TUSUARIO_TIME> TUSUARIO_TIME { get; set; }
        public virtual DbSet<TPONTUACAO> TPONTUACAO { get; set; }
        public virtual DbSet<TCOMPETICAO> TCOMPETICAO { get; set; }
        public virtual DbSet<TRODADA> TRODADA { get; set; }
    }
}
