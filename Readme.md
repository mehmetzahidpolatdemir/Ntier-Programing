# NTier Mimari

## NTier mimari projeleri farklý katmanlara bölüp, her bir katmanýn kendi sorumluluðunu belirlenmesidir. Klasik Ntier modelinde 3 adet katman bulunmaktadýr. Bunlar;
- DataAccess Layer (Veriye ulaþým katmaný)
- Business Logic Layer (Ýþ/Servis katmaný)
- Presentation Layer (Sunum/Arayüz katmaný)

### Ntier isimli solution içerisine ilk etapta Projelerden Class Library (.Net Framework) seçilerek ismi DataAccess olarak tanýmlandý ve içerisinde;
	- Model isminde bir klasör oluþturulup Northwind veritabaný'nýn DbFirst oalrak yansýmasý alýndý.

### BLL isminde Class Library (.Net Framework) oluþturuldu içerisinde;
	- DataAccess katmanýnda yer alan Entity(varlýk)'lerin iþlemleri için (CRUD) sýrasýyla servisler oluþturuldu. 
	- CategoryService, kategori ile ilgili yapýlacak olan bütün iþlemleri barýndýrmaktadýr.
### Presentation isminde bir klasör oluþturuldu ve içerisine CA_Console isminde bir console uygulamasý eklendi. bu katmanýn görevi; DataAccess içerisinde bulunan entity'lere ulaþmak ve BLL katmaný içerisinde tanýmlý olan servisler ile verileri listelemek, eklemek, silmek ve güncellemek. 

### Katmanlarýn birbirleriyle iletiþim kurabilmeleri için referans (reference)'larýna sýrasýyla;
	- DataAccess => BLL
	- DataAccess=>BLL => CA_Console
	eklendi.

