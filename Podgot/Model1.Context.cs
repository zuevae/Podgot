﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Podgot
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        private static Entities _Bd;
        public Entities()
            : base("name=Entities")
        {
        }
    public static Entities GetContext()
        {
            if (_Bd == null) _Bd = new Entities();
            return _Bd;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Агент> Агент { get; set; }
        public virtual DbSet<Газеты> Газеты { get; set; }
        public virtual DbSet<Продукция> Продукция { get; set; }
        public virtual DbSet<ТипПродукции> ТипПродукции { get; set; }
        public virtual DbSet<ТипыАгентов> ТипыАгентов { get; set; }
    }
}
