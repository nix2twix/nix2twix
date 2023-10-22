
var n,x,y,i: integer;
p:real;

begin
write('Введите число n= ');
readln(n);
p:=1;
for i:=1 to n do
begin
p:=p*((2*i)/(2*i+1));
end;
writeln(p);
end.
