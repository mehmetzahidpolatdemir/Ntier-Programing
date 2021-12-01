# NTier Mimari

## NTier mimari projeleri farkl� katmanlara b�l�p, her bir katman�n kendi sorumlulu�unu belirlenmesidir. Klasik Ntier modelinde 3 adet katman bulunmaktad�r. Bunlar;
- DataAccess Layer (Veriye ula��m katman�)
- Business Logic Layer (��/Servis katman�)
- Presentation Layer (Sunum/Aray�z katman�)

### Ntier isimli solution i�erisine ilk etapta Projelerden Class Library (.Net Framework) se�ilerek ismi DataAccess olarak tan�mland� ve i�erisinde;
	- Model isminde bir klas�r olu�turulup Northwind veritaban�'n�n DbFirst oalrak yans�mas� al�nd�.

### BLL isminde Class Library (.Net Framework) olu�turuldu i�erisinde;
	- DataAccess katman�nda yer alan Entity(varl�k)'lerin i�lemleri i�in (CRUD) s�ras�yla servisler olu�turuldu. 
	- CategoryService, kategori ile ilgili yap�lacak olan b�t�n i�lemleri bar�nd�rmaktad�r.
### Presentation isminde bir klas�r olu�turuldu ve i�erisine CA_Console isminde bir console uygulamas� eklendi. bu katman�n g�revi; DataAccess i�erisinde bulunan entity'lere ula�mak ve BLL katman� i�erisinde tan�ml� olan servisler ile verileri listelemek, eklemek, silmek ve g�ncellemek. 

### Katmanlar�n birbirleriyle ileti�im kurabilmeleri i�in referans (reference)'lar�na s�ras�yla;
	- DataAccess => BLL
	- DataAccess=>BLL => CA_Console
	eklendi.

