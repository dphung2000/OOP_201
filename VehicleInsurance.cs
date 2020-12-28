using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class VehicleInsurance
    {
        protected int _InsuranceFee;
        protected string _InsuranceCompany;
        protected int _EffectiveDay;
        protected int _ExpirationDay;

        public VehicleInsurance()
        {
            this._InsuranceFee = this._EffectiveDay = this._ExpirationDay = -1;
            this._InsuranceCompany = "";
        }
        public VehicleInsurance(int InsuranceFee)
        {
            this._InsuranceFee = InsuranceFee;
            this._InsuranceCompany = "";
            this._EffectiveDay = this._ExpirationDay = -1;
        }
        public VehicleInsurance(int InsuranceFee,string InsuranceCompany,int EffectiveDay, int ExpirationDay)
        {
            InsuranceFee = _InsuranceFee;
            InsuranceCompany = _InsuranceCompany;
            EffectiveDay = _EffectiveDay;
            ExpirationDay = _ExpirationDay;
        }
    }
}
