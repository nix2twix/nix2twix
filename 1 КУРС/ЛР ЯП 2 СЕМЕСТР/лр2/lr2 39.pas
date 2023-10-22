{Даны два файла, в каждом из которых записаны неубывающие 
последовательности целых чисел, первый из N элементов, второй из M элементов. 
Образовать из них новую последовательность чисел так, чтобы она тоже была 
неубывающей. Вывести ее в новый файл и на экран.}// не исп sort

var x,y,i,n,m:integer;
    f1,f2,f3:text;
    begin

      assign(f1,'input39.1.txt');
      reset(f1);
      assign(f2,'input39.2.txt');
      reset(f2);
      assign(f3,'output39.txt');
      rewrite(f3);
      read(f1,n); read(f2,m);
      read(f1,x); read(f2,y);
        
          for i:=1 to m+n do begin
          if x>y then begin 
                      write(y,' '); write(f3,y,' ');
                      if not eof(f2) then read(f2,y)
                      else break;
                      end
                      
          else begin if y>x then begin 
                      write(x,' '); write(f3,x,' '); 
                       if not eof(f1) then read(f1,x)
                       else break;
                      end
                     
                     else begin //если равны
                     write(x,' '); write(y,' '); write(f3,x,' '); write(f3,y,' ');
                     if (eof(f1)) or (eof(f2)) then begin 
                          if eof(f1) then begin read(f2,y); break; end //если закончилось на 1 файле, считывает из второго
                                     else begin read(f1,x); break; end; end //наоборот
                    else begin read(f1,x); read(f2,y); end;             
                      end;
                end;
          end;
          //конец цикла
          
          if eof(f1) then
                     begin 
                           if x<y then begin while not eof(f2) do begin //если файл закончился на числе меньшем, чем в другом файле
                                        write(y,' '); write(f3,y,' ');  
                                        read(f2,y);   end; 
                                        write(y,' '); write(f3,y,' ');  end
                           else begin write(x,' '); //наоборот все ок
                           while not eof(f2) do begin  
                                        read(f2,y);   
                                        write(y,' '); write(f3,y,' ');
                                                end;
                                        
                           end;
                     end
                     
          else if eof(f2) then 
                     begin 
                           if y<x then begin 
                               while not eof(f1) do begin
                               write(x,' '); write(f3,x,' ');
                               read(f1,x); end; 
                               write(x,' '); write(f3, x,' '); 
                                           end
                            else begin write(y,' '); write(f3, y,' '); 
                              while not eof(f1) do begin  
                                        read(f1,x);   
                                        write(x,' '); write(f3, x,' '); 
                                                end; end;
                           
                     end;
          

      close(f1);
      close(f2);
      close(f3);

    end.