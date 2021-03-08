print 'Hello World!'

declare @myVariable int 
set @myVariable = 6
print @myVariable

declare @var1 int, @var2 int
set @var1 = 3
set @var2 = 5



print 'Variable 1 = ' + convert(varchar(5),@var1) + char(13) + 'Variable 2 = '+ convert(varchar(5),@var2)

print char(9) + 'I have ' +char(13)+ convert(varchar(50),@var1) + ' dollars...'