var x,sum: integer;
    str: string; //СТРОКА
   f1,f2: text;
  begin 
    {assign(f1, 'file1.txt');
    rewrite(f1); //запись
    writeln(f1,15); //вывод не в окно, а в файл f1 (file1.txt)
    writeln(f1,'hello all!');
    close(f1);}
    
    //читает и выводит на экран
    
    assign(f2,'file1.txt');
    reset(f2); //открытие файла для чтения
    readln(f2,x);
    readln(f2,str);
    close(f2);
    
    writeln(x);
    writeln(str);
  end.