##### 应用简介
根据类属性的Description特性更新PostgresSQL数据库表对应字段的描述
##### 技术点
SqlSugar 
PostgresSQL 
Reflection

##### 实现原理
利用反射获取类的属性的Description特性，然后拼接DDL Sql语句更新表