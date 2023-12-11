namespace FleetManager.Shared.HelperClasses;

public static class Generate {
    private static readonly Random RandomGenerator = new Random();
    private static int CalculateControlNumber(int number) {
        //This method will calculate the controlnumber of the NationalRegistrationNumber
        //according to the specific algorithm that is always used for generating Belgian
        //NationalRegistrationNumbers. 
        int remainder = number % 97;
        int controlNumber = 97 - remainder;
        return controlNumber;
    }

    private static string GenerateBirthcounterNumber(bool isFemale) {
        //This method generates a random BirthCounterNumber, which will be odd when
        //the person is male and even when the person is female. It will also add 0s
        //so that the length of the outputted string is always 3 characters long. 
        int minNumber = isFemale ? 2 : 1;
        int maxNumber = isFemale ? 998 : 997;
        int reeksnummer = RandomGenerator.Next(minNumber, maxNumber + 1);

        string reeksnummerStr = reeksnummer.ToString().PadLeft(3, '0');
        return reeksnummerStr;
    }

    public static string NationalRegistrationNumberFromBirthDate(DateTime birthdate, bool isFemale) {
        //This method generates a valid NationalRegistrationNumber from a BirthDate
        //It is especially useful for generating NationalRegistrationNumbers for 
        //BirthDates that are not fixed - i.e.: using DateTime.Now or DateTime.Today 

        int year = birthdate.Year % 100;
        int month = birthdate.Month;
        int day = birthdate.Day;

        string birthdatePart = $"{year:00}.{month:00}.{day:00}";
        string birthdateAsString = birthdatePart.Replace(".", "");

        string reeksnummerAsString = GenerateBirthcounterNumber(isFemale);

        string firstNineDigits = $"{birthdateAsString}{reeksnummerAsString}";

        int controlNumber = CalculateControlNumber(int.Parse(firstNineDigits));

        string rijksregisternummer = $"{birthdatePart}-{reeksnummerAsString}.{controlNumber:00}";
        return rijksregisternummer;
    }
}

