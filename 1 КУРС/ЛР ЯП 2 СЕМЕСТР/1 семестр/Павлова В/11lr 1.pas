var n,x,y: integer;
p:real;

begin
write('Введите число n= ');
readln(n);
x:=2;
y:=3;
p:=x/y;
while (x<(2*n)) and (y<(2*n+1)) do
  begin
  x:=x+2;
  y:=y+2;
  p:=p*(x/y);
  end;
if n=1 then p:=sqr(p);
writeln(p);
end.