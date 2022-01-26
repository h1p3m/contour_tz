
  select *from employees emp1 where SALARY > (select SALARY from employees where EMPLOYEE_ID=emp1.CHIEF_ID)

