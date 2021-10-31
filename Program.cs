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
    
     public class Metodos
  {
    #region Métodos de inclusão, alteração e exclusão e vizualização

    //Método de inserção de uma nova pessoa na agenda
    public static void InserirPessoaAgenda(List<Agenda> _agendaTelefonicaList, Agenda agenda)
    {
      //recuperando agenda que foi passada como parametro
      List<Agenda> _list = _agendaTelefonicaList;

      //Adiconando nova pessoa à agenda
      _list.Add(agenda);

      //Vizualizando agenda preenchida
      Metodos.VizualizarAgenda(_list);

      //Carregando menu principal
      Metodos.CarregarMenuPrincipal();

      //Guarda o valor digitado pelo usuario
      string _menu = Console.ReadLine().ToString();

      //Realiza ação de acorodo com a opção escolhida pelo usuario
      Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);
    }
         
         
     }
}
