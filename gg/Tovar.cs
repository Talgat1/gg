using System;
using System.Collections.Generic;
using System.Text;

namespace gg
{
    public class Tovar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public string Proizvod { get; set; }
        public int Price { get; set; }
        public string Activity { get; set; }

        public override string ToString()
        {
            return "Номер(Id): " + Id + ", Наименование: " + Name + ", Описание: " + Opisanie + ", Производитель: " + Proizvod + ", Цена: " + Price + "руб., Активный: " + Activity;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Tovar objAsPart = obj as Tovar;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(Tovar other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
}
