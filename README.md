# CheckNamesys
## ความเป็นมา เเละ วัตถุุประสงค์
ความเป็นมา :อยากทำระบบเก็บจำนวนนักศึกษา 
วัตถุประสงค์ :เช็คคนมา  คนลา คนขาด ในวันที่นั้นๆ เเละสามารถเก็บไว้ดูเช็คย้อนหลังได้

##ผู้เขียน
Name : จันทิมา พรมวัง
ID  : 6534560280-1
E-mail :junthima.p@kkumail.com

# classDiagram 
---
title: Animal example
---
classDiagram
    note "From Duck till Zebra"
    Animal <|-- Duck
    note for Duck "can fly\ncan swim\ncan dive\ncan help in debugging"
    Animal <|-- Fish
    Animal <|-- Zebra
    Animal : +int age
    Animal : +String gender
    Animal: +isMammal()
    Animal: +mate()
    class Duck{
        +String beakColor
        +swim()
        +quack()
    }
    class Fish{
        -int sizeInFeet
        -canEat()
    }
    class Zebra{
        +bool is_wild
        +run()
    }

   
