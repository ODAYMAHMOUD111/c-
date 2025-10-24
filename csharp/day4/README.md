في الفيديو دا اتعلمنا طرق استعمال السترينج method زي اjoin ,string.format , replace , equal
equal علشان تتأكد ان المتغيرين متساويين
join علشان تحط المتغيرات جنب بعض بطريقة منظمة
replace لو عايز تغير كلمة في المتغير
format دا شكل بنعمله زي الي كاتبينه بس نقدر نعدل عليه
string myname = "ahmed mahmoud";

            Console.WriteLine("my name length is " + myname.Length);

            bool equalflag = string.Equals (myname.ToUpper(), "ahmed Mahmoud".ToUpper());
            string formatedstring = string.Format("are my strings  equal ? - {0}", equalflag);
            Console.WriteLine(formatedstring);
 
            string fullname1= "ahmed" + " " + "mahmoud";

            string fullname2 = string.Concat("ahmed", " ", "mahmoud");

            Console.WriteLine(string.Equals(fullname1, fullname2));

            Console.WriteLine(fullname1);
            Console.WriteLine(fullname2);



            string[] studentnames = new string[3];
            studentnames[0] = "ahmed";
            studentnames[1] = "oday";
            studentnames[2] = "hanaa";
            string studentnames1 = string.Join(" ", "ahmed","mahmoud");
            Console.WriteLine (studentnames1);

            Console.WriteLine(studentnames1.Replace("mahmoud", "mhmod"));
