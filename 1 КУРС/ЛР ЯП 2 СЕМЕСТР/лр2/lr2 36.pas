var n,k,i,cout,t: integer;
    p:array of (string,string,string,integer);
    str,s1,s2,s3:string;
    cort: (string,string,string,integer);
    f: text;
    begin
      
      assign(f,'input36.txt');
      reset(f);
      readln(f,n); //пассажиров
      readln(f,k); //ячеек
      setlength(p,n);
      cout:=1;
      for i:=0 to n-1 do
          begin 
                  readln(f,str);  
                  cout:=1;
                  s1:=readwordfromstring(str,cout);
                  s2:=readwordfromstring(str,cout);
                  s3:=readwordfromstring(str,cout);
            cort:=(s1,s2,s3,t);
            p[i]:=cort;
            end;
      close(f);
      
      assign(f,'output36.txt');
      rewrite(f);
 //присваивание первого номера
     cout:=1;
     t:=cout;
     cort:=(p[0].Item1,p[0].Item2,p[0].Item3,t); 
     p[0]:=cort;
     writeln(p[0].Item1,' получил номер ячейки ',t);
     
     //цикл сравнивания
     
     for i:=1 to n-1 do begin
     if i<=k then begin
        
          if  p[i-1].Item3 > p[i].Item2 then
               begin 
               inc(cout);
               t:=cout;
               cort:=(p[i].Item1,p[i].Item2,p[i].Item3,t); 
               p[i]:=cort;
           writeln(p[i].Item1,' получил номер ячейки ',t);
           writeln(f,p[i].Item1,' получил номер ячейки ',t);
               end
           
          else
              begin
          writeln('--> ячейка номер ',cout, ' освободилась');
          writeln(f,'ячейка номер ',cout, ' освободилась');
                 t:=cout;
                 cort:=(p[i].Item1,p[i].Item2,p[i].Item3,t); 
                 p[i]:=cort; 
          writeln(p[i].Item1,' получил номер ячейки ',t);
          writeln(f,p[i].Item1,' получил номер ячейки ',t);
               end;
      end
      else 
           begin
           t:=0;
           cort:=(p[i].Item1,p[i].Item2,p[i].Item3,t); 
           p[i]:=cort; 
           end
      end;
      close(f);
    end.