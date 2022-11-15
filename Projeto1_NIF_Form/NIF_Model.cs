using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Projeto1_NIF_Form
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Contacts
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }
    }

    public class Structure
    {
        [JsonPropertyName("nature")]
        public string Nature { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("capital_currency")]
        public string CapitalCurrency { get; set; }
    }

    public class Geo
    {
        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("county")]
        public string County { get; set; }

        [JsonPropertyName("parish")]
        public string Parish { get; set; }
    }

    public class Place
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("pc4")]
        public string Pc4 { get; set; }

        [JsonPropertyName("pc3")]
        public string Pc3 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }
    }

    public class NIF
    {
        [JsonPropertyName("nif")]
        public int Nif { get; set; }

        [JsonPropertyName("seo_url")]
        public string SeoUrl { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("pc4")]
        public string Pc4 { get; set; }

        [JsonPropertyName("pc3")]
        public string Pc3 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("start_date")]
        public object StartDate { get; set; }

        [JsonPropertyName("activity")]
        public string Activity { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("cae")]
        public string Cae { get; set; }

        [JsonPropertyName("contacts")]
        public Contacts Contacts { get; set; }

        [JsonPropertyName("structure")]
        public Structure Structure { get; set; }

        [JsonPropertyName("geo")]
        public Geo Geo { get; set; }

        [JsonPropertyName("place")]
        public Place Place { get; set; }

        [JsonPropertyName("racius")]
        public string Racius { get; set; }

        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("portugalio")]
        public string Portugalio { get; set; }
    }

    public class Records
    {
        [JsonPropertyName("NIF")]
        public NIF NIF { get; set; }
    }

    public class Left
    {
        [JsonPropertyName("month")]
        public int Month { get; set; }

        [JsonPropertyName("day")]
        public int Day { get; set; }

        [JsonPropertyName("hour")]
        public int Hour { get; set; }

        [JsonPropertyName("minute")]
        public int Minute { get; set; }

        [JsonPropertyName("paid")]
        public int Paid { get; set; }
    }

    public class Credits
    {
        [JsonPropertyName("used")]
        public string Used { get; set; }

        [JsonPropertyName("left")]
        public Left Left { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("records")]
        public Records Records { get; set; }

        [JsonPropertyName("nif_validation")]
        public bool NifValidation { get; set; }

        [JsonPropertyName("is_nif")]
        public bool IsNif { get; set; }

        [JsonPropertyName("credits")]
        public Credits Credits { get; set; }
    }
}
