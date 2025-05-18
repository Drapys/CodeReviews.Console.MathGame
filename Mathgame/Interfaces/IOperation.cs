using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathgame.Models;

namespace Mathgame.Interfaces
{
    internal interface IOperation
    {
        #region properties
        string Name { get; set; }


        #endregion
        #region methods

        public OperationOutput UseOperation(OperationInput input)
        {

        }
        #endregion
    }
}
