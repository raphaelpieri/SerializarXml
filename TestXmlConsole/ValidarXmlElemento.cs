using System;
using System.Linq.Expressions;

namespace TestXmlConsole
{
    public class ValidarXmlElemento<T>
    {
        private readonly T _objeto;
        public ValidarXmlElemento(T objeto)
        {
            this._objeto = objeto;
        }

        public bool ERequirido(Expression<Func<T, string>> selecionado)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return string.IsNullOrEmpty(val) ? true : false;
        }
        public bool EIgualAString(Expression<Func<T, string>> selecionado, string valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);                
            return !string.IsNullOrEmpty(val) && val.Equals(valorDeComparacao) ? true : false ;
        }

        public bool EMaiorQue(Expression<Func<T, int>> selecionado, int valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val > valorDeComparacao ? true : false;
        }
        public bool EMaiorOuIgualQue(Expression<Func<T, int>> selecionado, int valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val >= valorDeComparacao ? true : false;
        }
        public bool EMaiorQue(Expression<Func<T, short>> selecionado, short valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val > valorDeComparacao ? true : false;
        }
        public bool EMaiorOuIgualQue(Expression<Func<T, short>> selecionado, short valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val >= valorDeComparacao ? true : false;
        }
        public bool EMaiorQue(Expression<Func<T, float>> selecionado, float valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val > valorDeComparacao ? true : false;
        }
        public bool EMaiorOuIgualQue(Expression<Func<T, float>> selecionado, float valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val >= valorDeComparacao ? true : false;
        }
        public bool EMaiorQue(Expression<Func<T, decimal>> selecionado, decimal valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val > valorDeComparacao ? true : false;
        }
        public bool EMaiorOuIgualQue(Expression<Func<T, decimal>> selecionado, decimal valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val >= valorDeComparacao ? true : false;
        }
        public bool EMaiorQue(Expression<Func<T, double>> selecionado, double valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val > valorDeComparacao ? true : false;
        }
        public bool EMaiorOuIgualQue(Expression<Func<T, double>> selecionado, double valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val >= valorDeComparacao ? true : false;
        }
        public bool EMaiorQue(Expression<Func<T, DateTime>> selecionado, DateTime valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val > valorDeComparacao ? true : false;
        }
        public bool EMaiorOuIgualQue(Expression<Func<T, DateTime>> selecionado, DateTime valorDeComparacao)
        {
            var val = selecionado.Compile().Invoke(this._objeto);
            return val >= valorDeComparacao ? true : false;
        }
    }
}
