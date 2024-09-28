using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appprueba.Models;

namespace appprueba.ViewModel
{
    public class CuentaBancariaViewModel
    {
        public CuentaBancaria? FormCuentaBancaria { get; set; }
        public List<CuentaBancaria>? ListarCuentaBancaria { get; set; }
    }
}