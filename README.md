Inner Class: Bir sınıfın başka bir sınıfın içinde tanımlanmış olan sınıfıdır. 
Anonymous Class: İsimsiz, yalnızca bir kez kullanılan ve genellikle hemen bir nesne oluşturmak için tanımlanan sınıftır.
Static Class: Sadece static üyeleri barındıran, nesne oluşturulamayan sınıftır.
Static Method: Bir sınıfın örneğine bağlı olmadan, sınıfın kendisine ait olan ve sınıf adı üzerinden çağrılabilen metottur.
Static Variable: Sınıfın her örneği için paylaşılan, sınıf düzeyinde tanımlanan ve değerini tüm nesneler arasında koruyan değişkendir.




Attribute'lar, bir sınıf, metod, property (özellik) gibi yapılara ekstra bilgi eklememize yarayan yapılardır. Yani, bu yapılara etiket (label) gibi bir şey eklemiş oluruz. Normalde yorum satırları sadece kodu okuyan için bilgi verir, ama attribute'lar program tarafından da okunabilir. Bu da onları çok daha güçlü ve esnek hale getirir.
Attribute'lar genellikle programın çeşitli bölümlerinde ek bilgi sağlamak amacıyla kullanılır. Mesela, eski metodları işaretlemek, veri doğrulama yapmak, bir nesneyi kaydedilebilir yapmak gibi durumlarda işimize yarar.

- **[Obsolete]**: Bu attribute, artık kullanılmayan veya eski metodları işaretler. Yani, bu metod kullanıldığında derleyici bir uyarı verir, ki "bu metod eskidi" denmiş olur.
- **[Required]**: Bu attribute, bir property’nin (özelliğin) boş geçilemeyeceğini belirtir. Örneğin, bir formda bir alan boş geçilmemelidir, bunun için kullanılabilir.
- **[Serializable]**: Bu attribute, bir nesnenin kaydedilebileceğini veya başka bir ortama aktarılabileceğini belirtir. Yani, bu nesne "seri hale getirilebilir."


[AttributeUsage(AttributeTargets.Property)]
public class MaxLengthAttribute : Attribute
{
    public int Length { get; }
    
    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

Attribute yazarken `Attribute` kelimesini eklemeye gerek yoktur. Mesela yukarıdaki sınıfı şu şekilde kullanabiliriz:

[MaxLength(10)]
public string Name { get; set; }


var propertyInfo = typeof(User).GetProperty("Name");
var attributes = propertyInfo.GetCustomAttributes(typeof(MaxLengthAttribute), false);

if (attributes.Length > 0)
{
    var maxLengthAttr = (MaxLengthAttribute)attributes[0];
    Console.WriteLine($"Max Length: {maxLengthAttr.Length}");
}



if (propertyInfo.IsDefined(typeof(RequiredAttribute), false))
{
    if (string.IsNullOrEmpty(value))
    {
        Console.WriteLine("Bu alan boş geçilemez.");
    }
}



