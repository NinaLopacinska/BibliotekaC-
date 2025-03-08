Biblioteka 

Forma desktopowa 

Program będzie realizowany w formie desktopowej, ponieważ jest przeznaczeniem są urządzenia znajdujące się w bibliotekach. Użytkownicy będą mogli korzystać z programu jedynie na terenie biblioteki na przeznaczanych do tego urządzeniach. Biblioteka nie będzie posiadała strony internetowej, osoby która chce uzyskać informacje dotyczące zasobów musi pojawić się tam osobiście i poprosić pracownika o pomoc lub samodzielnie skorzystać z panelu dla czytelników.  

 

Przeznaczenie aplikacji 

Funkcjonalność bez zalogowania 

Podstawowym zadaniem aplikacji będzie możliwość wyszukania dowolnego zasobu. Wyszukiwać można po: tytule, autorze, typie produktu (książka, film itp.), ocenie, kategorii, roku wydania oraz wydawnictwie.  

Poza możliwością wyszukania pozycji dostępne będą dwie strony ze statystykami.  Pierwsza dotycząca najczęściej wybieranych pozycji w danym miesiącu – „Ulubieńcy miesiąca”. Druga strona dotycząca ulubionych pozycji użytkowników – „Ulubieńcy czytelników”. Dostępne są na mniej najchętniej wypożyczane pozycje na podstawie wszystkich dostępnych danych o wypożyczeniach oraz listę najlepiej ocenianych pozycji z możliwością zaznaczenia jaki typ produktu interesuję użytkownika. 

Na stronie startowej dostępna jest również zakładka „Regulamin”, która zawiera regulamin obowiązujący w bibliotece. Znajduje się tan również cennik obowiązujący w przypadku zalegania z oddaniem zasobu. Każdy użytkownik powinien się zapoznać z tą stroną zanim rozpocznie korzystanie z biblioteki. 

Ze strony startowej aplikacji użytkownik może wybrać przycisk „Zaloguj” jeśli posiada już konto lub jeśli nie posiada wybiera opcję „Zarejestruj” dla osób, które chcą mieć możliwość korzystania z zasobów biblioteki .  

Na stronie startowej jest również przycisk „X”, który kończy działanie programu. 

Rejestracja użytkownika 

Użytkownik podczas zakładania konta podaje swoje dane: 

•	Imię  

•	Nazwisko 

•	Login (unikalny, min 5 max 30 znaków) 

•	Hasło (min.5 znaków w tym co najmniej jedna cyfra) 

•	Kod pocztowy (można podać tylko z terenu Łodzi od 90-001do 94-413) 

•	Ulica  

•	Nr posesji  

•	Nr lokalu (opcjonalnie) 

•	Nr pesel (11 cyfr) 

•	Email (unikalny, musi zawierać „.” oraz „@”) 

•	Nr telefonu (9 cyfr) 

Data urodzenia (na jej podstawie program ocenia wiek użytkownika, jeśli ma poniżej 13 lat wymagane są dodatkowe pola opiekuna ) 

Imię opiekuna  

Nazwisko opiekuna  

Numer telefonu opiekuna (9 cyfr) 

Email opiekuna (musi zawierać „.” oraz „@”) 

Logowanie użytkownika 

Logowanie użytkownika odbywa się poprzez podanie loginu i hasła. Program sprawdza jaki „IdOsoby” jest przypisany do tego użytkownika i w zależności od tego przenosi go na odpowiednią stronę (1- MainUzytkownikForm.cs, 2- MainPracownikForm.cs, 3- MainAdminstratorForm.cs). 

Rodzaje użytkowników  

Administrator  

Ma przycisk „Wyloguj”, który przenosi użytkownika do strony startowej.   

Edycja zbiorów 

Administrator może dodawać istniejącą już pozycje lub ją usuwać z bazy danych. W przypadku gdy po usunięciu pozycji jej ilość będzie wynosiła 0 otrzymuje komunikat.  

Dodawanie pracowników 

Administrator odpowiada za personel biblioteki. Ma miał możliwość dodanie nowego pracownika, w tym celu podawane są takie same dane jak w przypadku rejestracji nowego użytkownika.  

Dodawanie nowego produktu 

Administrator ma możliwość dodania nowego produktu, w tym celu podaje następujące informacje o nim: 

Tytuł 

Autor 

Rok wydania (min 1500 max rok obecny) 

Nr. Katalogowy (unikalny) 

Ilość (większa od 0) 

Kategoria (wybiera z listy) 

Typ (musi istnieć w tabeli Cennik, jeśli go tam nie ma Administrator najpierw musi go stworzyć w cenniku i dopiero wtedy może dodać produkt o takim typie) 

Ocena (między 1,00 a 10,00; jeśli istnieje już w bazie danych pozycja o takim tytule i typie należy nadać jej taką samą ocenę, ma to zapewnić spójność podczas tworzenia statystyk) 

Wydawnictwo 

Raporty  

Program może generować raporty w Excelu dotyczące min. Zasobów, klientów, pracowników itp. Przed jego wygenerowaniem należy wybrać zakres czasowy od kiedy do kiedy raport ma obejmować. Pomoże to Administratorowi zaplanować kolejne zamówienia tak aby w były chętnie wybierane.  

Usuń pracownika 

Administrator może usunąć pracownika, który nie pracuje już w bibliotece. Wtedy jego Stan zmienia się na Nieaktywny w bazie danych. 

Edycja cennika 

Administrator może edytować ceny w tabeli Cennik, zarówno cenę obowiązującą za dzień lub tą za zgubienie/ zniszczenie zasobu. Może również dodać nowy produkt (typ), jeśli biblioteka zdecyduje się na rozszerzenie swojej oferty. Należy wtedy podać jego nazwę, karę za dzień w przypadku zwlekanie ze zwrotem oraz cenę za zgubienie/ zniszczenie tego zasobu.  

Pracownik biblioteki 

Pracownik po zalogowaniu ma dostęp do wyszukiwarki z dostępnymi zasobami biblioteki oraz wyszukiwarki, aby w szyli i łatwy sposób mógł znaleźć produkt. Może wybrać po czym chce wyszukać zasób, do wyboru jest: tytuł, autor, rok wydania, nr. Katalogowy, typ, ocena, ilość, kategoria lub wydawnictwo. Ma również przycisk „Wyloguj”, który przenosi użytkownika do strony startowej.   

Wypożyczanie pozycji  

Pracownik odpowiada za wypożyczanie produktów użytkownikom. Wybiera z listy zasobów biblioteki wybiera produkt oraz z listy użytkowników wybiera tego, który chce dokonać wypożyczenia. Następnie wypożyczenie jest dodawane do historii wypożyczeń z automatycznym czasem wypożyczenia 30 dni oraz statusem „Nie Zwrócono”. Program sprawdza czy wybrany użytkownik nie posiada na swoim koncie żadnej kary, jeśli zalega z jakimś produktem wyświetla się komunikat i wypożyczenie takiego użytkownikowi jest niemożliwe.  

Zwrot i wydłużenie terminu zwrotu 

Produkt należy zwrócić maksymalnie do dnia zwrotu, wtedy pracownik odnotowuj to w systemie i użytkownik może korzystać swobodnie z innych zasobów biblioteki. W sytuacji, w której użytkownik chce przedłużyć termin oddania produktu, należy się zgłosić maksymalnie do dnia zwrotu i pracownik wydłuża termin zwrotu o kolejne 30 dni.  

Przyjmowanie opłat  

Pracownik jest odpowiedzialny za przyjmowanie zwróconych produktów. Jeśli użytkownik zgłosi się do pracownika po dacie zwrotu zostanie naliczona mu kara. Kary są naliczane zgodnie z cennikiem dostępnym dla wszystkich w zakładce ‘Regulamin’. Jeśli produkt będzie oddany w dobrym stanie to należy zapłacić kare za ilość dni, w których się zwlekało z oddaniem pomnożone przez cenne z dzień dla danego produktu. Jeśli jednak użytkownik zgubi lub zniszczy produkt należy ponieść opłatę na zakup nowej pozycji przez bibliotekę. Wszystkie niezbędne informacje pracownik ma w zakładce ‘Przyjmij opłatę’, o ilości dni, wysokości kary i dane o użytkowniku i produkcie, z którym zalega. Do jego kompetencji należy tylko decyzja czy przyjmuję produkt w dobrym stanie czy karę należy zmienić na odkupienie zasobu.   

 

Usuń użytkownika 

Pracownik może usunąć użytkownika, polega to na zmienia jego Stanu na Nieaktywny w bazie danych. Może również przejrzeć wszystkich aktywnych użytkowników biblioteki. Do wyświetlanych informacji należą: imię, nazwisko, telefon, login, pesel, email, kod pocztowy, ulica, nr posesji i nr lokalu. Jeśli pracownik potrzebuje szybko zaleźć użytkownika może skorzystać z wyszukiwarki i podać: imię, nazwisko, login, numer telefonu, email lub pesel.  

Wypożyczenia użytkowników 

W tej zakładce pracownik widzi całą historię wypożyczeń dla użytkowników czyli, datę wypożyczenia i zwrotu, login, tytuł i typ pozycji oraz status (Zwrócono, Nie zwrócono lub KARA). Pracownik może też skorzystać z wyszukiwarki i wyszukać po loginie użytkownika, tytule pozycji lub statusie.  

Zmiana hasła użytkownika 

W sytuacji gdy użytkownik zapomni hasła do swojego konta zgłasza się do pracownika, który generuje mu tymczasowe hasło. Wtedy użytkownik może zalogować się na swoje konto poprzez swój login i hasło tymczasowe, a następnie zmienić samodzielnie hasło w zakładce ‘Edytuj konto’.  

Statystyki  

Pracownik ma dostęp do statystyk dotyczących użytkowników i zaborów.  Zawierają:  

Ilość użytkowników 

Ilość dokonanych wypożyczeń 

Informacje o użytkowniku, który najczęściej wypożycza w postaci jego imienia i nazwiska oraz liczby dokonanych przez niego wypożyczeń  

Najpopularniejsze pozycje (5 najczęściej wypożyczanych) z ich tytułem, ilością wszystkich wypożyczeń i średnią oceną tego produktu 

Najpopularniejsze gatunki oraz liczę wypożyczonych produktów z tego gatunku (5) 

Edycja konta pracownika 

Pracownik może zmienić swoje dane, które podawał podczas rejestracji, wszystkie poza loginem. W przypadku chęci zmiany hasła będzie musiał podać najpierw obecne hasło a następnie nowe hasło. Wszystkie zmienione dane mają taką walidacje jak podczas rejestracji. 

Użytkownik  

Użytkownik po zalogowaniu ma dostęp do wyszukiwarki z takimi danymi jak na stronie startowej. Ma również przycisk „Wyloguj”, który przenosi użytkownika do strony startowej.  Jeśli użytkownik ma na swoim koncie jakąś karę to po zalogowaniu wyświetla mu się komunikat, informujący o tym że musi opłacić karę aby móc dalej korzystać z biblioteki. Po zalogowaniu widzi również swoje wypożyczenia w postaci tytułu i daty wypożyczenia i zwrotu. 

Edycja konta 

Użytkownik może edytować swoje dane: imię, nazwisko, hasło, nr telefonu, adres, email oraz nr telefonu i pesel ( login musza zostać niezmienione).  W przypadku chęci zmiany hasła będzie musiał podać najpierw obecne hasło a następnie nowe hasło. Wszystkie zmienione dane mają taką walidacje jak podczas rejestracji. 

Historia wypożyczeń 

Użytkownik ma wgląd do całej swojej historii wypożyczeni, może sprawdzić od i do kiedy ma termin oddania wypożyczonych produktów, tytuł i typ wypożyczonego produktu oraz status zwrotu. 

 
