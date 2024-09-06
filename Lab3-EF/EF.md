# Entity Framework

---

Imiona i nazwiska autorów: **Tomasz Furgała**

## Część I

Udało się zrealizować wszystko zgodnie z tym co było w instrukcji.

#### Widok projektu
![cz1/projekt](imgs/cz1/projekt.png)

#### DbContext
![cz1/DbContext](imgs/cz1/DbContext.png)

#### Product
![cz1/Product](imgs/cz1/Product.png)

#### Program.cs
![cz1/Program](imgs/cz1/Program.png)

#### Wykonanie Program.cs
![cz1/Program2](imgs/cz1/Program2.png)

#### Wyświetlenie bazy przy pomocy sqlite3
![cz1/sqllite3](imgs/cz1/sqlite3.png)

## Część II

### a. Relacja Suppliers -> Products

Stworzenie nowej klasy Supplier

![cz2/supplier](imgs/cz2/a-supplier.png)

Dodanie zbioru Suppliers do ProdContext

![cz2/prodcontext](imgs/cz2/a-prodContext.png)

Dodanie pola Supplier do klasy Product

![cz2/products](imgs/cz2/a-product.png)

Stworzenie nowego dostawcy - Program.cs

![cz2/programcs](imgs/cz2/a-programcs1.png)

udało się dodać nowego dostawcę

![cz2/sqlite](imgs/cz2/a-sqlite1.png)

Dodanie do istniejącego już produktu stworzonego przed chwilą dostawcę:

![cz2/programcs](imgs/cz2/a-programcs2.png)

I teraz produkt z ProduktID == 1 ma przypisanego dostawce. Dostawca jest przypisany przez SupplierID.

![cz2/sqlite](imgs/cz2/a-sqlite2.png)

![cz2/programcs](imgs/cz2/a-programcs3.png)

![cz2/sqlite](imgs/cz2/a-sqlite3.png)

Diagram wygląda następująco:

![cz2/diagram](imgs/cz2/a-diagram.png)

### b. Odwrócenie relacji

Dodanie listy do przechowywania produktów w supplierze

![cz2/supplier](imgs/cz2/b-supplier.png)

Klasa product:

![cz2/products](imgs/cz2/b-product.png)

Program.cs - stworzenie nowych produktów i dodanie ich do listy nowego dostawcy

![cz2/programcs](imgs/cz2/b-programcs.png)

![cz2/sqlite](imgs/cz2/b-sqlite1.png)

![cz2/sqlite](imgs/cz2/b-sqlite2.png)

Udało się dodać zarówno produkty jak i dostawce.

Jak możemy zauważyć, pomimo zapisania relacji w Entity Frameworku w odwrotny sposób, w bazie danych relacja wciąż wygląda tak samo.Widzimy więc, że Entity Framework „pod spodem” dokonał optymalizacji, dzięki czemu nie musimy trzymać w tabeli `Suppliers` powielonych danych dostawców, różniących się jedynie `SupplierID` oraz kluczem obcym, wskazującym na produkt z tabeli `Products`.

![cz2/diagram](imgs/cz2/b-diagram.png)

### c. Relacja dwustronna

Połączenie dwóch poprzednich podejść. Klasa Suppliers posiada pole z listą produktów, natomiast Products posida pole przechowujące obiekt dostawcy (w rzeczywistości SupplierID).

![cz2/supplier](imgs/cz2/c-supplier.png)

![cz2/products](imgs/cz2/c-product.png)

**Program.cs - stworzenie nowych produktów i nowego dostawce, i połacenie ze sobą obiektów**

Stworzyłem kilka produktów i nowego dostawce. Dodałem produkty do listy produktów należącej do utworzonego dostawcy i na koniec dodałem do każdego z produktów dostawce.

![cz2/programcs](imgs/cz2/c-programcs.png)

![cz2/sqlite](imgs/cz2/c-sqlite1.png)

![cz2/sqlite](imgs/cz2/c-sqlite2.png)

Ponownie obserwujemy taki sam diagram. Możemy więc dojść do wniosku, że Entity Framework pozwala nam na stworzenie relacji dwukierunkowej (lub w odwrotnym kierunku do tego, w którym relacja zostanie zapisana, jak widzieliśmy w poprzednim przykładzie), po to, aby łatwiej móc manipulować powiązanymi ze sobą obiektami.

![cz2/diagram](imgs/cz2/c-diagram.png)

### d. Relacja wiele do wielu

Klasy `Products` i `Invoices` będą zawierały listy odpowiednio faktur i produktów. Do zamodelowania takiej relacji będziemy potrzebowali tebeli pomocniczej `InvoicItems`.

**Klasa Product**

![cz2/products](imgs/cz2/d-product.png)

**Klasa Invoice**

![cz2/invoice](imgs/cz2/d-invoice.png)

**Klasa InvoiceItem - Klasa pomocnicza, reprezentująca pozycje faktury**

![cz2/invoiceitem](imgs/cz2/d-invoiceitem.png)

**prodContext**

![cz2/prodContext](imgs/cz2/d-prodContext.png)

**Program.cs**

Stworzyłem nowe produkty, które później dodaje do słownika gdzie przechowuje ilość zakupionych produktów. Następnie dodaje produkty do listy w `InvoiceItem`. Tworzę faktury zawierające obiekty `InvoiceItem`.

![cz2/programcs](imgs/cz2/d-programcs.png)

![cz2/sqlite](imgs/cz2/d-sqlite1.png)

![cz2/sqlite](imgs/cz2/d-sqlite2.png)

![cz2/sqlite](imgs/cz2/d-sqlite3.png)

**Diagram**

![cz2/diagram](imgs/cz2/d-diagram.png)

### e. Table-Per-Hierarchy

**Klasa Company**

![cz2/commpany](imgs/cz2/e-company.png)

**Supplier**

![cz2/supplier](imgs/cz2/e-supplier.png)

**Customer**

![cz2/customer](imgs/cz2/e-customer.png)

**CompContext**

![cz2/context](imgs/cz2/e-context.png)

**Program.cs - dodanie klientów i dostawców**

![cz2/programcs](imgs/cz2/e-programcs.png)

**Wynik**

Otrzymujemy tylko 1 tabele zawierającą zarówno pola zdefiniowane w klasie Customers jak i Suppliers. 

![cz2/diagram](imgs/cz2/e-diagram.png)

### f. Table-Per-Type

**Klasa Company**

![cz2/commpany](imgs/cz2/f-company.png)

**Supplier**

![cz2/supplier](imgs/cz2/f-supplier.png)

**Customer**
 
![cz2/customer](imgs/cz2/f-customer.png)

**CompContext**

![cz2/context](imgs/cz2/f-context.png)

**Program.cs - dodanie klientów i dostawców**

![cz2/programcs](imgs/cz2/e-programcs.png)

**Diagram**

Otrzymujemy tylko 3 tabele. Tabele `Customers` i `Suppliers` są połączone z `Companies` za pomocą po `CompanyID`. 

![cz2/diagram](imgs/cz2/f-diagram.png)

**Companies**

![cz2/companies](imgs/cz2/f-company2.png)

**Suppliers**

![cz2/supplier](imgs/cz2/f-supplier2.png)

**Customers**

![cz2/customer](imgs/cz2/f-customer2.png)

### g. Porównanie

#### Table-Per-Hierarchy

Tworzona jest jedna tabela, która zawiera wspólne dla klas dziedziczących dane oraz dane, charakteryzujące każdą z klas dziedziczących z osobna. W przypadku, gdy klasa dziedzicząca posiada atrybut, którego nie ma w klasie, z której dziedziczy, dodawana jest osobna kolumna, w której dla pozostałych klas wpisane są wartości null, a dla tej klasy, odpowiednie wartości tego parametru.

**Zalety**

* Prostsze i bardziej wydajne zapytania: TPH używa jednej tabeli dla wszystkich klas dziedziczących, co oznacza, że zapytania są prostsze i łatwiejsze do wykonania (nie wymagają klauzuli join).
* Mniejsza liczba tabel: TPH wymaga tylko jednej tabeli, co prowadzi do mniejszej liczby tabel w bazie danych.
* Łatwiejsze mapowanie: Mniej konfiguracji jest wymagane, ponieważ wszystkie klasy dziedziczące mapowane są do jednej tabeli.

**Wady**

* W przypadku wielu klas dziedziczących z tej samej klasy, jedna tabela nie jest dobrym rozwiązaniem, ponieważ będzie zawierała bardzo dużo wartości null (marnowanie miejsca),
* Grupowanie danych, w przypadku wielu klas dziedziczących, zmniejsza przejrzystość schematu bazy danych.

#### Table-Per-Type

Tworzone jest kilka tabel (osobne tabele dla każdej z klas, zarówno tej, z której dziedziczą klasy, jak i klas dziedziczących). Tabele klas dziedziczących są łączone z tabelą klasy, z której dziedziczą. przy pomocy relacji 1 do 1.

**Zalety**

* Normalizacja danych: Każda klasa dziedzicząca mapowana jest do osobnej tabeli, co prowadzi do bardziej znormalizowanej struktury danych.
* Bardziej zrozumiały digram bazy danych, gdzie widzimy jak klasy dziedziczą po innych klasach.
* Takie podejście nie wymaga trzymania pustych wartości w tabelach (null), dzięki czemu zapisywane są tylko wartości.

**Wady**

* Konieczne jest wykonywanie wielu operacji join (łączenie tabel klas dziedziczących z tabelą klasy nadrzędnej – tej, z której klasy dziedziczą).

Osobiście bedziej podobała mi się strategia Table-Per-Type ze względu na bardziej zrozumiałą i naturalną strukture