using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.Accounts
{
    public abstract
        class ClsAccount
    {
        #region Private variables

        private int _internalCode;
        private string _accountCode;
        private string _name;
        //TODO: Validar que no se puedan ingresar balances negativos
        private decimal _balance;
       

        #endregion

        #region Public Variables

        public string AccountCode { get => _accountCode; set => _accountCode = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Balance { get => _balance; set => _balance = value; }
        public int InternalCode { get => _internalCode; set => _internalCode = value; }


        #endregion

        #region Constructor

        public ClsAccount() { }
        public ClsAccount(string accountCode, string name, decimal balance, int internalCode)
        {
            AccountCode = accountCode;
            Name = name;
            Balance = balance;
            AccountCode = accountCode;
            Name = name;
            Balance = balance;
            InternalCode = internalCode;
        }


        #endregion

        #region Public Methods

        #endregion

        #region Private methods

        #endregion

    }
}
