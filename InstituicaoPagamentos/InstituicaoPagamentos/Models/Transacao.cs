﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituicaoPagamentos.Models
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
