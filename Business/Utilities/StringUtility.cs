using System.Text.RegularExpressions;

namespace FleetManager.BLL.Utilities;
public static class StringUtility {
    public static string RemoveNonNumericCharacters(string input) {
        string formattedNumber = Regex.Replace(input, "[^0-9]", "");

        return formattedNumber;
    }
}
