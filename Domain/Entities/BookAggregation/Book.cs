using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.BookAggregation
{
    /// <summary>
    /// Regras para criação da entidade Book
    /// 
    /// 1 - Ao criar um livro. Deve-se informar o titulo, descricao,  autor e codigo interno.
    /// 2 - O Livro deve ser criado com o status inativo
    /// 3 - A data de Criação deve ser a data atual
    /// 4 - O Status da reserva, deve vir como false
    /// 
    /// Regra para realizar reserva
    /// 1 - Para que um livro possa ser reservado. Ele não deve estar inativo e não pode estar reservado.
    /// 2 - A data da reserva sempre será a data e hora atual.
    /// </summary>
    public class Book : RootAggregate
    {
        public int Id { get; }
        public string Title { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public bool IsActive { get; private set; }
        public bool IsReserverd { get; private set; }
        public string InternalCode { get; private set; }
        public DateTime BookingDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        public List<Category> Categories { get; private set; }

        public Book(string title, string description, string author, string internalCode)
        {
            Title = title;
            Description = description;
            Author = author;
            InternalCode = internalCode;

            IsActive = false;
            CreatedDate = DateTime.Now;
            IsReserverd = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void InActivate()
        {
            IsActive = false;
        }

        public bool Reserve(int numberOfDaysOfReservation)
        {
            if (!IsActive) return false;
            if (IsReserverd) return false;

            IsReserverd = true;
            BookingDate = DateTime.Now;

            ReturnDate = BookingDate.AddDays(numberOfDaysOfReservation);
            return true;
        }
    }
}
