﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralLib.Protocols;

namespace TestDll
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseProtocol pr = new Protocol_MG08(1, 0);
            var status = pr.status;
            //var daystatus = pr.dayReport;
            pr.FPDayReport(0);
            //pr.FPDayClrReport(0);
            //var stSAles = pr.FPSaleEx(10, 0, false, 11900, 1, false, "Батон горчичный нарезаный КХЗ #3", 3);
            //var stSAles1 = pr.FPSaleEx(2, 0, false, 11900, 1, false, "Батон горчичный нарезаный КХЗ #2", 2);
            //var stPay = pr.FPPayment(3, 500000, false, true);
            //Батон горчичный нарезаный КХЗ №1
            //var checkinfo = pr.FPGetCheckSums();
            //var papstat = pr.papStat;
            //pr.FPResetOrder();
            pr.Dispose();
        }
    }
}
