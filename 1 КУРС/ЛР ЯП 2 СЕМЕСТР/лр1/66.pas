﻿{Дано натуральное число n (n < 100). Определить число способов 
выплаты суммы n рублей с помощью монет достоинством 1, 2, 5 рублей и 
бумажных купюр достоинством 10 рублей. Вывести на экран все способы 
выплаты.}

var n,x10,x5,x2,x1,c: integer;
begin
  readln(n); //cумма
  c:=0;
  writeln('Варианты: ');
  for x10:=0 to (n div 10) do
    for x5:=0 to (n - x10*10) div 5 do
      for x2:=0 to (n-x10*10 - x5*5) div 2    
      do begin
          inc(c);
          x1:=n-x10*10-x5*5-x2*2;
          writeln('10*', x10, ' + 5*', x5, ' + 2*', x2, ' + 1*', x1);
        end;
  writeln('Количество вариантов: ', c);
end.
