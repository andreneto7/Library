using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.BookAggregation
{
    /// <summary>
    /// Regra para criação da categoria do livro
    /// 1 - Deve ser informado o nome da caregoria
    /// 2 - A Categoria deve ser criada com o status inativo
    /// </summary>
    public class Category
    {
        public int Id { get; }
        public string Name { get; private set; }
        public bool IsActive { get; private set; }

        public Category(string name)
        {
            Name = name;
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Inactivate()
        {
            IsActive = false;
        }
    }
}
