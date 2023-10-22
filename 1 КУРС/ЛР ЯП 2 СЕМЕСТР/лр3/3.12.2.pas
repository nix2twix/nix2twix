{12.2 С клавиатуры вводятся два целых числа. Определить, сумма цифр которого из
них больше. Подсчет суммы цифр организовать через функцию.}

function sum(a:integer):integer; //324
var p,q:integer;
begin
while abs(a)>0 do begin
p:=abs(a) mod 10; //4    
a:=abs(a) div 10; //32
q:=q+p; 
end;
result:=q;
end;

var x,y: integer;
begin
  readln(x);
  readln(y);
  if sum(x) > sum (y) then writeln('Сумма цифр числа ',x, ' больше и равна ', sum(x))
  else writeln('Сумма цифр числа ',y, ' больше и равна ', sum(y))
end.