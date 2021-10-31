using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Agenda
{
    public class Agenda
  {
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    //Construtor
    public Agenda(string _nome, string _endereco, string _telfone)
    {
      this.Nome = _nome;
      this.Endereco = _endereco;
      this.Telefone = _telfone;
    }
  }
}
