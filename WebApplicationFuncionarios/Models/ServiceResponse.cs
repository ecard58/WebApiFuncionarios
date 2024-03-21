namespace WebApplicationFuncionarios.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados {  get; set; }
        //T é um dado genérico e ? garante que ele pode ser nulo
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
