

//1.შემოწმება, რიცხვი დადებითია თუ უარყოფითი
//დაწერეთ პროგრამა, რომელიც იღებს მთელ რიცხვს და ამოწმებს, არის თუ არა რიცხვი დადებითი, უარყოფითი, ან ნულოვანი.

//Random random = new Random();
//int number = random.Next();  
//if (number < 0)
//{
//    Console.WriteLine($"{number}, number is negative");
//}
//else
//{
//    Console.WriteLine($"{number}, number is positive");
//}



//2. შემოწმება, რიცხვი ლუწია თუ კენტი
//დაწერეთ პროგრამა, რომელიც იღებს მთელ რიცხვს და ამოწმებს, არის თუ არა ის ლუწი ან კენტი.

//Random random = new Random();
//int number = random.Next();
//if (number != 0)
//{
//    int remains = number % 2;
//    if (remains == 1 || remains == -1)
//    {
//        Console.WriteLine($"{number}, number is odd");
//    }
//    else
//    {
//        Console.WriteLine($"{number}, number is even");
//    }
//}
//else
//{
//    Console.WriteLine("Cannot be divided by 0");
//}

//3. შეფასების კატეგორიზაცია
//დაწერეთ პროგრამა, რომელიც იღებს სტუდენტის ქულას (0-დან 100-მდე) და ბეჭდავს შესაბამის ნიშანს შემდეგი სკალის მიხედვით:
//90 - 100: A
//80-89: B
//70-79: C
//60-69: D
//0-59: F

//Console.WriteLine("Enter your grade:");
//int grade = Convert.ToInt32(Console.ReadLine());

//if (90 <= grade && grade <= 100)
//{
//    Console.WriteLine("A");
//}
//else if (80 <= grade && grade <= 89)
//{
//    Console.WriteLine("B");
//}
//else if (70 <= grade && grade <= 79)
//{
//    Console.WriteLine("C");
//}
//else if (60 <= grade && grade <= 69)
//{
//    Console.WriteLine("D");
//}
//else
//{
//    Console.WriteLine("F");
//}



//4. ნაკიანი წლის შემოწმება
//დაწერეთ პროგრამა, რომელიც ამოწმებს, არის თუ არა წელი ნაკიანი. წელი ნაკიანია თუ:
//იყოფა 4-ზე, მაგრამ
//არ იყოფა 100-ზე, თუ ის ასევე არ იყოფა 400-ზე.

//Console.WriteLine("Enter year:");
//int year = Convert.ToInt32(Console.ReadLine());

//if (year % 4 == 0 && year % 100 != 0)
//{
//    Console.WriteLine("This is a leap year");
//}
//else if(year % 400 == 0)
//{
//    Console.WriteLine("This is a leap year");
//}
//else
//{ Console.WriteLine("This is not a leap year"); }


//5. პაროლის შემოწმება
//დაწერეთ პროგრამა, რომელიც იღებს მომხმარებლის შეყვანილ პაროლს და ამოწმებს,
//ემთხვევა თუ არა ის წინასწარ განსაზღვრულ პაროლს (მაგალითად, "secret123").
//თუ ემთხვევა, დაბეჭდეთ "Access Granted", თუ არ ემთხვევა, დაბეჭდეთ "Access Forbidden".

//string rightpassword = "secret123";
//Console.WriteLine("enter your password:");
//var password = Console.ReadLine();
//if (password == rightpassword)
//{
//    Console.WriteLine("Access Granted");
//}
//else
//{
//    Console.WriteLine("Access Forbidden");
//}


//6. სამი რიცხვიდან ყველაზე დიდის პოვნა
//დაწერეთ პროგრამა, რომელიც იღებს სამ რიცხვს და ბეჭდავს მათგან ყველაზე დიდს.


//Console.WriteLine("Enter first number: ");
//int first = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number: ");
//int second = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter third number: ");
//int third = Convert.ToInt32(Console.ReadLine());



//if (first == second)
//{
//    if (first == third)
//    {
//        Console.WriteLine("Three of them are the same");
//    }
//    else
//    {
//        if (third < first)
//        {
//            Console.WriteLine($"The first({first}) and second({second}) are the largest numbers");
//        }
//        else
//        {
//            Console.WriteLine($"The third({third}) is the largest number");
//        }
//    }
//}
//else if (third == second)
//{
//    if (first == third)
//    {
//        Console.WriteLine("Three of them are the same");
//    }
//    else
//    {
//        if (third > first)
//        {
//            Console.WriteLine($"The second({second}) and third({third}) are the largest numbers");
//        }
//        else
//        {
//            Console.WriteLine($"The first({first}) is the largest number");
//        }
//    }
//}
//else if (first > second)
//{
//    if (third < first)
//    {
//        Console.WriteLine($"The first({first}) is the largest number");
//    }
//    else
//    {
//        Console.WriteLine($"The third({third}) is the largest number");
//    }
//}
//else if (second > third)
//{
//    Console.WriteLine($"The second({second}) is the largest number");
//}
//else
//{
//    Console.WriteLine($"The third({third}) is the largest number");
//}

//--------------------------------------------------

//7. მარტივი კალკულატორი
//დაწერეთ პროგრამა, რომელიც მომხმარებლის შეყვანის საფუძველზე ასრულებს მარტივ
//არითმეტიკულ ოპერაციებს (დამატება, გამოკლება, გამრავლება ან გაყოფა) ორ რიცხვზე.

//Console.WriteLine("Enter first number: ");
//int first = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number: ");
//int second = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Choose an operation: ");
//Console.WriteLine("1.multiplication " );
//Console.WriteLine("2.division ");
//Console.WriteLine("3.deduction ");
//Console.WriteLine("4.addition: ");
//int operation = Convert.ToInt32(Console.ReadLine());

//if (operation == 1)
//{
//    Console.WriteLine("The multiplication of numbers is: " + (first * second));
//}
//else if (operation == 2)
//{
//    if ( second == 0)
//    {
//        Console.WriteLine("It cannot be divided by zero");
//    }
//    else
//    {
//        Console.WriteLine("The division of numbers is: " + (first / second));
//    }

//}
//else if (operation == 3)
//{
//    Console.WriteLine("The deduction of numbers is: " + (first - second));
//}
//else if (operation == 4)
//{
//    Console.WriteLine("The addition of numbers is: " + (first + second));
//}
//else
//{
//    Console.WriteLine("Invalid operation selected.");
//}

//--------------------------------------------------

//8. არჩევნების უფლებამოსილება
//დაწერეთ პროგრამა, რომელიც ამოწმებს, არის თუ არა პირი არჩევნებში ხმის მიცემისთვის უფლებამოსილი. პირი უნდა იყოს 18 წლის ან უფროსი.

//Console.WriteLine("enter your age: ");
//int age = int.Parse(Console.ReadLine());
//if (age > 18)
//{
//    Console.WriteLine("You can participate in the elections");
//}
//else
//{
//    Console.WriteLine("You can not participate in the elections");
//}


//--------------------------------------------------


//9. დღის მისალმება საათის მიხედვით
//დაწერეთ პროგრამა, რომელიც იღებს მიმდინარე დროს (საათების მიხედვით) და განსაზღვრავს შესაფერის მისალმებას:
//დილა(5:00 - 11:59)(Good Morning)
//შუადღე(12:00 - 16:59)(Good Afternoon)
//საღამო(17:00 - 20:59)(Good Evening)
//ღამე(21:00 - 4:59)(Good Night)

//Console.WriteLine("Enter the current time in hours (0-23):");
//int hours = Convert.ToInt32(Console.ReadLine());

//if (5 <= hours && hours < 12)
//{
//    Console.WriteLine("Good Morning");
//}
//else if (12 <= hours && hours < 17)
//{
//    Console.WriteLine("Good Afternoon");
//}
//else if (17 <= hours && hours < 21)
//{
//    Console.WriteLine("Good Evening");
//}
//else if (21 <= hours && hours < 5)
//{
//    Console.WriteLine("Good Night");
//}
//else
//{
//    Console.WriteLine("Invalid hours selected.");
//}

//--------------------------------------------------

//10.შოპინგის ფასდაკლების კალკულატორი
//დაწერეთ პროგრამა, რომელიც ითვლის ჯამურ თანხას ფასდაკლების შემდეგ, შემდეგი წესებით:
//თუ შესყიდვის საერთო თანხა ნაკლებია $100-ზე, არ არის ფასდაკლება.
//თუ შესყიდვის საერთო თანხა არის $100 და $500 შორის, გამოიყენეთ 10% ფასდაკლება.
//თუ შესყიდვის საერთო თანხა $500-ზე მეტია, გამოიყენეთ 20% ფასდაკლება.

//Console.WriteLine("enter the amount you paid");
//int money = int.Parse(Console.ReadLine());

//if (money < 100)
//{
//    Console.WriteLine(" you have to pay 100$");
//}
//else if (100 <= money && money < 500)
//{
//    Console.WriteLine($"You get a 10% discount and your bill is {money * 0.9} instead of {money}");
//}
//else
//{
//    Console.WriteLine($"You get a 20% discount and your bill is {money * 0.8} instead of {money}");
//}

//--------------------------------------------------

//11. ასაკობრივი და ქვეყნის შეზღუდვების მიხედვით პროდუქტის შეძენა
//დაწერეთ პროგრამა, რომელიც ამოწმებს, შეუძლია თუ არა მომხმარებელს პროდუქტის შეძენა ასაკის და ქვეყნის მიხედვით. პროდუქტის შეზღუდვები ასეთია:
//აშშ - ში მომხმარებელი უნდა იყოს 21 წლის ან უფროსი.
//სხვა ქვეყნებში, მომხმარებელი უნდა იყოს 18 წლის ან უფროსი. თუ მომხმარებელი უფლებამოსილია შეძენისათვის,
//დაბეჭდეთ "შეძენა ნებადართულია", წინააღმდეგ შემთხვევაში "შეძენა აკრძალულია".
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.WriteLine("enter your age");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine("enter country where you ar living: ");
//string country = Console.ReadLine().ToLower();

//if (age >= 21 && country == "america" )
//{
//    Console.WriteLine("შეძენა ნებადართულია");
//}
//else if (age >= 18)
//{
//    Console.WriteLine("შეძენა ნებადართულია");
//}
//else
//{
//    Console.WriteLine("შეძენა აკრძალულია");
//}



//---------------------------------------------------------

//12. სესხის უფლებამოსილება
//დაწერეთ პროგრამა, რომელიც განსაზღვრავს, არის თუ არა პირი სესხის მისაღებად უფლებამოსილი. პირობებია:
//პირი უნდა იყოს 18 წლის ან უფროსი.
//პირს უნდა ჰქონდეს მინიმუმ $25,000 წლიური შემოსავალი.
//თუ პირს შემოსავალი ნაკლები აქვს $25,000-ზე, ის შეიძლება იყოს უფლებამოსილი თანამონაწილის (თავდების) ყოლის შემთხვევაში.

//Console.WriteLine("enter your age: ");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine("enter your income: ");
//int income = int.Parse(Console.ReadLine());

//if (age >= 18 && income >= 25000)
//{
//    Console.WriteLine("You are authorized to take out a loan");
//}
//else if (age >= 18 && income < 25000)
//{
//    Console.WriteLine("do you have guarantors (yes/no)");
//    string response = Console.ReadLine();
//    bool Guarantor = response.ToLower() == "yes";

//    if (Guarantor)
//    {
//        Console.WriteLine("You are authorized to take out a loan");
//    }
//    else
//    {
//        Console.WriteLine("You are not authorized to take out a loan");
//    }
//}
//else
//{
//    Console.WriteLine("You are not authorized to take out a loan");
//}


