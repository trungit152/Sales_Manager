using System.Collections.Generic;
using Models;
using System;

namespace Controllers
{
    public interface IStatController
    {
        List<StatModel> FindBestSellItem(List<BillDetail> bills);
        List<StatCustomer> FindMostBoughtCustomer(List<BillDetail> bills, int numberOfCustomer, DateTime start, DateTime end);
        List<StatRevenue> FindBestSellDays(List<BillDetail> bills, string dateStr);
        List<StatRevenue> FindMonthlyRevenue(List<BillDetail> bills, string dateStr);
        List<StatRevenue> FindDailyRevenue(List<BillDetail> bills, string dateStr);
    }
}
