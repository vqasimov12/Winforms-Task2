namespace Task2;

public class User
{
    public string username { get;set;}
    public string name { get;set;}
    public string surname { get;set;}
    public string father { get;set;}
    public string country { get;set;}
    public string city { get;set;}
    public string phone { get;set;}
    public string gender { get;set;}
    public DateTime birthday { get;set;}
    public override string ToString()
    {
        return $"{username}\nName: {name}\nSurname: {surname}\nFather: {father}\nCountry: {country}\nCity: {city}\nPhone: {phone}\nGender: {gender}\n BirthDate: {birthday}";
    }
}
