using Microsoft.AspNetCore.Mvc.RazorPages;

public class PessoasModel : PageModel
{
    public List<Pessoa> Pessoas { get; set; }

    public void OnGet()
    {
        Pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", Idade = 30, CPF = "123.456.789-00" },
            new Pessoa { Nome = "Maria", Idade = 25, CPF = "987.654.321-00" },
            // Adicione mais pessoas aqui se desejar
        };
    }
    
}