using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public static class GlobalSettings
    {
        public static decimal MinDeposit { get; set; } = 1000000; // Quy định tiền gửi tối thiểu
        public static decimal InitialDeposit { get; set; } = 1000000; // Quy định tiền mở sổ ban đầu
    }
}
