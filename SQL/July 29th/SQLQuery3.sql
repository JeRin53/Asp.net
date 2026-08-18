select * from t1
select * from t2
select * from t3

--select t1.name,t1.age,t2.address , t2.phone from t1 join t2 on t1.id=t2.id

--select x.name,x.age,y.address , y.phone from t1 as x join t2 as y on x.id=y.id

--select t1.name,t1.age,t2.address , t2.phone,t3.email,t3.pincode from t1 join t2 on t1.id=t2.id join t3 on t1.name=t3.name

--select x.name,x.age,y.address , y.phone,z.email from t1 as x join t2 as y on x.id=y.id join t3 as z on x.name=z.name

select t1.name,t1.age,t2.address , t2.phone from t1 left join t2 on t2.id=t1.id

select t1.name,t1.age,t2.address , t2.phone from t1 right join t2 on t2.id=t1.id

alter table t1 add address varchar(100)
alter table t1 drop column address

