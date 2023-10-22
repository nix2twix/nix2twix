//Дана величина А, выражающая объем информации в байтах. Перевести А в более крупные единицы измерения информации.
program zadacha2;
var A,B:real;
begin
  writeln ('Введите объем информации в байтах ');
  readln(A); //объем инф
  if A<power(2,10)
  then
    writeln('Объём информации ',A,' байт');
  if (power(2,10)<=A) and (A<power(2,20)) 
  then
    begin
    B:=A/power(2,10);
    writeln ('Объем информации = ',B,' килобайт');
    end;
  if (power(2,20)<=A) and (A<power(2,30)) 
  then
    begin
    B:=A/power(2,20);
    writeln ('Объем информации = ',B,' мегабайт');
    end;
  if (power(2,30)<=A)
  then
    begin
    B:=A/power(2,30);
    writeln ('Объем информации = ',B,' терабайт');
    end
end.
