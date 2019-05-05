using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp9
{
    public class Bet
    {
        public int _amount;
        public int _dog;
        public Guy _bettor;

        public Bet(int amount, int dog, Guy bettor)
        {
            this._amount = amount;
            this._dog = dog;
            this._bettor = bettor;
        }

        public string GetDescription()
        {
            string description = "";

            if (_amount > 0)
            {
                description = String.Format("{0} bets {1} on dog #{2}", _bettor._name, _amount, _dog);
            }
            else
            {
                description = String.Format("{0} has not placed any bets", _bettor._name);
            }
            return description;
        }

        public int PayOut(int Winner)
        {
            if (_dog==Winner)
            {
                return _amount;
            }
            return -_amount;
        }
    }
}
