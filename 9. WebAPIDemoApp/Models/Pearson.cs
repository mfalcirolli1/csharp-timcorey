using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemoApp.Models
{
    /// <summary>
    /// Represeta uma pessoa específica
    /// </summary>
    public class Pearson
    {
        /// <summary>
        /// Primeiro Nome
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Último Nome
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// ID do SQL
        /// </summary>
        public int Id { get; set; } = 0;

    }
}