تعلمت في الفيديو ازاي اعمل if condition و ازاي اعمل switch و طبقت برامج عليها زي الكود الي هعرضه دلوقتي 
اول حاجة حددت متغير من نوع string علشان اكتب فيه الحرف الي بيمثل الدرجة
تاني حاجة عملت حالة if و بعدين عملت switch لل variable بتاعي ال هو grade
وبعدين عملت default علشان لو مفيش حاجة مكتوبة من الي فوق يعرف اليوزر انه دخل حاجة غلط و يعدلها
حقوق الملكية الفكرية

<img src="https://res.cloudinary.com/dpl0kiz1a/image/upload/v1760872563/1\_gjjb2a.png" alt="حقوق الملكية" width="100"/>  

- 💬 واتساب : [اضغط هنا](https://wa.me/201555303227)
- 📩 البريد الرسمي : codejourney02@gmail.com
- 💼 LinkedIn : [https://www.linkedin.com/company/code-journey25/](https://www.linkedin.com/company/code-journey25/)

© 2025 Code Journey. جميع الحقوق محفوظة.

- الاستخدام شخصي وتعليمي فقط.
- لا يُسمح بالنسخ أو النشر أو التوزيع دون إذن كتابي.
- يمكن الاقتباس مع ذكر المصدر ورابط مباشر.
- أي تعديل أو إعادة استخدام يحتاج موافقة مسبقة.

> احترم حقوق الملكية لدعم استمرار وتطوير هذا المشروع التعليمي.


            string grade = Console.ReadLine();
            if (grade == "A")
            {
                Console.WriteLine("Excellent");
            }
            switch (grade)
            {
                case "A":
                    Console.WriteLine("excellent");
                    break;
                case "B":
                    Console.WriteLine("very good");
                    break;
                    case "C": Console.WriteLine("good");
                    break;
                    case "D": Console.WriteLine("Pass");
                    break;
                case "F": Console.WriteLine("fail");
                    break;
                    default: Console.WriteLine("invalid grade");
                    break;
                    
                    