{Представить в виде обыкновенной несократимой дроби сумму 
заданных А (А<=1000) обыкновенных дробей.  Входные данные: целое число А, 
затем А числителей и знаменателей дробей-слагаемых. Каждый числитель – 
целое число, не превосходящее по модулю 1000, знаменатель – натуральное 
число, не большее 1000. Выходные данные: числитель и знаменатель суммы}

var a,x,y,i,x1,y1,sum,znam,p,q,r:integer;
    begin
      readln(a);
      write('числитель:'); readln(x);
      write('знаменатель:'); readln(y);
      x1:=x; y1:=y;
      sum:=x1; znam:=y1;
      for i:=1 to a-1 do
          begin 
          write('числитель:'); readln(x);
          write('знаменатель:'); readln(y);
          if y=y1 then 
              begin 
              sum:=sum+x;
              end
          else begin 
          sum:=sum*y+x*y1;
          znam:=znam*y;
          x1:=x;
          y1:=znam;
          end;
          end;
      writeln(sum,'/',znam);
      p:=sum;
      q:=znam;
      repeat
        r:=p mod q;
        p:=q; q:=r;
      until r=0;
      writeln(sum div p,'/',znam div p);
    end.