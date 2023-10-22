var arrT:array[1..10000000] of integer;
    arrN:array[1..50000] of integer;
    arrT2:array[1..10000000] of integer;
    arrN2:array[1..50000] of integer;
    N,T,k,k2,x,y,i,a,sum1,sum2,mem,D,count,min: integer;
    z: string;
    f1,f2:text;
    begin
    assign(f1,'input.txt');
    reset(f1);
    read(f1,N); //всего типов задач
    read(f1,T); //всего времени
    for i:=1 to N do
    begin
    read(f1,x,y); // вр на 1 задачу и сколько всего таких задач
    read(f1,z); //идентификатор предмета
    if z=' P' then 
      begin 
      if T>=x*y then
      begin
      sum1:=sum1+y;
      T:=T-x*y;
      end
      else 
       while T-x>=0 do
       begin
        T:=T-x;
        inc(sum1);
       end;
    end; end;
close(f1);
    if T>0 then
    begin
    assign(f1,'input.txt');
    reset(f1);
    read(f1,N); //всего типов задач
    read(f1,D);
    for i:=1 to N do
    begin
    read(f1,x); // вр на 1 задачу 
    read(f1,y); //сколько всего таких задач
    read(f1,z); //идентификатор предмета
    if z=' M' then 
    begin inc(count); arrT[i]:=x;
    arrN[i]:=y;
    end; end; end; close(f1); 
    writeln(arrT);
    writeln(arrN);
    min:=maxInt;
    for i:=1 to count do begin
        writeln('внешний цикл ',i);
        for k:=1 to N do
        begin if arrT[k]<>0 then begin
                            arrT2[i]:=arrT[k]; arrN2[i]:=arrN[k];
                            writeln(arrT2);
                            if (i=1) then break;
                            if arrT[k]<arrT2[i-1] then 
                               begin 
                               for a:=1 to count do
                               begin writeln('цикл а шаг ',a);
                               if arrT[k]<arrT2[a] then begin
                               mem:=arrT2[a]; arrT2[a]:=arrT[k]; arrT2[a+1]:=mem;
                               mem:=arrN2[a]; arrN2[a]:=arrN[k]; arrN2[a+1]:=mem;
                               writeln(arrT2); break; end;
                               end;
        end;
    end; end; end;
    writeln;
    writeln(arrT2);
    writeln(arrN2);
   { writeln(arrT);
    writeln(arrN);
    assign(f2,'output.txt');
    rewrite(f2);
    writeln(f2,sum1, ' ',sum2);
    close(f2);
    writeln(sum1, ' ',sum2);}
    end.
