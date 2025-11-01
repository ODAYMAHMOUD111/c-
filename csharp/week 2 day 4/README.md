اتعلمت في الفيديو ازاي اعمل condition بطريقة غير if و هي
condition ? true : false;
لو true هتنفذ علطول لو false هتروح للكلمة بعد true و تنفذها
اتعلمت string format و ازاي اعمل الارقام بنفس الشكل
عملت برنامج ياخد درجتك و استخدمت بعدها ال condition و خزنتها في string 
و عملت الارقام بكذا format 

char choice;
              do
              {
                  Console.WriteLine("please enter your grade");
                  float grade = float.Parse(Console.ReadLine());
                  string result = grade >= 50 ? "passed" : "failed";
                  Console.WriteLine(result);
                  Console.WriteLine("do you want calculate another student result y/n");
                  choice = char.Parse(Console.ReadLine());
              } while (choice == 'y');
              Console.WriteLine("program ended");
            
            double value = 1000D / 12.34D;
            Console.WriteLine("{0:f2}", value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = 100 / 3D; 

            حقوق الملكية

💬 واتساب : اضغط هنا 📩 البريد الرسمي : codejourney02@gmail.com 💼 LinkedIn : https://www.linkedin.com/company/code-journey25/ © 2025 Code Journey. جميع الحقوق محفوظة.

الاستخدام شخصي وتعليمي فقط. لا يُسمح بالنسخ أو النشر أو التوزيع دون إذن كتابي. يمكن الاقتباس مع ذكر المصدر ورابط مباشر. أي تعديل أو إعادة استخدام يحتاج موافقة مسبقة. احترم حقوق الملكية لدعم استمرار وتطوير هذا المشروع التعليمي.
