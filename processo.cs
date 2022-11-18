using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurídico.Models
{
    class processo
    {
        public int numero { get; set; }
        public DateTime datacricao { get; set; }
        public Pessoa solicitante { get; set; }
        public Pessoa Acusado { get; set; }
        public Pessoa pedido { get; set; }
        public double getvalortotalpedidos()
        {
            return 1;
        }
        public List<processo> getquantidadepedidos()
        {
            return null;

        }
        public int distribuicaodeprocessos()
        {
            return 1;
        }
        public List<processo> getproceessosporesescritorios()
        {
            return null;
        }
        
        
        
    }   
}       
        

     

        
