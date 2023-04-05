# CheckNamesys
## ความเป็นมา เเละ วัตถุุประสงค์
ความเป็นมา :อยากทำระบบเก็บจำนวนนักศึกษา 
วัตถุประสงค์ :เช็คคนมา  คนลา คนขาด ในวันที่นั้นๆ เเละสามารถเก็บไว้ดูเช็คย้อนหลังได้

##ผู้เขียน
Name : จันทิมา พรมวัง
ID  : 6534560280-1
E-mail :junthima.p@kkumail.com




## ClassDiagram

```mermaid
Form1 --|> information
<<interface>> Form1
information --|> From1

note for information "Add"

Classinformation --|> Form1
Classinformation --|> information
Classinformation : str No
Classinformation :str Nameclass
Classinformation :int marean
Classinformation :int leave

Resource : DataGrids()
Resource : Add()

```
   
