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
         
           public static void VizualizarAgenda(List<Agenda> _agendaTelefonicaList)
    {
      Console.WriteLine();
      Console.WriteLine("ID\t\tNome\t\tEndereco\t\tTelefone");

      for (int i = 0; i < _agendaTelefonicaList.Count; i++)
      {

        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",
        i,
        _agendaTelefonicaList[i].Nome,
        _agendaTelefonicaList[i].Endereco,
        _agendaTelefonicaList[i].Telefone);
      }

      //Carregando menu principal
      Metodos.CarregarMenuPrincipal();

      //Recuperando menu digitado pela pessoa
      string _menu = Console.ReadLine().ToString();

      //Carregando menu correspodente
      Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);
    }
     }
}
