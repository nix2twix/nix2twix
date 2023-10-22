//Дано натуральное число n. 
//Переставить его цифры так, чтобы образовалось максимальное число, записанное теми же цифрами. 

function mysort(a: array of integer): array of integer;
begin
  var b,l,w,z: integer;  
  for z:=1 to length(a)-1 do
    begin 
      for w:=0 to length(a)-1 do
      if (w>0) and (a[w]>a[w-1]) then 
        begin 
        l:=a[w];
        a[w]:=a[w-1];
        a[w-1]:=l;
        end;
        end;
    result:=a;
end;

var n,x,y,i,k: integer;
    a: array of integer;
begin
  readln(n); //1024
  y:=n;
  while y>0 do begin //подсчёт числа цифр 
    y:=y div 10;
    inc(k);
    end;
  setlength(a,k);
  for i:=k-1 downto 0 do 
    begin 
    x:=n mod 10; //4
    n:=n div 10; //102
    a[i]:=x;
    end;
mysort(a);    
for i:=0 to k-1 do begin
write(a[i]);
end;

end.