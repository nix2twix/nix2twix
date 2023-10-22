//19,35,66
// Целочисленная арифметика. Даны натуральные числа n (n<1000000) и m (m<10). Проверить, есть ли в записи числа n цифра m.
var m,n,y,x:integer;
begin
  readln(n,m);
  y:=n;
  while n>0 do
      begin
      x:=n mod 10;
      n:=n div 10;
      if x=m then 
            begin 
            writeln('Цифра ',m,' ЕСТЬ в записи числа ',y);
            break;
            end;
      end;
  if n<=0 then writeln('Цифры ',m,' НЕТ в записи числа ',y);
  
end.