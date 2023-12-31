namespace Atividade
{
    class Clientes
    {
        public string nome {get; set;}//+ no diagrama = Public _ tipo: string _ nome{get; set;} significa encapsulamento
        public string endereco {get; set;}
        //get significa que pode ler o conteúdo do atributo  
        //set vc pode alterar o conteúdo
        public float valor {get; protected set;}
         // protected set vc está protegendo o conteúdo
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}
        public virtual void Pagar_Imposto (float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}
