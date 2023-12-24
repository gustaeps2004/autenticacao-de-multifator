using AutenticacaoMultifator.Domain.Extensoes;
using AutenticacaoMultifator.Domain.Validation;

namespace AutenticacaoMultifator.Application.DTOs
{
    public class AutenticacaoLoginDTO
    {
        public string Senha { get; set; }
        public string DocumentoFederal { get; set; }
        public string Email { get; set; }


        public void Validar()
        {
            if (string.IsNullOrEmpty(DocumentoFederal.RemoverCaracteresEspeciais()))
                throw new ExceptionValidacao("Oops! Parece que as informações de login estão incorretas. Por favor, verifique seus dados e tente novamente.");

            if (DocumentoFederal.Length != 11 && DocumentoFederal.Length != 14)
                throw new ExceptionValidacao("Oops! Parece que as informações de login estão incorretas. Por favor, verifique seus dados e tente novamente.");

            if (!DocumentoFederal.ValidarCNPJ() && !DocumentoFederal.ValidarCPF())
                throw new ExceptionValidacao("Oops! Parece que as informações de login estão incorretas. Por favor, verifique seus dados e tente novamente.");

            if (string.IsNullOrEmpty(Email))
                throw new ExceptionValidacao("Oops! Parece que as informações de login estão incorretas. Por favor, verifique seus dados e tente novamente.");

            if (string.IsNullOrEmpty(Senha))
                throw new ExceptionValidacao("Oops! Parece que as informações de login estão incorretas. Por favor, verifique seus dados e tente novamente.");
        }
    }
}