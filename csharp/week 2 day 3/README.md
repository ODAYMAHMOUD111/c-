اتعلمت النهاردة عمل اللوب او التكرار عن طريق 3 طرق 
for و دي بتحط ال initialization , decrementation , incrementaion  و ال condition بالشكل التالي
for (initialization ; condition ; decrementation or incrementation) { instruction
}
و بطريقة while و دي بتكتب ال initialization الاول و بعدين ال condition بين قوسين ال while و بعدين ال decrementation 
بالشكل دا 
initialization
while (condition)
 {
 instruction
 c++ or c--}
 و اخدنا تكليف على   for (char a = 'a'; a <= 'z'; a++) الاول برنامج يطبع من a ل z
            {
                Console.WriteLine(a);
            }
        for (int i = 1; i <=4; i++) { تاني برنامج عملنا 2 لوب واحدة للتكرار وواحدة علشان تنزل سطر الكبيرة علشان تنزل سطر و الصغيرة علشان تعمل عدد النجوم الاول بدأنا ب 1 في الاتنين ف طلعت نجمة بعدين هيطلع و هنساوي j ب 2 و بعدين هنطلع للloop الي فوق و نوقف لما نوصل عند 4 نجوم
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
