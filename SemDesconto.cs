﻿namespace DesignerPaterns
{
    public class SemDesconto:Desconto
    {
        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }

        public Desconto Proximo{get; set; }
    }
}