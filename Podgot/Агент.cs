//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Агент
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Агент()
        {
            this.Газеты = new HashSet<Газеты>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Тип_агента { get; set; }
        public string Наименование_агента { get; set; }
        public string Электронная_почта_агента { get; set; }
        public string Телефон_агента { get; set; }
        public string Логотип_агента { get; set; }
        public string Юридический_адрес { get; set; }
        public Nullable<int> Приоритет { get; set; }
        public string Директор { get; set; }
        public Nullable<int> ИНН { get; set; }
        public Nullable<int> КПП { get; set; }
    
        public virtual ТипыАгентов ТипыАгентов { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Газеты> Газеты { get; set; }
    }
}
