# .Net Core Intern Task: Great Recipe Occurs

### Bir çocuk gelişim platformu olan Kidokit'in çok acil bir ihtiyacı var. Çocuklara yemek tarifi için bir ortam hazırlanması gerekiyor.
- Ortak bir noktadan görüntülenecek olan bu tarifler 1 tane kullanıcı tarafından girilecektir.
- Girilen tariflerde ise bir tane resim yüklenmesi zorunlu olacaktır. Bu alan için link girilebilen bir akış da yeterli olacaktır.
- Tariflerin metnini girerken ise Markdown formatında bir içerik girilecektir. Bu alan için markdown zorunlu değildir.
- Tariflerin yayınlandığı tarihin sistem tarafından tutulması gerekmektedir.
- Her tarife ait 1 başlık ve kısa açıklama girilen alan gerekmektedir.
- Tariflerin listelenirken ayırt edilmesi adına Taglenmesi gerekmektedir. 
  - #Örn: Domates Çorbası başlığını, Çorba,Vitamin gibi çoklu olarak taglenebilecek bir sistem gerekiyor.
  - #Örn: Salata için ise Sağlıklı gibi tagler çoklu taglerin girilebileceği ve ilişkisinin olacağı bir sistem gerekir.


#### Not: Bu süreçte herhangi bir auth entegrasyonu beklenmemektedir. Sadece CRUD operasyonu yapılması bekleniyor. Denenecek olan endpointlerde 1 tane user her işi yapabiliyor şeklinde süreç ilerletilmesi gerekmektedir.

#### Bitmesi hedeflenen süre: 1 Ay(20 iş günü)
- Part1: DB Diagram, Kodlama standartlarını okuma ve benimseme, proje templateini farklı projeyi inceleyerek oluşturma, endpointlerin belirlenmesi ve feature taskların oluşturulması ( 10 iş günü )
- Part2: Kodlama sürecine geçiş ve akışına hakimiyet (5 iş günü )
- Part3: Revizyonların yapılması(4 gün)
- Part4: Projenin IIS üzerine deployment sürecinin ilerletilmesi(1 gün)

Buradaki sürelerde beklentilerimiz iş günü olarak yazıldı ancak extra efor verilmesi süreci iyileştirecektir. 

#### Kullanılacak Teknolojiler ve Prensipler;
- .Net Core 8 C#, verilen örnek proje .Net 6 karışıklık olmasın lütfen.
- MSSQL
- Projede C# kodlama standartlarına uyulması beklenmektedir(https://www.dofactory.com/csharp-coding-standards)
- API kısmında CRUD operasyonlarının yapılması hedeflenmektedir.
- Database ksımında Code First yaklaşımıyla development beklenmektedir.
- REST API Guidelines süreci iyileştirebilir.

#### Not: Database connection olarak localde ilerlenecektir, deployment sürecinde gerekli bilgiler sağlanacaktır.

#### Kodlama sürecinde beklentiler;
1. Database Diagramı ve gereksinimi belirlenecek, review edilecek.
2. Gerekli endpointler çıkarılacak, review edilecek.
3. Proje template i oluşturulmalıdır. En az 3 katmanlı olmalıdır ve API, Data, Services katmanlarından oluşması gerekmektedir.
4. Her feature için tasklar oluşturulmalıdır.
5. Her task için review süreci olacak.
6. Proje bittiğinde IIS'e publish edilecektir.


## Branch açarken dikkat edilmesi gereken durumlar
- Tüm branchler main'den açılması gerekmektedir.!!!
- Yeni branch tanımı yaparken;
  - eğer yapılan iş bir özellik katacaksa feature/yapilacak-isin-tanimi
  - eğer yapılan iş bir core sistem kurulumu ise core/yapilacak-isin-tanimi
  - eğer yapılan iş bir bugfix ise bugfix/yapilacak-isin-tanimi
  - eğer yapılan iş bir revizyon ise revision/yapilacak-isin-tanimi

- İş bittikten sonraki süreç
  - Yapılan iş için main e Pull Request açılır, review e gönderilir.
	


### NOT: Ne yaptığını biliyorsan Chat-GPT gibi AI toolarını kullanmak serbest.