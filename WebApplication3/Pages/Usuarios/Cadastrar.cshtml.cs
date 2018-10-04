using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Data;

namespace WebApplication3.Pages.Usuarios
{
    public class CadastrarModel : PageModel
    {

        [BindProperty]
       public Usuario usuarios { get; set; }
       public void Onget(string nome, string senha)
        {
            if (usuarios == null)
            {
                usuarios = new Usuario();
            }
            usuarios.Nome = nome;
            usuarios.Senha = senha;
        }
    }
}