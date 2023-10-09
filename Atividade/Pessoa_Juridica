namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}
        public override void Pagar_Imposto(float v)
        //override significa reescrito o método de Pagar_Imposto
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.valor = this.valor + this.valor_imposto;
        }
    }
}