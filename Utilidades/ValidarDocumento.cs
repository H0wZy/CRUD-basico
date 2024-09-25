using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using devPOO.Classes;
using devPOO.Forms;


namespace devPOO.Utilidades
{
    internal static class ValidarDocumento
    {

        //VALIDAR CPF
        public static Boolean Cpf(string pCpf)
        {
            Int64 nCpf;
            Boolean converteu;
            string cpf = pCpf.Trim();

            cpf = cpf.Replace(".", "").Trim();
            cpf = cpf.Replace(",", "").Trim();
            cpf = cpf.Replace("-", "").Trim(); 

            converteu = Int64.TryParse(cpf, out nCpf);


            if (!converteu)
                return false;

            if (cpf.Length != 11)
                return false;


            return true;


        }

        //VALIDAR CNPJ ALTERAR DPS
        public static Boolean Cnpj(string pCnpj)
        {
            if (string.IsNullOrEmpty(pCnpj))
            {
                return false;
            }

                Int64 nCnpj;
                Boolean converteu;
                string cnpj = pCnpj.Trim();

                cnpj = cnpj.Replace(".", "").Trim();
                cnpj = cnpj.Replace(",", "").Trim();
                cnpj = cnpj.Replace("/", "").Trim();
                cnpj = cnpj.Replace("-", "").Trim();

                converteu = Int64.TryParse(cnpj, out nCnpj);

                if (!converteu)
                    return false;

                if (cnpj.Length != 14)
                    return false;

            return true;

        }
    }
}
