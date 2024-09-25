using devPOO.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace devPOO.Utilidades
{
    public class DataCode
    {
        //CRIAR
        public string Create(Dictionary<string, object> pDados, string pNomeArquivo)
        {
            if (File.Exists(pNomeArquivo))
            {
                return "Arquivo já existe.";
            }
            StreamWriter arquivo = new StreamWriter(pNomeArquivo);
            Dictionary<string, Object> dict = new Dictionary<string, object>();

            foreach (var linha in pDados)
            {
                arquivo.WriteLine(linha.Key + " " + linha.Value);
            }

            arquivo.Flush();
            arquivo.Close();

            return "";
        }

        //LER
        public Dictionary<string, object> Read(string pNomeArquivo)
        {
            if (!File.Exists(pNomeArquivo))
            {
                return null;
            }
            
            Dictionary<string, object> dados = new Dictionary<string, object>();
            string linha;
            string[] registro;

            StreamReader arquivo = new StreamReader(pNomeArquivo);

            while (!arquivo.EndOfStream)
            {   
                linha = arquivo.ReadLine();
                registro = linha.Split(' ');
                dados.Add(registro[0], registro[1]);
            }

            arquivo.Close();
            return dados;
        }

        //ATUALIZAR
        public string Update(Dictionary<string, object> pDados, string pNomeArquivo)
        {
            if (!File.Exists(pNomeArquivo))
            {
                return "Arquivo não existe.";
            }
            StreamWriter arquivo = File.CreateText (pNomeArquivo);
      

            foreach (var item in pDados)
            {
                arquivo.WriteLine(item.Key + " " + item.Value);
            }

            arquivo.Flush();
            arquivo.Close();

            return "";
        }

        //DELETAR
        public string Delete(string pNomeArquivo)
        {
            if (!File.Exists(pNomeArquivo))
            {
                return "Arquivo não existe.";
            }
            File.Delete(pNomeArquivo);

            return "";
        }

        //FINALIZADO;

    }

}

