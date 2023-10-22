//Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
program zadacha1;
var r,a,s1,s2:real;
begin
  write('Введите радиус круга (r>0) ');
  readln(r);
  write('Введите сторону квадрата (a>0) ');
  readln(a);
  s1:=pi*sqr(r); //s круга
  s2:=sqr(a);
  if s1=s2 then
    write('Площади фигур равны');
  if s1>s2 then
    write('Плошадь круга больше');
  if s1<s2 then
    write ('Плошадь квадрата больше');
 end.
