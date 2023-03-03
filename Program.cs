class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input password : "); 
            int pass = int.Parse(Console.ReadLine()); // รับค่า password มาจากผู้ใช้
            Console.WriteLine("Input organization : ");
            string org = Console.ReadLine(); // รับชื่อองค์กรมาจากผู้ใช้
            if(org == "CIA") // แยกเงื่อไข 3 ข้อเป็นชื่อย่อของแต่ละองค์กร
            {
                int pass1 = pass % 10; // นำพาสเวิร์ดมาม็อดด้วย 10 เพื่อเอาเลขหลักหน่วย 789123 % 10 = 3
               //Console.WriteLine(pass1);
                if (pass1 % 3 == 0) // เช็คว่าพาสเวิร์ดหาร 3 ลงตัวไหม
                {
                    int pass2 = pass / 10; // นำพาสเวิร์ดมาหาร 10 เพื่อเอาตัวเลขหลักสิบเนื่องจากการหารใน c# ไม่เอาเศษจะได้เป็น 123789 / 10 = 12378.9 หรือเท่ากับ 12378
                    pass2 = pass2 % 10; // เอาพาสเวิร์ดมาม็อด 10 เพื่อหาเลขหลักเดียว
                    //Console.WriteLine(pass2);
                    if (pass2 != 1 && pass2 != 3 && pass2 != 5) // เงื่อนไขที่ไม่ใช่ 1 3 และ 5 
                    {
                        int pass3 = pass / 1000; // เอาพาสเวิร์ดมาหารพัน เพื่อเอาเลขหลักพัน
                        //Console.WriteLine(pass3);
                        if (pass3 % 10 >= 6 && pass3 % 10 != 8) //  เงื่อนเขที่เลขหลักพันต้องมากกว่าเท่ากับ 6 แต่ไม่ใช่ 8
                        {
                            Console.WriteLine("True"); // ปริ้นค่าให้ผู้ใช้เป็น True
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if(org == "FBI") // องค์กร FBI
            {
                int pass1 = pass / 100000; // เอาพาสเวิร์ดมาหารแสนเพื่อเอาเลขหลักแสนข้างหน้าสุด 698765/100000 = 6.98765 หรือเท่ากับ 6
                //Console.WriteLine(pass1);
                if(pass1 == 4 || pass1 == 5 || pass1 == 6 || pass1 == 7) //  เงื่อนไขที่พาสต้องอยู่ในช่วง 4-7
                {
                    int pass2 = pass / 100; // เอาพาสเวิร์ดมาหารร้อนเอาเลขหลักร้อย
                    //Console.WriteLine(pass2);
                    if (pass2 % 2 == 0 && pass2 %10 != 6)
                    {
                        int pass3 = pass / 10000; // เอาพาสเวิร์ดมาหารหมื่นเพื่อเอาเลขหลักหมื่น
                        //Console.WriteLine(pass3);
                        if (pass3 % 2 == 1) // เงื่อนไขที่รหัสต้องเป็นเลขคี่
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if(org == "NSA")
            {
                int pass1 = pass % 10;
                //Console.WriteLine(pass1);
                if (pass1 == 1 || pass1 == 2 || pass1 == 3 
                    || pass1 == 5 || pass1 == 6) // เงื่อนไขที่ต้องเป็นตัวประกอบของ 30 (1 2 3 5 6)
                {
                    int pass2 = pass / 100; // เอาพาสเวิร์ดมาหารร้อยเอาเลขหลักร้อย
                    //Console.WriteLine(pass2);
                    pass2 = pass2 % 10;
                    if(pass2 % 3 == 0 && pass2 % 2 == 1) //เงื่อนไขที่หารด้วย 3 ลงตัวแต่หารด้วย 2 ไม่ลงตัว
                    {
                        int s1, s2, s3, s4, s5;
                        s1 = pass / 100000; s2 = pass / 10000; s3 = pass / 1000;
                        s4 = pass / 100; s5 = pass / 10; // เอาพาสเวิร์ดมาหารแต่ละหลักเพื่อเอาเลขที่ของแต่ละหลักตั้งแต่หลักแสนยันหลักหน่วยแล้วจึงไปม็อดด้วย 10 เพื่อไล่เช็คว่ามีตัวไหนเป็นเลข 7 หรือไม่
                        if (s1 % 10 == 7 || s2 % 10 == 7 || s3 % 10 == 7 ||
                            4 % 10 == 7 || s5 % 10 == 7 || pass % 10 == 7)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            
        }
    }
    