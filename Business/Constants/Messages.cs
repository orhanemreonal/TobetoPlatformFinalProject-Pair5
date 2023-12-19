using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {

        internal static readonly string NotBeExist;
        internal static readonly string AlreadyExist;
        internal static readonly string CurriculumVitaeAlreadyExist;
        internal static readonly string CurriculumVitaeNotBeExist;

        public static string AddedData = "Veri Eklendi";
        public static string DeletedData = "Veri Silindi";
        public static string UpdatedData = "Veri Güncellendi";
        public static string ListedData = "Veri/Veriler Listelendi";

        public static string UserNotBeExist = "User not be exist";
        public static string UserAlreadyExist = "User already exist";


        public static string MustContainAtMinTwoChar = "Must contain at minimum 2 characters";
        public static string MustContainAtMaxTenChar = "Must contain a maximum of 10 characters";
        public static string MustContainAtMinElevenChar = "Must contain a minimum of 11 characters";
        public static string PleaseEnterAStrongerPassword = "Please enter a stronger password";
        public static string PleaseEnterAValidNationalyIdNumber = "Please enter a valid nationality id number";


    }
}
