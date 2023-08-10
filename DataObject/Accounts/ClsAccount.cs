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
        private decimal[] _balance;
       

        #endregion

        #region Public Variables

        public string AccountCode { get => _accountCode; set => _accountCode = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal[] Balance { get => _balance; set => _balance = value; }
        public int InternalCode { get => _internalCode; set => _internalCode = value; }


        #endregion

        #region Constructor

        public ClsAccount() { 
        
            Balance = new decimal[2];
        }
        public ClsAccount(string accountCode, string name, int internalCode)
        {
            Balance = new decimal[2];
            AccountCode = accountCode;
            Name = name;
            InternalCode = internalCode;
        }


        #endregion

        #region Public Methods

        public void setBalance(decimal balance, int index)
        {
            Balance[index] = balance;
        }

        public decimal getBalance(int index)
        {
            return Balance[index];
        }


        #endregion

        #region Private methods

        #endregion

    }
}
