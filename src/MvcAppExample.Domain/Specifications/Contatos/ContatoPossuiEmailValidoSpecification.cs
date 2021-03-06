﻿using DomainValidation.Interfaces.Specification;
using MvcAppExample.Domain.Entities;
using MvcAppExample.Domain.Validations;

namespace MvcAppExample.Domain.Specifications.Contatos
{
    public class ContatoPossuiEmailValidoSpecification : ISpecification<Contato>
    {
        public bool IsSatisfiedBy(Contato contato)
        {
            return EmailValidation.Validate(contato.Email);
        }
    }
}
