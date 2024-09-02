//-------------------EMPLOYEE (abstract)----------------->
public interface Employee
{
    string Id { get; set; }
    string Name { get; set; }
    float Package { get; set; } //input in LPA
    int Attendance { get; set; }

    int Da { get; set; }
    int Ta { get; set; }
    int Hra { get; set; }
    int Ppf { get; set; }

    float GrossSalary { get; set; }
    float NetSalary { get; set; }
    float TotalSalary { get; set; }

    //acc to attendance
    float CalcGrossSalary();
    //acc to gross + ta + da + hra - ppf
    float CalcNetSalary();
    //netsal + incentives
    float CalcTotalSalary();
    void PrintSlip();
}

//-------------------DEVELOPER----------------->
public class Dev : Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public float Package { get; set; }
    public int Attendance { get; set; }

    public int Da { get; set; } = 2000;
    public int Ta { get; set; } = 2000;
    public int Hra { get; set; } = 15000;
    public int Ppf { get; set; } = 550;

    public int Incentives { get; set; } = 10000; 
    public float GrossSalary { get; set; }
    public float NetSalary { get; set; }
    public float TotalSalary { get; set; }

    public float CalcGrossSalary()
    {
        return Package * (Attendance / 31f);
    }

    public float CalcNetSalary()
    {
        return GrossSalary + Da + Ta + Hra - Ppf;
    }

    public float CalcTotalSalary()
    {
        return NetSalary + Incentives;
    }
    public void PrintSlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: Developer");
        Console.WriteLine($"Base Package: {Package}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary (acc to attendance): {GrossSalary}");
        Console.WriteLine($"Net Salary (GrossSal + Da + Ta + Hra - Ppf: {NetSalary}");
        Console.WriteLine($"Developer Specific Incentives: {Incentives}");
        Console.WriteLine($"Total Salary (Net Salary + Incentives): {TotalSalary}");
        Console.WriteLine();
    }

    //Constructor
    public Dev(string id, string name, float package, int attendance)
    {
        Id = id;
        Name = name;
        Package = (package*100000)/12;
        Attendance = attendance;
        GrossSalary = CalcGrossSalary();
        NetSalary = CalcNetSalary();
        TotalSalary = CalcTotalSalary();   
    }
}

//-------------------BACKOFFICE----------------->
public class BackOffice : Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public float Package { get; set; }
    public int Attendance { get; set; }

    public int Da { get; set; } = 1000;
    public int Ta { get; set; } = 1000;
    public int Hra { get; set; } = 8000;
    public int Ppf { get; set; } = 1050;

    
    public int Incentives { get; set; } = 0;    // 0 bcoz no Incentives to BackOffice workers
    public float GrossSalary { get; set; }
    public float NetSalary { get; set; }
    public float TotalSalary { get; set; }

    public float CalcGrossSalary()
    {
        return Package * (Attendance / 31f);
    }

    public float CalcNetSalary()
    {
        return GrossSalary + Da + Ta + Hra - Ppf;
    }

    public float CalcTotalSalary()
    {
        return NetSalary + Incentives;
    }
    public void PrintSlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: BackOffice");
        Console.WriteLine($"Base Package: {Package}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary (acc to attendance): {GrossSalary}");
        Console.WriteLine($"Net Salary (GrossSal + Da + Ta + Hra - Ppf: {NetSalary}");
        Console.WriteLine($"BackOffice Specific Incentives: {Incentives}");
        Console.WriteLine($"Total Salary (Net Salary + Incentives): {TotalSalary}");
        Console.WriteLine();
    }

    //Constructor
    public BackOffice(string id, string name, float package, int attendance)
    {
        Id = id;
        Name = name;
        Package = (package * 100000) / 12;
        Attendance = attendance;
        GrossSalary = CalcGrossSalary();
        NetSalary = CalcNetSalary();
        TotalSalary = CalcTotalSalary();
    }
}


//-------------------TESTER----------------->
public class Tester : Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public float Package { get; set; }
    public int Attendance { get; set; }

    public int Da { get; set; } = 1500;
    public int Ta { get; set; } = 3000;
    public int Hra { get; set; } = 6000;
    public int Ppf { get; set; } = 3000;


    public int Incentives { get; set; } 
    public int noProjTested { get; set; }    //Tester specific property
    public int noReports { get; set; }   //Tester specific property
    public float GrossSalary { get; set; }
    public float NetSalary { get; set; }
    public float TotalSalary { get; set; }

    int CalcIncentives()    //Tester specific method
    {
        if (this.noReports > 10 || this.noProjTested > 10) return 10000;
        else if (this.noReports > 5 || this.noProjTested > 5) return 5000;
        else return 1000;
    }
    public float CalcGrossSalary()
    {
        return Package * (Attendance / 31f);
    }

    public float CalcNetSalary()
    {
        return GrossSalary + Da + Ta + Hra - Ppf;
    }

    public float CalcTotalSalary()
    {
        return NetSalary + Incentives;
    }
    public void PrintSlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: Tester");
        Console.WriteLine($"Base Package: {Package}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary (acc to attendance): {GrossSalary}");
        Console.WriteLine($"Net Salary (GrossSal + Da + Ta + Hra - Ppf: {NetSalary}");
        Console.WriteLine($"Tester Specific Incentives (acc to proj tested and reports given): {Incentives}");
        Console.WriteLine($"Total Salary (Net Salary + Incentives): {TotalSalary}");
        Console.WriteLine();
    }

    //Constructor
    public Tester(string id, string name, float package, int attendance, int noProjTested, int noReports)
    {
        Id = id;
        Name = name;
        Package = (package * 100000) / 12;
        Attendance = attendance;
        this.noProjTested = noProjTested;
        this.noReports = noReports;

        Incentives = CalcIncentives();
        GrossSalary = CalcGrossSalary();
        NetSalary = CalcNetSalary();
        TotalSalary = CalcTotalSalary();
    }
}


//-------------------MKT----------------->
public class Mkt : Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public float Package { get; set; }
    public int Attendance { get; set; }

    public int Da { get; set; } = 500;
    public int Ta { get; set; } = 30;
    public int Hra { get; set; } = 6;
    public int Ppf { get; set; } = 6000;


    public int Incentives { get; set; } = -150;
    public float GrossSalary { get; set; }
    public float NetSalary { get; set; }
    public float TotalSalary { get; set; }

    public float CalcGrossSalary()
    {
        return Package * (Attendance / 31f);
    }

    public float CalcNetSalary()
    {
        return GrossSalary + Da + Ta + Hra - Ppf;
    }

    public float CalcTotalSalary()
    {
        return NetSalary + Incentives;
    }
    public void PrintSlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: Mkt");
        Console.WriteLine($"Base Package: {Package}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary (acc to attendance): {GrossSalary}");
        Console.WriteLine($"Net Salary (GrossSal + Da + Ta + Hra - Ppf: {NetSalary}");
        Console.WriteLine($"Mkt Specific Incentives: {Incentives}");
        Console.WriteLine($"Total Salary (Net Salary + Incentives): {TotalSalary}");
        Console.WriteLine();
    }

    //Constructor
    public Mkt(string id, string name, float package, int attendance)
    {
        Id = id;
        Name = name;
        Package = (package * 100000) / 12;
        Attendance = attendance;

        GrossSalary = CalcGrossSalary();
        NetSalary = CalcNetSalary();
        TotalSalary = CalcTotalSalary();
    }
}

class Execution {
    //Data structures
    public static Dev[] Devs;
    public static BackOffice[] BackOffices;
    public static Tester[] Testers;
    public static Mkt[] Mkts;
    public static int globalUniqueId = 1;

    //Making UI
    public static void Main(string[] args)
    {
        //Taking All Employees' Details
        Console.WriteLine("Enter the team details of org");

        //----------DEVELOPER--------->
        Console.WriteLine("How many Devs?: ");
        int noDevs = int.Parse(Console.ReadLine()!);
        Devs = new Dev[noDevs];
        for (int i = 0; i < noDevs; i++)
        {
            string id = globalUniqueId++.ToString();
            Console.Write("Enter Dev's Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Enter Package in LPA like 12, 8: ");
            float pkg = float.Parse(Console.ReadLine()!);
            Console.Write("Enter attendance 0-31: ");
            int attendance = int.Parse(Console.ReadLine()!);

            Devs[i] = new Dev(id, name, pkg, attendance);
        }

        //----------BACKOFFICE--------->
        Console.WriteLine("How many BackOffice workers?: ");
        int noBackOffice = int.Parse(Console.ReadLine()!);
        BackOffices = new BackOffice[noBackOffice];
        for (int i = 0; i < noBackOffice; i++)
        {
            string id = globalUniqueId++.ToString();
            Console.Write("Enter BackOffice workers's Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Enter Package in LPA like 12, 8: ");
            float pkg = float.Parse(Console.ReadLine()!);
            Console.Write("Enter attendance 0-31: ");
            int attendance = int.Parse(Console.ReadLine()!);

            BackOffices[i] = new BackOffice(id, name, pkg, attendance);
        }

        //----------TESTER--------->
        Console.WriteLine("How many Testers?: ");
        int noTesters = int.Parse(Console.ReadLine()!);
        Testers = new Tester[noTesters];
        for (int i = 0; i < noTesters; i++)
        {
            string id = globalUniqueId++.ToString();
            Console.Write("Enter Tester's Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Enter Package in LPA like 12, 8: ");
            float pkg = float.Parse(Console.ReadLine()!);
            Console.Write("Enter attendance 0-31: ");
            int attendance = int.Parse(Console.ReadLine()!);
            Console.Write("Enter No of Projects Tested like 12: ");
            int noProjTested = int.Parse(Console.ReadLine()!);
            Console.Write("Enter No of Reports Given like 7: ");
            int noReports = int.Parse(Console.ReadLine()!);

            Testers[i] = new Tester(id, name, pkg, attendance, noProjTested, noReports);
        }

        //----------MKT--------->
        Console.WriteLine("How many Marketing workers?: ");
        int noMkts = int.Parse(Console.ReadLine()!);
        Mkts = new Mkt[noMkts];
        for (int i = 0; i < noMkts; i++)
        {
            string id = globalUniqueId++.ToString();
            Console.Write("Enter Worker's Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Enter Package in LPA like 4: ");
            float pkg = float.Parse(Console.ReadLine()!);
            Console.Write("Enter attendance 0-31: ");
            int attendance = int.Parse(Console.ReadLine()!);

            Mkts[i] = new Mkt(id, name, pkg, attendance);
        }


        if (globalUniqueId == 1)
        {
            Console.WriteLine("No entried Made");
            return;
            //exit coz no entries made
        }

        //Drawing Menu to view Employees' PaySlip
        while (true)
        {
            Console.Write("Enter the Worker's Id: ");
            int id = int.Parse(Console.ReadLine()!);

            if (id < 1 || id >= globalUniqueId)
            {
                Console.WriteLine("Give valid ID");
                continue;
                //reprompt for id
            }

            //find the employee
            bool found = false;
            if (!found)
            {
                for (int i = 0; i < Devs.Length; i++)
                {
                    if (Devs[i].Id == id.ToString())
                    {
                        found = true;
                        Devs[i].PrintSlip();
                    }
                }
            }
            if (!found)
            {
                for (int i = 0; i < BackOffices.Length; i++)
                {
                    if (BackOffices[i].Id == id.ToString())
                    {
                        found = true;
                        BackOffices[i].PrintSlip();
                    }
                }
            }
            if (!found)
            {
                for (int i = 0; i < Testers.Length; i++)
                {
                    if (Testers[i].Id == id.ToString())
                    {
                        found = true;
                        Testers[i].PrintSlip();
                    }
                }
            }
            if (!found)
            {
                for (int i = 0; i < Mkts.Length; i++)
                {
                    if (Mkts[i].Id == id.ToString())
                    {
                        found = true;
                        Mkts[i].PrintSlip();
                    }
                }
            }
        }
    }
}