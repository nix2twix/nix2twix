﻿//Даны натуральные числа М и N. Вывести старшую цифру дробной части и младшую цифру целой части числа M/N. 
program zadacha1;
var M,N,s,l,x: real;
y,k:integer;
begin
  writeln('Введите натуральные числа M, N');
  readln(M,N);
  s:=M/N; //частное
  if N=1 then begin
    y:=trunc(M) mod 10;
  writeln ('Старшая цифра дробной части = 0');
  writeln('Младшая цифра целой части = ',y);
  end
  else begin
  k:=trunc(s); //целая часть от частного (отбрасывается дробная часть)
  x:=k mod 10; //выделение младшей части целого
  l:=(s-k)*10; //выделение дробной части и сдвиг запятой
  writeln ('Старшая цифра дробной части = ',trunc(l));
  writeln ('Младшая цифра целой части = ',x);
  end;
end.
