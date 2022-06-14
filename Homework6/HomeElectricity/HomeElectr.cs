using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// немає роботи з винятками, а це вже має бути нормою на постійній основі. Звикаємо!!!
namespace HomeElectricity
{//потрібно було користуватись готовим класом для роботи з датами
    struct Date
    {
        public int year;
        public int month;
        public int day;
    }
    struct MeterReading
    {
        public int initial;
        public int final;
    }
    struct DatesOfReading
    {
        public Date FirstMonth;
        public Date SecondMonth;
        public Date ThirdMonth;
    }

    
    internal class ElectricityOfHome
    {

        const int PriceOfkWh = 12;
        int CountOfFlat;
        //Коли розрізнені колекції є більший шанс помилитись
        // Ідентифікатори змінних прийнято писати  з малої літери
        string[] Months;
        int[] NumberOfFlat;
        string[] OwnerOfFlat;
        MeterReading[,] MeterReadingOfFlat;
        DatesOfReading[] DatesOfReadings;

        public ElectricityOfHome(string FileName)
        {
            StreamReader FileReader = new StreamReader(FileName);
            CountOfFlat = int.Parse(FileReader.ReadLine());
            string[] AllMonth = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int numbmonth = (int.Parse(FileReader.ReadLine()) - 1) * 3;
            Months = AllMonth[numbmonth..(numbmonth + 3)];

            NumberOfFlat = new int[CountOfFlat];
            OwnerOfFlat = new string[CountOfFlat];
            MeterReadingOfFlat = new MeterReading[CountOfFlat, 3];
            DatesOfReadings = new DatesOfReading[CountOfFlat];

            for (int i = 0; i < CountOfFlat; i++)
            {
                string a = FileReader.ReadLine();
                string[] data = a.Split(' ');
                NumberOfFlat[i] = int.Parse(data[0]); 
                OwnerOfFlat[i] = data[1];
                MeterReadingOfFlat[i,0].initial = int.Parse(data[2]);
                MeterReadingOfFlat[i,0].final = int.Parse(data[3]);

                string[] DMY = data[4].Split('.');
                Date date = new Date();
                date.day = int.Parse(DMY[0]);
                date.month = int.Parse(DMY[1]);
                date.year = int.Parse(DMY[2]);
                DatesOfReadings[i].FirstMonth = date;
                
                MeterReadingOfFlat[i, 1].initial = int.Parse(data[3]);
                MeterReadingOfFlat[i, 1].final = int.Parse(data[5]);
                
                DMY = data[6].Split('.');
                date = new Date();
                date.day = int.Parse(DMY[0]);
                date.month = int.Parse(DMY[1]);
                date.year = int.Parse(DMY[2]);
                DatesOfReadings[i].SecondMonth = date;

                MeterReadingOfFlat[i, 2].initial = int.Parse(data[5]);
                MeterReadingOfFlat[i, 2].final = int.Parse(data[7]);

                DMY = data[8].Split('.');
                date = new Date();
                date.day = int.Parse(DMY[0]);
                date.month = int.Parse(DMY[1]);
                date.year = int.Parse(DMY[2]);
                DatesOfReadings[i].ThirdMonth = date; 
            }
        }
//Файл треба було передати як параметр методу.
        public void ElectricityReport()
        {
            using (StreamWriter writer = new StreamWriter("ElectricityReport.txt", false, Encoding.Default))
            {
                writer.WriteLine("# \t|Lastname\t\t\t|Quarter\t\t\t\t\t|Arrears");
                writer.WriteLine("  \t\t\t|Starter\t|" + Months[0] + "\t|" + Months[1] + "\t|" + Months[2] + "\t|");
                for (int i = 0; i < CountOfFlat; i++)
                {
                    writer.WriteLine(+NumberOfFlat[i] + "\t|" + OwnerOfFlat[i] + " \t|" + MeterReadingOfFlat[i, 0].initial + "   \t|" + MeterReadingOfFlat[i, 1].initial+ "  \t|" + MeterReadingOfFlat[i, 2].initial 
                        + "  \t|" + MeterReadingOfFlat[i, 2].final + "\t|" + (MeterReadingOfFlat[i, 2].final - MeterReadingOfFlat[i, 0].initial) * PriceOfkWh);
                }
            }
        }

        public void NonActiveUser()
        {
            for(int i = 0;i < CountOfFlat; i++)
            {
                if (MeterReadingOfFlat[i, 2].final - MeterReadingOfFlat[i, 0].initial == 0)
                {
                    Console.WriteLine(OwnerOfFlat[i] + " \t|" + NumberOfFlat[i]);
                }
            }
        }

        public void MostActiveUser()
        {
            int N = 0;
            for(int i = 0;i<CountOfFlat; i++)
            {
                if (MeterReadingOfFlat[i, 2].final - MeterReadingOfFlat[i, 0].initial >= MeterReadingOfFlat[N, 2].final - MeterReadingOfFlat[N, 0].initial)
                {
                    N = i;
                }
            }
            Console.WriteLine((OwnerOfFlat[N] + " \t|" + NumberOfFlat[N]) + "\t" + (MeterReadingOfFlat[N, 2].final - MeterReadingOfFlat[N, 0].initial) * PriceOfkWh);
        }
    }  
}
