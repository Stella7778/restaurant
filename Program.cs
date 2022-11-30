using System;

Owner owner = new Owner(1000000);
Server s1 = new Server(50000);
Cook ck = new Cook(50000);

Menu m1 = new Menu("정식", 5000);
Menu m2 = new Menu("특식", 7000);
Menu m3 = new Menu("콜라", 2000);
Menu m4 = new Menu("사이다", 2000);



Customer c1 = new Customer();

c1.order(m1);
c1.order(m4);
c1.passOrder(s1);

ck.giveFood(s1);
s1.serving(c1);
c1.pay(s1);



Customer c2 = new Customer();
Customer c3 = new Customer();

c2.order(m2);
c2.order(m3);
c2.passOrder(s1);

ck.giveFood(s1);
s1.serving(c2);
c2.pay(s1);

c3.order(m2);
c3.order(m3);
c3.passOrder(s1);

ck.giveFood(s1);
s1.serving(c3);
c3.pay(s1);


s1.giveMoney(owner);
owner.giveSalary(s1.salary);
owner.giveSalary(ck.salary);


System.Console.WriteLine(owner.totalMoney);