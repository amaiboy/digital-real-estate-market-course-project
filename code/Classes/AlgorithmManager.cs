using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace code.Classes
{
    public static class AlgorithmManager
    {
        public static class СurrencyСonverter
        {
            public static double GetDollarRate()
            {
                try
                {
                    string link = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=USD";
                    WebClient wc = new WebClient();
                    string xmlString = wc.DownloadString(link);
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(xmlString);
                    XmlNode rateNode = xmlDoc.SelectSingleNode("/exchange/currency/rate");
                    string usdRate = rateNode.InnerText;
                    double rate = Convert.ToDouble(usdRate, CultureInfo.InvariantCulture);
                    return rate;
                }
                catch (Exception ex)
                {
                    ExceptionManager.HandleException(ex, "Не вдалося отримати курс долара. Спробуйте пізніше", "Помилка отримання курсу");
                    return 0;
                }
            }
        }

        public static class ShowMap
        {
            public static void GoToMap(string adress)
            {
                try
                {
                    string url = $"https://www.google.com/maps/place/{adress}";
                    System.Diagnostics.Process.Start(url);
                }
                catch (Exception ex)
                {
                    ExceptionManager.HandleException(ex, "Не вдалося перейти на мапу. Спробуйте пізніше", "Помилка переходу на мапу");
                }
            }

        }

        public static class SortManager
        {
            private static void QuickSort(string type, List<Advertisement> list)
            {
                Sort(list, 0, list.Count - 1, type);
            }

            private static void Sort(List<Advertisement> list, int left, int right, string type)
            {
                if (left < right)
                {
                    int pivotIndex = Partition(list, left, right, type);
                    Sort(list, left, pivotIndex - 1, type);
                    Sort(list, pivotIndex + 1, right, type);
                }
            }

            private static int Partition(List<Advertisement> list, int left, int right, string type)
            {
                if (type == "Ціна")
                {
                    int pivot = list[right].Price;
                    int i = left - 1;
                    Advertisement temp;
                    for (int j = left; j < right; j++)
                    {
                        if (list[j].Price < pivot)
                        {
                            i++;
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                    temp = list[i + 1];
                    list[i + 1] = list[right];
                    list[right] = temp;
                    return i + 1;
                }
                if (type == "Назва")
                {
                    string pivot = list[right].Name;
                    int i = left - 1;
                    Advertisement temp;
                    for (int j = left; j < right; j++)
                    {
                        if ((string.Compare(list[j].Name, pivot) < 0))
                        {
                            i++;
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                    temp = list[i + 1];
                    list[i + 1] = list[right];
                    list[right] = temp;
                    return i + 1;
                }
                if (type == "Продавець")
                {
                    string pivot = list[right].Seller;
                    int i = left - 1;
                    Advertisement temp;
                    for (int j = left; j < right; j++)
                    {
                        if ((string.Compare(list[j].Seller, pivot) < 0))
                        {
                            i++;
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                    temp = list[i + 1];
                    list[i + 1] = list[right];
                    list[right] = temp;
                    return i + 1;
                }
                return 0;
            }

            private static void QuickSortDescending(string type, List<Advertisement> list)
            {
                SortDescending(list, 0, list.Count - 1, type);
            }

            private static void SortDescending(List<Advertisement> list, int left, int right, string type)
            {
                if (left < right)
                {
                    int pivotIndex = PartitionDescending(list, left, right, type);
                    SortDescending(list, left, pivotIndex - 1, type);
                    SortDescending(list, pivotIndex + 1, right, type);
                }
            }

            private static int PartitionDescending(List<Advertisement> list, int left, int right, string type)
            {
                if (type == "Ціна")
                {
                    int pivot = list[right].Price;
                    int i = left - 1;
                    Advertisement temp;
                    for (int j = left; j < right; j++)
                    {
                        if (list[j].Price > pivot)
                        {
                            i++;
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                    temp = list[i + 1];
                    list[i + 1] = list[right];
                    list[right] = temp;
                    return i + 1;
                }
                if (type == "Назва")
                {
                    string pivot = list[right].Name;
                    int i = left - 1;
                    Advertisement temp;
                    for (int j = left; j < right; j++)
                    {
                        if ((string.Compare(list[j].Name, pivot) > 0))
                        {
                            i++;
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                    temp = list[i + 1];
                    list[i + 1] = list[right];
                    list[right] = temp;
                    return i + 1;
                }
                if (type == "Продавець")
                {
                    string pivot = list[right].Seller;
                    int i = left - 1;
                    Advertisement temp;
                    for (int j = left; j < right; j++)
                    {
                        if ((string.Compare(list[j].Seller, pivot) > 0))
                        {
                            i++;
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                    temp = list[i + 1];
                    list[i + 1] = list[right];
                    list[right] = temp;
                    return i + 1;
                }
                return 0;
            }

            public static void SortListings(ComboBox dropdown, string sortType, DataGridView dataGridViewListings)
            {
                var nameHeading = "Назва";
                var sellerHeading = "Продавець";
                var priceHeading = "Ціна";

                var listingsCopy = GlobalData.AvailableListings.ToList();
                var selectedItem = dropdown.SelectedIndex;

                if (sortType == "byName")
                {
                    if (selectedItem == 0)
                    {
                        QuickSort(nameHeading, listingsCopy);
                        nameHeading = "Назва »";
                    }
                    else
                    {
                        QuickSortDescending(nameHeading, listingsCopy);
                        nameHeading = "Назва «";
                    }
                }
                else if (sortType == "bySeller")
                {
                    if (selectedItem == 0)
                    {
                        QuickSort(sellerHeading, listingsCopy);
                        sellerHeading = "Продавець »";
                    }
                    else
                    {
                        QuickSortDescending(sellerHeading, listingsCopy);
                        sellerHeading = "Продавець «";
                    }
                }
                else if (sortType == "byPrice")
                {
                    if (selectedItem == 0)
                    {
                        QuickSort(priceHeading, listingsCopy);
                        priceHeading = "Ціна »";
                    }
                    else
                    {
                        QuickSortDescending(priceHeading, listingsCopy);
                        priceHeading = "Ціна «";
                    }
                }

                dataGridViewListings.DataSource = listingsCopy;
                dataGridViewListings.Columns[0].HeaderText = nameHeading;
                dataGridViewListings.Columns[3].HeaderText = sellerHeading;
                dataGridViewListings.Columns[4].HeaderText = priceHeading;
            }
        }
    }
}
