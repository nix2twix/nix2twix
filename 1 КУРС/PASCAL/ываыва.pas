var x,y,xa,xb,ya,yb,y1,c,ext,cout,sr:real;
    i,a,b,k:integer;
    str:string;
    f:text;
    begin
       
       {assign(f,'input.txt');
       reset(f);}
       readln(a,b); //-3,2
       //close(f);
       sr:=(a+b)/2;
       xa:=a;
       ya:=xa*xa+1.8;
       xb:=b;
       yb:=yb*yb+1.8;
       x:=a;
       y1:=x*x+1.8;
       cout:=a+0.001;
       while cout<b do
          begin 
            inc(k);
            x:=cout;
            y:=x*x+1.8;
            if y1-y<0.000000001 then begin writeln('(',x,',',y,')','  ',k); break end
            else begin y1:=y; cout:=cout+0.001; end;
          end;
      // assign(f,'output.txt');
     //  rewrite(f)
      // close(f);
    end.