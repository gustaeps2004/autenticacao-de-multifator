using AutenticacaoMultifator.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AutenticacaoMultifator.Domain.Entidades
{
    public class Colaborador
    {
        [Key] public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Situacao Situacao { get; set; }
        public Situacao MfaAtivo { get; set; }
        public bool PrimeiroAcesso { get; set; }


        public void DesativarColaborador()
        {
            Situacao = Situacao.Desativado;
            MfaAtivo = Situacao.Desativado;
            PrimeiroAcesso = true;
        }
    }
}