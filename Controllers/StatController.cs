using Models;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class StatController : IStatController
    {
        public List<StatRevenue> FindBestSellDays(List<BillDetail> bills, string dateStr)
        {
            var dateFormat = "dd/MM/yyyy";
            List<StatRevenue> result = new List<StatRevenue>();
            foreach (var bill in bills)
            {
                if (bill.Status.CompareTo("Đã thanh toán") == 0 &&
                    bill.CreatedTime.ToString("MM/yyyy").CompareTo(dateStr) == 0)
                {
                    bool isExisted = false;
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i].Date.ToString(dateFormat).
                            CompareTo(bill.CreatedTime.ToString(dateFormat)) == 0)
                        {
                            result[i].Revenue += bill.TotalAmount;
                            result[i].TotalItem += bill.TotalItem;
                            result[i].TotalDiscount += bill.TotalDiscountAmount;
                            isExisted = true;
                            break;
                        }
                    }
                    if (!isExisted)
                    {
                        var revenueStat = new StatRevenue(bill.CreatedTime, bill.TotalItem,
                            bill.TotalAmount, bill.TotalDiscountAmount);
                        result.Add(revenueStat);
                    }
                }
            }
            result.Sort();
            int k = 10;
            if (k > result.Count)
            {
                k = result.Count;
            }
            return result.GetRange(0, k);
        }

        public List<StatModel> FindBestSellItem(List<BillDetail> bills)
        {
            List<StatModel> result = new List<StatModel>();
            foreach (var bill in bills)
            {
                if (bill.Status.CompareTo("Đã thanh toán") == 0)
                {
                    foreach (var item in bill.Cart.SelectedItems)
                    {
                        bool isExisted = false;
                        for (int i = 0; i < result.Count; i++)
                        {
                            if (item.Equals(result[i].Item))
                            {
                                result[i].TotalRevenue += item.NumberOfSelectedItem * item.PriceAfterDiscount;
                                result[i].TotalItem += item.NumberOfSelectedItem;
                                isExisted = true;
                                break;
                            }
                        }
                        if (!isExisted)
                        {
                            var statModel = new StatModel(item, item.NumberOfSelectedItem,
                                item.NumberOfSelectedItem * item.PriceAfterDiscount);
                            result.Add(statModel);
                        }
                    }
                }
            }
            result.Sort();
            return result;
        }

        public List<StatRevenue> FindDailyRevenue(List<BillDetail> bills, string dateStr)
        {
            var dateFormat = "dd/MM/yyyy";
            List<StatRevenue> result = new List<StatRevenue>();
            foreach (var bill in bills)
            {
                if (bill.Status.CompareTo("Đã thanh toán") == 0 &&
                    bill.CreatedTime.ToString("MM/yyyy").CompareTo(dateStr) == 0)
                {
                    bool isExisted = false;
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i].Date.ToString(dateFormat).CompareTo(bill.CreatedTime.ToString(dateFormat)) == 0)
                        {
                            result[i].Revenue += bill.TotalAmount;
                            result[i].TotalItem += bill.TotalItem;
                            result[i].TotalDiscount += bill.TotalDiscountAmount;
                            isExisted = true;
                            break;
                        }
                    }
                    if (!isExisted)
                    {
                        var revenue = new StatRevenue(bill.CreatedTime, bill.TotalItem,
                            bill.TotalAmount, bill.TotalDiscountAmount);
                        result.Add(revenue);
                    }
                }
            }
            result.Sort();
            return result;
        }

        public List<StatRevenue> FindMonthlyRevenue(List<BillDetail> bills, string dateStr)
        {
            var dateFormat = "MM/yyyy";
            List<StatRevenue> result = new List<StatRevenue>();
            foreach (var bill in bills)
            {
                if (bill.Status.CompareTo("Đã thanh toán") == 0 &&
                    bill.CreatedTime.ToString("yyyy").CompareTo(dateStr) == 0)
                {
                    bool isExisted = false;
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i].Date.ToString(dateFormat).CompareTo(bill.CreatedTime.ToString(dateFormat)) == 0)
                        {
                            result[i].Revenue += bill.TotalAmount;
                            result[i].TotalItem += bill.TotalItem;
                            result[i].TotalDiscount += bill.TotalDiscountAmount;
                            isExisted = true;
                            break;
                        }
                    }
                    if (!isExisted)
                    {
                        var revenue = new StatRevenue(bill.CreatedTime, bill.TotalItem,
                            bill.TotalAmount, bill.TotalDiscountAmount);
                        result.Add(revenue);
                    }
                }
            }
            result.Sort();
            return result;
        }

        public List<StatCustomer> FindMostBoughtCustomer(
            List<BillDetail> bills, int numberOfCustomer, DateTime start, DateTime end)
        {
            List<StatCustomer> stats = new List<StatCustomer>();
            foreach (var bill in bills)
            {
                // nếu như hóa đơn lập trong khoảng thời gian đang xét
                if (bill.Status.CompareTo("Đã thanh toán") == 0 &&
                    bill.CreatedTime >= start.Date && bill.CreatedTime <= end.Date)
                {
                    bool isExisted = false;
                    // tìm trong danh sách kết quả xem đã có khách hàng đang xét chưa
                    for (int i = 0; i < stats.Count; i++)
                    {
                        if (stats[i].Customer.Equals(bill.Cart?.Customer))
                        {
                            stats[i].TotalAmount += bill.TotalAmount;
                            isExisted = true;
                            break;
                        }
                    }
                    if (!isExisted)
                    {
                        stats.Add(new StatCustomer(bill.Cart?.Customer, bill.TotalAmount));
                    }
                }
            }
            stats.Sort();
            if (numberOfCustomer > stats.Count)
            {
                numberOfCustomer = stats.Count;
            }
            return stats.GetRange(0, numberOfCustomer);
        }
    }
}
