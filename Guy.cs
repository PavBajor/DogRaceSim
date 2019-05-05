using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public class Guy
    {
        public string _name;
        public Bet _bet;
        public int _cash;

        public RadioButton _radioButton;
        public Label _label;

        public Guy(string name, Bet bet, int cash, RadioButton radioButton, Label label)
        {
            this._name = name;
            this._bet = bet;
            this._cash = cash;
            this._radioButton = radioButton;
            this._label = label;
        }

        public void UpdateLabels()
        {
            if (_bet==null)
            {
                _label.Text = String.Format("{0} has not placed any bets", _name);
            }
            else
            {
                _label.Text = _bet.GetDescription();
            }
            _radioButton.Text = _name + " has " + _cash;

        }

        public void ClearBet()
        {
            _bet._amount = 0;
        }

        public bool PlaceBet(int _amount, int _dog)
        {
            if (_amount<=_cash)
            {
                _bet = new Bet(_amount, _dog, this);
                return true;
            }
            else
            {
                MessageBox.Show("Not enough money!");
                return false;
            }
            
        }

        public void Collect(int Winner)
        {
            _cash += _bet.PayOut(Winner);
        }

    }
}
