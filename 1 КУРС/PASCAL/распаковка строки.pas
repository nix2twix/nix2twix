//Будем рассматривать только строчки, состоящие из заглавных английских букв. Например, рассмотрим строку AAAABCCCCCDDDD.
//Длина этой строки равна 14. Поскольку строка состоит только из английских букв, повторяющиеся символы могут быть удалены и заменены числами, 
//определяющими количество повторений. Таким образом, данная строка может быть представлена как 4AB5C4D. Длина такой строки 7. Описанный метод мы назовем упаковкой строки.
//Напишите программу, которая берет упакованную строчку и восстанавливает по ней исходную строку.

var s,c,s1,c2: string;
    x,k,i,cout,j,n,m,z,q:integer;
    f: text;
    ch: set of 'A'..'Z';
  begin 
    assign(f,'input.txt');
    reset(f);
    readln(s);
    close(f);
    assign(f,'input.txt'); //3A4B7D
    reset(f);
    s:=s+' ';
    while s<>'' do
    begin
         n:=0;
         c:=copy(s,1,1);
         delete(s,1,1);
         s1:=copy(s,1,1);
         if (s1 in ch) then 
            begin c2:=copy(s,1,1);
                  delete(s,1,1);
                  s1:=copy(s,1,1);
            end;
         val(c,n,m); //кол-во
         val(c2,z,q);
         n:=z+10*n;
         for j:=1 to n do begin
           inc(k);
           write(s1);
           if k=40 then writeln;
         end;
        delete(s,1,1);
    end;
    close(f);
  end.