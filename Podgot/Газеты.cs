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
    
    public partial class Газеты
    {
        public int ID { get; set; }
        public int ID_продукция { get; set; }
        public int ID_наименование_агента { get; set; }
        public Nullable<System.DateTime> Дата_реализации { get; set; }
        public Nullable<int> Количество_продукции { get; set; }
    
        public virtual Агент Агент { get; set; }
        public virtual Продукция Продукция { get; set; }
    }
}
