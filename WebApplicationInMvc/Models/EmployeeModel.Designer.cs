﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WebApplicationInMvc.Models
{
    #region Contextes
    
    /// <summary>
    /// Aucune documentation sur les métadonnées n'est disponible.
    /// </summary>
    public partial class EmployeeModelContainer : ObjectContext
    {
        #region Constructeurs
    
        /// <summary>
        /// Initialise un nouvel objet EmployeeModelContainer à l'aide de la chaîne de connexion trouvée dans la section 'EmployeeModelContainer' du fichier de configuration d'application.
        /// </summary>
        public EmployeeModelContainer() : base("name=EmployeeModelContainer", "EmployeeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisez un nouvel objet EmployeeModelContainer.
        /// </summary>
        public EmployeeModelContainer(string connectionString) : base(connectionString, "EmployeeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisez un nouvel objet EmployeeModelContainer.
        /// </summary>
        public EmployeeModelContainer(EntityConnection connection) : base(connection, "EmployeeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Méthodes partielles
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
