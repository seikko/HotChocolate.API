 Merhaba
 Bu repository'de sizlere Hot Chocolate Graphql sunucusunu basitçe oluşturmayı anlatmaya çalışacağım.
 
 Hot Chocolate Graphql sunucusunu kurmak için

1-)Boş bir ASP.NET Core projesi oluşturalım
![Nuget](https://user-images.githubusercontent.com/72353208/197355707-498c857d-a8cd-4393-b407-231b23efc413.png)
Ben .net6 ile oluşturdum.

2-) Paketlerin Kurulması
![HotCohoc](https://user-images.githubusercontent.com/72353208/197355754-638516d8-f2c6-436a-a42b-0f450eb3d1e1.png)
İsterseniz terminal'den de kurabilirsiniz.
dotnet add  package HotChocolate.AspNetCore

3-) Model Oluşturmak Basit Bir şekilde Product Modeli oluşturdum
![Models](https://user-images.githubusercontent.com/72353208/197355836-df490e00-5c04-4d5f-bb60-c232b1318b4c.PNG)

4-) Graphql sorguları için Query classı oluşturma 
![query](https://user-images.githubusercontent.com/72353208/197355872-57a781ec-5ec5-445a-ab00-dbf13eb29b80.PNG)

5-) Startup yapılandırması
![StartUp](https://user-images.githubusercontent.com/72353208/197355876-ba9bbc37-5f9c-4212-8073-956099ee805a.PNG)

6-) Projeyi çalıştırmak 
Banana Cake pop'umuzu açmak için tarayıcıdan gelen url'e /grapqhl yazmamız gerekmektedir.
![gralqlweb1](https://user-images.githubusercontent.com/72353208/197355930-a54acb39-ef53-45b8-bf5e-9081dbf3eded.PNG)
 

7-)  Banana Cake Pop içersinde oluşan Schemaları görmek
![schema](https://user-images.githubusercontent.com/72353208/197356051-becb02ac-63ba-4603-a52c-52e46fbb7645.PNG)

8-) Query
![webquery](https://user-images.githubusercontent.com/72353208/197356057-ab1c1291-28fa-4b3b-9510-2810260a2ffa.PNG)

Yukarıdaki gibi de Queryler yazarak run tuşuna basarak istediğimiz verileri çekebiliriz.
