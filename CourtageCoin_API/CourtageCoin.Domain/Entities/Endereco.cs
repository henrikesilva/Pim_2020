﻿using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Endereco
    {
        public int END_INT_ID { get; set; }
        public string END_STR_RUA { get; set; }
        public string END_STR_NUMERO { get; set; }
        public string END_STR_BAIRRO { get; set; }
        public string END_STR_COMPLEMENTO { get; set; }
        public string END_STR_CIDADE { get; set; }
        public string END_STR_ESTADO { get; set; }
    }
}
