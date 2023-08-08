class Produto
{ 
        public string codigo { get; set; }

        public string descricao { get; set; }
    
        public double pAquisicao { get; set; }

        public double lucro { get; set; }

        public double valorVenda { get; set; }


        public Produto()
        {

        }

        public Produto(string codigo, string descricao, double pAquisicao, double lucro, double valorVenda)
        {
             this.codigo = codigo;
             this.descricao = descricao;
             this.pAquisicao = pAquisicao;
             this.lucro = lucro;
             this.valorVenda = valorVenda;
        }  
    
}

