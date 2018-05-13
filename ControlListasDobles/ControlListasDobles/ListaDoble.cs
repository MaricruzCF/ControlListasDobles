using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlListasDobles
{
    class ListaDoble
    {

       
        private Producto _primero = null;

        private Producto _ultimo = null;

        public void Agregar(Producto elemento)
        {
            if (_primero == null)
                _primero = _ultimo = elemento;

            else if (elemento.Codigo < _primero.Codigo)
            {
                elemento.Siguiente = _primero;

                _primero.Anterior = elemento;
                
                _primero = elemento;
            }

            else if (elemento.Codigo > _ultimo.Codigo)
            {
  
                _ultimo.Siguiente = elemento;
               
                elemento.Anterior = _ultimo;
           
                _ultimo = elemento;
            }

            else if (elemento.Codigo == _primero.Codigo && _primero == _ultimo)
            {
                _ultimo.Siguiente = elemento;
 
                elemento.Anterior = _ultimo;
 
                _ultimo = elemento;
            }

            else
            {
               
                Producto temp = _primero.Siguiente;

                while (elemento.Codigo > temp.Codigo)
                    temp = temp.Siguiente;

                temp.Anterior.Siguiente = elemento;

   
                elemento.Siguiente = temp;
              
                elemento.Anterior = temp.Anterior;

                temp.Anterior = elemento;

            }
        }

        public Producto Buscar(int codigo)
        {
    
            Producto temp = _primero;

            while (temp != null)
            {

                if (temp.Codigo == codigo)
                    return temp;
                temp = temp.Siguiente;
            }
          
            return null;
        }

        public void Eliminar(int codigo)
        {

            if (_primero == null)
                return;

            if (_primero.Codigo == codigo && _primero == _ultimo)
            {
                _primero = _ultimo = null;
                return;
            }

            if (_primero == _ultimo)
                return;

            if (_primero.Codigo == codigo)
            {
 
                Producto segundo = _primero.Siguiente;
             
                segundo.Anterior = null;
     
                _primero.Siguiente = null;
              
                _primero = segundo;
                return;
            }

            if (_ultimo.Codigo == codigo)
            {
               
                Producto penultimo = _ultimo.Anterior;
               
                penultimo.Siguiente = null;
               
                _ultimo.Anterior = null;
             
                _ultimo = penultimo;
                return;
            }

            Producto temp = _primero.Siguiente;

            while (temp != _ultimo)
            {
             
                if (temp.Codigo == codigo)
                {

                    temp.Siguiente.Anterior = temp.Anterior;

                    temp.Anterior.Siguiente = temp.Siguiente;
                }
      
                temp = temp.Siguiente;
            }
        }

   
        public void EliminarUltimo()
        {
           
            if (_primero == null)
                return;

            if (_primero == _ultimo)
            {
                _primero = _ultimo = null;
                return;
            }

            Producto penultimo = _ultimo.Anterior;
           
            penultimo.Siguiente = null;
      
            _ultimo.Anterior = null;
       
            _ultimo = penultimo;
        }

        public void EliminarPrimero()
        {
           
            if (_primero == null)
                return;

           
            if (_primero == _ultimo)
            {
                _primero = _ultimo = null;
                return;
            }

           
            Producto segundo = _primero.Siguiente;
           
            segundo.Anterior = null;
           
            _primero.Siguiente = null;
            
            _primero = segundo;
        }

     
        public void InvertirLista()
        {
            
            if (_primero == _ultimo)
                return;

           
            Producto temp = _primero;
           
            while (temp != null)
            {
               
                Producto siguiente = temp.Siguiente;
               
                temp.Siguiente = temp.Anterior;
                
                temp.Anterior = siguiente;
               
                temp = siguiente;
            }
           
            temp = _primero;
          
            _primero = _ultimo;
           
            _ultimo = temp;
        }

        public string ReoprteInverso()
        {
            string str = "";
            Producto temp = _ultimo;
            while (temp != null)
            {
                str += temp.ToString() + System.Environment.NewLine;
                temp = temp.Anterior;
            }
            return str;
        }

        public override string ToString()
        {
            string str = "";
            Producto temp = _primero;
            while (temp != null)
            {
                str += temp.ToString() + System.Environment.NewLine;
                temp = temp.Siguiente;
            }
            return str;
        }
    }
}
