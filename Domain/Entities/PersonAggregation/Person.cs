using Domain.Entities.PersonAggregation.Enums;
using Domain.Entities.PersonAggregation.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.PersonAggregation
{
    /// <summary>
    /// Regras para criação do cliente.
    /// 1 - Deve ser informado no cadastro inicial do cliente, nome, sobrenome, email e genero
    /// 2 - Todo cliente que for cadastrado, deve estar com o status inativo
    /// 3 - Nome e sobrenome serão obrigatórios
    /// 4 - A pessoa só poderá realizar uma reserva se possuir um endereco 
    /// </summary>
    public class Person
    {
        public int Id { get; }
        public PersonName Name {get; private set;}
        public bool IsActive { get; private set; } 
        public PersonEmail Email {get; private set;}
        public DateTime LastReservation {get; private set;}
        public Genre Genre {get; private set;}

        public Person(string name, string lastName, string email, Genre genre)
        {
            Name = new PersonName(name, lastName);
            Email = new PersonEmail(email);
            Genre = genre;

            IsActive = false;
        }
    }
}
