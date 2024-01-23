namespace Business.Constants
{
    public class Messages
    {

        internal static readonly string NotBeExist;
        internal static readonly string AlreadyExist;
        internal static readonly string CurriculumVitaeAlreadyExist;
        internal static readonly string CurriculumVitaeNotBeExist;

        public static string MustFilling = "*Doldurulması zorunlu alan";
        public static string MustContainAtMinTwoChar = "En az 2 karakter girilmelidir.";

        public static string MustContainAtMinTwentyfiveChar = "En az 25 karakter girilmelidir.";//Announcement

        public static string AnnouncementNotExists = "Duyuru bulunamadı.";
        public static string ApplicationNotExists = "Başvuru bulunamadı.";
        public static string AuthNotExists = "İzin bulunamadı.";
        public static string CategoryNotExists = "Kategori bulunamadı.";
        public static string CertificateNotExists = "Sertifika bulunamadı.";
        internal static string? AsyncVideoNotExists = "Asenkron videoo bulunamadı.";
        internal static string? LikeNotExists = "Beğeniler bulunamadı.";
        internal static string? StudentLikeNotExists = "Öğrenci beğenileri bulunamadı.";




        public static string AddedData = "Veri Eklendi";
        public static string DeletedData = "Veri Silindi";
        public static string UpdatedData = "Veri Güncellendi";
        public static string ListedData = "Veri/Veriler Listelendi";



        public static string? UserMailAlreadyExists = "Böyle bir mail sisteme kayıtlıdır.";
        public static string? InstructorNotExists = "Eğitmen bulunamadı.";
        public static string? LanguageNotExists = "Böyle bir dil bulunamadı.";
        public static string? PersonalInformationNotExists = "Böyle bir kişisel bilgi bulunamadı.";
        public static string? SocialMediaNotExists = "Böyle bir sosyal medya bulunamadı.";
        public static string? StudentNotExists = "Böyle bir Öğrenci bulunamadı.";
        public static string? StudentLanguageNotExists = "Muhtemelen kullanmıcaz ara tablo bu.";
        public static string? SurveyNotExists = "Böyle bir survey bulunamadı.";

        public static string UserNotBeExist = "Kullanıcı mevcut değil";
        public static string? UserAlreadyExists = "Böyle bir kullanıcı mevcut.";


        public static string MustContainAtMaxTenChar = "Must contain a maximum of 10 characters";
        public static string MustContainAtMinElevenChar = "Must contain a minimum of 11 characters";
        public static string PleaseEnterAStrongerPassword = "Please enter a stronger password";
        public static string PleaseEnterAValidNationalyIdNumber = "Please enter a valid nationality id number";



        public static string? PasswordUncorrect = "Hatalı Paralo Girildi.";


        public static object? AccessTokenCreated = "Token Oluşturuldu";
        internal static string? PasswordDontMatch;

    }
}
