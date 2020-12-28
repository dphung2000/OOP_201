using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    interface IRent
    {
        int AddCar(int carType, int rentCost, String brand, int runningDistance, int specificProperty);
        int AddContract(DateTime startDate, DateTime endDate = default(DateTime));
        bool AddCarToContract(int carID, int contractID);
        //bool AddCustomerToContract(int customerID, int contractID);
        //int AddCustomer(bool hasLicense, string customerName, int customerAge, string customerAddress);
        // đừng có gỡ comment mấy cái tui đã comment, vì người dùng không được dùng các hàm đã bị comment thông qua IRent
        bool RemoveCar(int carID);
        bool RemoveContract(int contractID);
        bool RemoveCarFromContract(int carID, int contractID);
        bool SetCar(int ID, String type, int rentCost, bool insurance);
        //bool RemoveCustomer(int customerID);

    }
}
