using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class AccessDemo
    {
        /// <summary>
        /// Acesso em qualquer assembly e/ou classe
        /// </summary>
        public void PublicDemo()
        {

        }

        /// <summary>
        /// Acesso apenas na classe em questão
        /// </summary>
        private void PrivateDemo()
        {

        }

        /// <summary>
        /// Acesso apenas no projeto (assembly) em questão
        /// </summary>
        internal void InternalDemo()
        {

        }

        /// <summary>
        /// Permite ser chamada da classe onde é declarado (AccessDemo) OU
        /// De qualquer outra classe de qualquer assembly que herde dela. 
        /// </summary>
        protected void ProtectedDemo()
        {

        }

        /// <summary>
        /// Permite ser chamada da classe onde é declarado (AccessDemo) OU
        /// Apenas de classes do mesmo assembly que herde dela.
        /// </summary>
        private protected void PrivateProtectedDemo()
        {

        }

        /// <summary>
        /// Permite ser chamada da classe onde é declarado (AccessDemo) OU
        /// De qualquer outra classe de qualquer assembly que herde dela.
        /// </summary>
        protected internal void ProtectedInternal()
        {

        }
    }
}
