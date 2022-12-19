


#region Task 1
//using MethodsPractice;

//Calculate();

//static void Calculate()
//{
//    Calculator calculator = new Calculator();

//    Console.WriteLine("Add first number :");

//Number1: string number1 = Console.ReadLine();
//    int checkednumber1;
//    bool isParselNum1 = int.TryParse(number1, out checkednumber1);

//    if (!isParselNum1)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct number 1");
//        Console.ResetColor();
//        goto Number1;
//    }

//    Console.WriteLine("Add operation :");
//    string operation = Console.ReadLine();

//    Console.WriteLine("Add second number :");

//Number2: string number2 = Console.ReadLine();
//    int checkednumber2;
//    bool IsParseNum2 = int.TryParse(number2, out checkednumber2);

//    if (!IsParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 2");
//        Console.ResetColor();
//        goto Number2;
//    }
//    if (checkednumber2 == 0 && operation == "/")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please dont add 0");
//        Console.ResetColor();
//        goto Number2;
//    }


//    var result = calculator.Calculation(checkednumber1, checkednumber2, operation);

//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(result);
//    Console.ResetColor();

//}
#endregion


#region Task 2
//using MethodsPractice;

//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 25);

//GetDoctorsByBirthday(startDate, endDate);

//static void GetDoctorsByBirthday(DateTime start, DateTime end)
//{
//    var doctors = GetDoctors();

//    foreach (var doctor in doctors)
//    {
//        if (doctor.Birthday > start && doctor.Birthday < end)
//        {
//            Console.WriteLine($"{doctor.Name} {doctor.Surname} {doctor.Address} {doctor.Birthday}");
//        }
//    }
//}



//static Doctor[] GetDoctors()
//{
//    Doctor doctor1 = new Doctor
//    {
//        Name = "XX1",
//        Surname = "YY1",
//        Address = "AA1",
//        Birthday = new DateTime(1994, 10, 05)
//    };

//    Doctor doctor2 = new Doctor
//    {
//        Name = "XX2",
//        Surname = "YY2",
//        Address = "AA2",
//        Birthday = new DateTime(2000, 10, 05)
//    };

//    Doctor doctor3 = new Doctor
//    {
//        Name = "XX3",
//        Surname = "YY3",
//        Address = "AA3",
//        Birthday = new DateTime(2003, 10, 05)
//    };

//    Doctor doctor4 = new Doctor
//    {
//        Name = "XX4",
//        Surname = "YY4",
//        Address = "AA4",
//        Birthday = new DateTime(2005, 10, 05)
//    };

//    Doctor doctor5 = new Doctor
//    {
//        Name = "XX5",
//        Surname = "YY5",
//        Address = "AA5",
//        Birthday = new DateTime(2002, 10, 05)
//    };

//    Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5 };

//    return doctors;

//}
#endregion




#region Task 3
//using MethodsPractice;

//static Order[] GetOrders()
//{
//    var order1 = new Order(new DateTime(2022, 12, 18), 500);
//    var order2 = new Order(new DateTime(2022, 12, 19), 300);
//    var order3 = new Order(new DateTime(2022, 12, 19), 250);
//    var order4 = new Order(new DateTime(2022, 12, 20), 1500);
//    var order5 = new Order(new DateTime(2022, 12, 22), 1500);
//    var order6 = new Order(new DateTime(2022, 12, 28), 500);

//    Order[] orders = new Order[] { order1 };

//    return new Order[] { order1, order2, order3, order4, order5, order6 };
//}

//DateTime filteredDate = DateTime.Now.AddDays(1);

//double filteredPrice = 300;

//GetFilteredOrders(filteredDate, filteredPrice);


//static void GetFilteredOrders(DateTime date, double price)
//{
//    var orders = GetOrders();

//    foreach (var item in orders)
//    {
//        Console.WriteLine(item.Date.ToString("MM-dd-yyyy") + " " + item.Price);
//    }
//}
#endregion


