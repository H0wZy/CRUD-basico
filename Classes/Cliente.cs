using devPOO.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devPOO.Classes
{
    internal class Cliente: ICrud
    {
        private Int64 idCliente;
        private string nome;
        private string endereco;
        private decimal renda;
        private string tipoDocumento;
        private string numDocumento; 

        public Int64 IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public decimal Renda { get => renda; set => renda = value; }
        public string TipoDocumento { get => tipoDocumento; set=> tipoDocumento = value; }
        public string NumDocumento { get => numDocumento; set => numDocumento = value; }

        //VALIDAR CPF E CNPJ
        private string ValidarDocumentos()
        {
            if(this.tipoDocumento == "CPF")
            {
                if (!ValidarDocumento.Cpf(this.numDocumento))
                {
                    return "CPF inválido.";
                }
            }

            if (this.tipoDocumento == "CNPJ")
            {
                if (!ValidarDocumento.Cnpj(this.numDocumento))
                {
                    return "CNPJ inválido.";
                }
            }

            return "";
        }


        //CRIAR
        public string Create()
        {
            string retorno = ValidarDocumentos();

            if(retorno != "")
            {
                return retorno;
            }

            DataCode codigos = new DataCode();
            Dictionary<String, object> dados = new Dictionary<String, object>();

            dados.Add("ID:", idCliente);
            dados.Add("Nome:", nome);
            dados.Add("Endereço:", endereco);
            dados.Add("RendaR$:", renda);
            dados.Add("Documento:", tipoDocumento);
            dados.Add("Número:", numDocumento);

            return codigos.Create(dados, $"ClienteID_{idCliente}.txt");

        }

        //LER
        public string Read()
        {
            DataCode codigos = new DataCode();
            Dictionary<string, object> dados = codigos.Read($"ClienteID_{idCliente}.txt");

            if(dados == null)
            {
                return "Dado não encontrado/ou não existe.";
            }
            else
            {
                idCliente = Convert.ToInt64(dados["ID:"]);
                nome = dados["Nome:"].ToString();
                endereco = dados["Endereço:"].ToString();
                renda = Convert.ToDecimal(dados["RendaR$:"]);
                tipoDocumento = dados["Documento:"].ToString();
                numDocumento = dados["Número:"].ToString();

                return "";
            }
        }


        //ATUALIZAR
        public string Update()
        {
            if(idCliente == 0)
            {
                return "Informe o ID do cliente.";
            }

            string nomeArquivo = $"ClienteID_{idCliente}.txt";
            Dictionary<string, object> dados = new Dictionary<string, object>();

            DataCode codigos = new DataCode();

            dados.Add("ID:", idCliente);
            dados.Add("Nome:", nome);
            dados.Add("Endereço:", endereco);
            dados.Add("RendaR$:", renda);
            dados.Add("Documento:", tipoDocumento);
            dados.Add("Número:", numDocumento);

            return codigos.Update(dados, nomeArquivo);
        }


        //DELETAR
        public string Delete()
        {
            if (idCliente == 0)
            {
                return "Informe o ID do cliente.";
            }

            string nomeArquivo = $"ClienteID_{idCliente}.txt";
            DataCode banco = new DataCode();

            return banco.Delete(nomeArquivo);
        }

    }
}
