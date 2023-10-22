{12.1 Определить функцию для вычисления наибольшего общего делителя двух
чисел. С использованием разработанной функции составить программу для
решения задачи: представить в виде обыкновенной несократимой дроби сумму
n дробей, вводимых пользователем.}

function gcd (p,q: Integer):Integer;
begin 
  var r: integer;
    repeat
    r:=p mod q;
    p:=q; q:=r;
    until r=0; 
  result:=p;
end;
var x2,y2,x1,y1,i,n,x,y,nod:integer;
begin
  readln(n);
  readln(x1,y1); //1-я дробь
  x:=x1; y:=y1;
      for i:=1 to n-1 do begin 
        readln(x2,y2);
        if y2<>y1 then begin
          x1:=x1*y2+x2*y1;
          y1:=y1*y2;
          x:=x1 div gcd(x1,y1);
          y:=y1 div gcd(x1,y1); end
        else begin
          x:=x+x2;
          y:=y1; end;
      end;
    
  nod:=gcd(x,y);
  writeln('До сокращения: ',x,'/',y);
  writeln('НОД числителя и знаменателя: ',nod);
  x:=x div nod;
  y:=y div nod;
  writeln('После сокращения: ',x,'/',y);
  
end.