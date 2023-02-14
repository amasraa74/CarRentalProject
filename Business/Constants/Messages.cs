using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Auto wurde hinzugefügt";
        public static string CarPriceInvalid = "Auto konnte nicht hinzugefügt werden, bitte Preis angeben";
        public static string CarDeleted = "Auto wurde entfernt";
        public static string CarUpdated = "Autodaten wurden aktualiesiert";
        public static string ColorInvalid = "Farbe unzulässig";
        public static string ColorAdded = "Farbe wurde hinzugefügt";
        public static string ColorDeleted = "Farbe wurde entfernt";
        public static string ColorUpdated = "Farbe wurde geändert";
        public static string BrandAdded = "Marke hinzugefügt";
        public static string InvalidBrand = "Marke unzulässig";
        public static string BrandDeleted = "Automarke wurde gelöscht";
        public static string BrandUpdated = "Automarke wurde geändert";
        public static string UserError = "User konnte nicht hinzugefügt werden";
        public static string UserAdded = "User wurde erfolgreich hinzugefügt";
        public static string UserDeleted = "User wurde gelöscht";
        public static string UserUpdated = "Userdaten wurden aktualisiert";
        public static string CarIsRented = "Auto ist leider bereits in vermietung";
        public static string RentCompleted = "Ihre vermietung haben Sie erfolgreich abgeschlossen";
        public static string RentalDeleted = "Ihre Vermietung wurde storniert";
        public static string RentalUpdated = "Ihre vermietung wurde aktualisiert";
        internal static string InvalidRetunrDate = "Bitte Rückgabe Datum angeben";
    }
}
