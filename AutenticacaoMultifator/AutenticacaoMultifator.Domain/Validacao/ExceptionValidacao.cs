namespace AutenticacaoMultifator.Domain.Validation
{
    public class ExceptionValidacao : Exception
    {
        public ExceptionValidacao(string erro) : base (erro) {  }
    }
}