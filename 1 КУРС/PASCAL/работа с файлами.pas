//работа с файлами
// 1)описание файловой пер
var <имя переменной>: file of <тип элементов>
var f1: file of integer;
    f2: text; //текстовый файл
// 2)назначение файловой пер внешнему файлу
assign (<файловая пер>, <путь к файлу>);
//3)открытие для чтения
reset (<пер>); rewrite (<пер>); (read/write/close)

    //запись в файл
    
    assign(f1, 'file1.txt');
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
    
    //конец файла eof - end of file
    функция eof <имя пер> - возвращает true, если достигнут
    конец файла при чтении (или false);