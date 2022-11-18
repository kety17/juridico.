using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurídico.Models
{
    public class Pessoa
    {
        public int Numro { get; set; }
        public char Tipopessoa { get; set; }//F = física, J = jurídica
        public string Nume { get; set; }
        public string Endereco { get; set; }

        public List<Pessoa> listaJuridica()
        {
            return null;
        }
        public List<Pessoa> ListaFisica()
        {
            return null;
}  }    }
          


