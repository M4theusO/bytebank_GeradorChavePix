using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_GeradorChavePix
{
    /// <summary>
    /// Classe que gera chaves PIX usando o formato Guid.
    /// </summary>
    public static class GeradorPix
    {
        /// <summary>
        /// Método retorna uma chave aleatória de PIX.
        /// </summary>
        /// <returns>Retorna uma chave PIX no formato string.</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Método retorna uma lista aleatória de chaves PIX.
        /// </summary>
        /// <param name="numeroDeChaves"> Quantidade de chaves a serem geradas.</param>
        /// <returns>Uma lista de strings de chaves PIX.</returns>
        public static List<string> GetChavesPix(int numeroDeChaves)
        {
            if(numeroDeChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroDeChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}
