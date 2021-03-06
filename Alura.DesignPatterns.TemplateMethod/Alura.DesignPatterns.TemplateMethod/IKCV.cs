﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.TemplateMethod
{
    public class IKCV : TemplateImposto
    {
        protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemComValorMaiorQue100(orcamento);
        }

        private bool TemItemComValorMaiorQue100(Orcamento orcamento)
        {
            foreach (Item i in orcamento.Itens)
            {
                if (i.Valor > 100)
                    return true;
            }
            return false;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

    }
}
