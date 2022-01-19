﻿using System.Collections.Generic;
using System.Linq;

namespace SavarankiskasAirGenerator.Repositories
{
    public class CountryRepository
    {
        private List<Country> countries = new List<Country>();

        public CountryRepository()
        {
            countries.Add(new Country(1, "LT", "Lithuania", "Europe", true)); //1
            countries.Add(new Country(229, "KR", "Republic of South Korea", "Asia", false));
            countries.Add(new Country(224, "PL", "Poland", "Europe", true)); //224
            countries.Add(new Country(5, "DE", "Germany", "Europe", true));
            countries.Add(new Country(201, "RS", "Serbia", "Europe", false)); //223
            countries.Add(new Country(3, "US", "USA", "North America", false));
            countries.Add(new Country(6, "AD", "Andorra", "Europe", false));
            countries.Add(new Country(7, "AE", "United Arab Emirates", "Asia", false));
            countries.Add(new Country(8, "AF", "Afghanistan", "Asia", false));
            countries.Add(new Country(9, "AG", "Antigua and Barbuda", "Central America", false));
            countries.Add(new Country(10, "AI", "Anguilla", "North America", false));
            countries.Add(new Country(11, "AL", "Albania", "Europe", false));
            countries.Add(new Country(12, "AM", "Armenia", "Asia", false));
            countries.Add(new Country(13, "AN", "Netherlands Antilles", "North America", false));
            countries.Add(new Country(14, "AR", "Argentina", "South America", false));
            countries.Add(new Country(15, "AS", "American Samoa", "Australia/Oceania", false));
            countries.Add(new Country(16, "AT", "Austria", "Europe", true));
            countries.Add(new Country(17, "ZW", "Zimbabwe", "Africa", false));
            countries.Add(new Country(18, "ZR", "Zaire", "Africa", false));
            countries.Add(new Country(19, "ZM", "Zambia", "Africa", false));
            countries.Add(new Country(20, "ZA", "South Africa", "Africa", false));
            countries.Add(new Country(21, "YU", "Yugoslavia", "Europe", false));
            countries.Add(new Country(22, "YE", "Yemen", "Asia", false));
            countries.Add(new Country(23, "WS", "Samoa", "Australia/Oceania", false));
            countries.Add(new Country(24, "WF", "Wallis and Futuna Islands", "Australia/Oceania", false));
            countries.Add(new Country(25, "VU", "Vanuatu", "Australia/Oceania", false));
            countries.Add(new Country(26, "VN", "Vietnam", "Asia", false));
            countries.Add(new Country(27, "VI", "Virgin Islands (USA)", "North America", false));
            countries.Add(new Country(28, "VG", "Virgin Islands (British)", "North America", false));
            countries.Add(new Country(29, "VE", "Venezuela", "South America", false));
            countries.Add(new Country(30, "VC", "Saint Vincent & Grenadines", "Central America", false));
            countries.Add(new Country(31, "UZ", "Uzbekistan", "Asia", false));
            countries.Add(new Country(32, "UY", "Uruguay", "South America", false));
            countries.Add(new Country(36, "UG", "Uganda", "Africa", false));
            countries.Add(new Country(34, "UM", "USA Minor Outlying Islands", "North America", false));
            countries.Add(new Country(35, "UK", "United Kingdom", "Europe", true)); //
            countries.Add(new Country(37, "UA", "Ukraine", "Europe", false));
            countries.Add(new Country(38, "TZ", "Tanzania", "Africa", false));
            countries.Add(new Country(39, "TW", "Taiwan", "Asia", false));
            countries.Add(new Country(40, "TV", "Tuvalu", "Australia/Oceania", false));
            countries.Add(new Country(41, "TT", "Trinidad and Tobago", "Central America", false));
            countries.Add(new Country(42, "TR", "Turkey", "Asia", false));
            countries.Add(new Country(43, "TO", "Tonga", "Australia/Oceania", false));
            countries.Add(new Country(44, "TN", "Tunisia", "Africa", false));
            countries.Add(new Country(45, "TM", "Turkmenistan", "Asia", false));
            countries.Add(new Country(46, "TK", "Tokelau", "Australia/Oceania", false));
            countries.Add(new Country(47, "TJ", "Tajikistan", "Asia", false));
            countries.Add(new Country(48, "TH", "Thailand", "Asia", false));
            countries.Add(new Country(49, "TG", "Togo", "Africa", false));
            countries.Add(new Country(50, "TF", "French Southern Territories", "Antarctica", false));
            countries.Add(new Country(51, "TD", "Chad", "Africa", false));
            countries.Add(new Country(52, "TC", "Turks and Caicos Islands", "Central America", false));
            countries.Add(new Country(53, "SZ", "Swaziland", "Africa", false));
            countries.Add(new Country(54, "SY", "Syria", "Asia", false));
            countries.Add(new Country(55, "SR", "Suriname", "South America", false));
            countries.Add(new Country(56, "SO", "Somalia", "Africa", false));
            countries.Add(new Country(57, "SN", "Senegal", "Africa", false));
            countries.Add(new Country(58, "SM", "San Marino", "Europe", false));
            countries.Add(new Country(59, "SL", "Sierra Leone", "Africa", false));
            countries.Add(new Country(60, "SK", "Slovakia", "Europe", true));
            countries.Add(new Country(61, "SJ", "Svalbard and Jan Mayen Islands", "Europe", false));
            countries.Add(new Country(62, "SI", "Slovenia", "Europe", true));
            countries.Add(new Country(63, "SH", "Saint Helena", "Africa", false));
            countries.Add(new Country(64, "SG", "Singapore", "Asia", false));
            countries.Add(new Country(65, "SE", "Sweden", "Europe", true));
            countries.Add(new Country(66, "SC", "Seychelles", "Africa", false));
            countries.Add(new Country(67, "SB", "Solomon Islands", "Australia/Oceania", false));
            countries.Add(new Country(68, "SA", "Saudi Arabia", "Asia", false));
            countries.Add(new Country(69, "RW", "Rwanda", "Africa", false));
            countries.Add(new Country(70, "RU", "Russian Federation", "Europe", false));
            countries.Add(new Country(71, "RO", "Romania", "Europe", true));
            countries.Add(new Country(72, "RE", "Reunion (French)", "Africa", false));
            countries.Add(new Country(73, "QA", "Qatar", "Asia", false));
            countries.Add(new Country(74, "PW", "Palau", "Australia/Oceania", false));
            countries.Add(new Country(75, "PT", "Portugal", "Europe", true));
            countries.Add(new Country(76, "PR", "Puerto Rico", "Central America", false));
            countries.Add(new Country(77, "PN", "Pitcairn Island", "Australia/Oceania", false));
            countries.Add(new Country(78, "PM", "Saint Pierre and Miquelon", "North America", false));
            countries.Add(new Country(79, "PK", "Pakistan", "Asia", false));
            countries.Add(new Country(80, "PH", "Philippines", "Asia", false));
            countries.Add(new Country(81, "PG", "Papua New Guinea", "Australia/Oceania", false));
            countries.Add(new Country(82, "PE", "Peru", "South America", false));
            countries.Add(new Country(83, "PA", "Panama", "Central America", false));
            countries.Add(new Country(84, "AU", "Australia", "Australia/Oceania", false));
            countries.Add(new Country(85, "AW", "Aruba", "South America", false));
            countries.Add(new Country(86, "AZ", "Azerbaijan", "Asia", false));
            countries.Add(new Country(87, "BB", "Barbados", "Central America", false));
            countries.Add(new Country(88, "BD", "Bangladesh", "Asia", false));
            countries.Add(new Country(89, "BE", "Belgium", "Europe", true));
            countries.Add(new Country(90, "BF", "Burkina Faso", "Africa", false));
            countries.Add(new Country(91, "BG", "Bulgaria", "Europe", true));
            countries.Add(new Country(92, "BH", "Bahrain", "Asia", false));
            countries.Add(new Country(94, "BN", "Brunei Darussalam", "Asia", false));
            countries.Add(new Country(95, "BR", "Brazil", "South America", false));
            countries.Add(new Country(96, "BS", "Bahamas", "Central America", false));
            countries.Add(new Country(97, "BT", "Bhutan", "Asia", false));
            countries.Add(new Country(98, "BV", "Bouvet Island", "Antarctica", false));
            countries.Add(new Country(99, "BW", "Botswana", "Africa", false));
            countries.Add(new Country(100, "BY", "Belarus", "Europe", false));
            countries.Add(new Country(101, "BZ", "Belize", "Central America", false));
            countries.Add(new Country(102, "CA", "Canada", "North America", false));
            countries.Add(new Country(103, "CC", "Cocos (Keeling) Islands", "Asia", false));
            countries.Add(new Country(104, "CF", "Central African Republic", "Africa", false));
            countries.Add(new Country(105, "CG", "Congo", "Africa", false));
            countries.Add(new Country(106, "CH", "Switzerland", "Europe", false));
            countries.Add(new Country(107, "CK", "Cook Islands", "Australia/Oceania", false));
            countries.Add(new Country(108, "CL", "Chile", "South America", false));
            countries.Add(new Country(109, "CM", "Cameroon", "Africa", false));
            countries.Add(new Country(110, "CN", "China", "Asia", false));
            countries.Add(new Country(111, "CO", "Colombia", "South America", false));
            countries.Add(new Country(112, "CR", "Costa Rica", "Central America", false));
            countries.Add(new Country(113, "CU", "Cuba", "Central America", false));
            countries.Add(new Country(114, "CV", "Cape Verde", "Africa", false));
            countries.Add(new Country(115, "CX", "Christmas Island", "Asia", false));
            countries.Add(new Country(116, "CY", "Cyprus", "Europe", true));
            countries.Add(new Country(117, "CZ", "Czech Republic", "Europe", true));
            countries.Add(new Country(121, "DM", "Dominica", "Central America", false));
            countries.Add(new Country(119, "DJ", "Djibouti", "Africa", false));
            countries.Add(new Country(120, "DK", "Denmark", "Europe", true));
            countries.Add(new Country(122, "DO", "Dominican Republic", "Central America", false));
            countries.Add(new Country(123, "DZ", "Algeria", "Africa", false));
            countries.Add(new Country(124, "EC", "Ecuador", "South America", false));
            countries.Add(new Country(125, "EE", "Estonia", "Europe", true));
            countries.Add(new Country(126, "EG", "Egypt", "Africa", false));
            countries.Add(new Country(127, "EH", "Western Sahara", "Africa", false));
            countries.Add(new Country(128, "ER", "Eritrea", "Africa", false));
            countries.Add(new Country(129, "ES", "Spain", "Europe", true));
            countries.Add(new Country(130, "ET", "Ethiopia", "Africa", false));
            countries.Add(new Country(131, "FI", "Finland", "Europe", true));
            countries.Add(new Country(132, "FJ", "Fiji", "Australia/Oceania", false));
            countries.Add(new Country(133, "FK", "Falkland Islands", "South America", false));
            countries.Add(new Country(134, "FM", "Micronesia", "Australia/Oceania", false));
            countries.Add(new Country(135, "FO", "Faroe Islands", "Europe", false));
            countries.Add(new Country(136, "FR", "France", "Europe", true));
            countries.Add(new Country(137, "GA", "Gabon", "Africa", false));
            countries.Add(new Country(138, "GD", "Grenada", "Central America", false));
            countries.Add(new Country(139, "GE", "Georgia", "Asia", false));
            countries.Add(new Country(140, "OM", "Oman", "Asia", false));
            countries.Add(new Country(141, "NZ", "New Zealand", "Australia/Oceania", false));
            countries.Add(new Country(142, "NU", "Niue", "Australia/Oceania", false));
            countries.Add(new Country(143, "NR", "Nauru", "Australia/Oceania", false));
            countries.Add(new Country(144, "NP", "Nepal", "Asia", false));
            countries.Add(new Country(145, "NO", "Norway", "Europe", false));
            countries.Add(new Country(146, "NL", "Netherlands", "Europe", true)); //
            countries.Add(new Country(147, "NG", "Nigeria", "Africa", false));
            countries.Add(new Country(148, "NF", "Norfolk Island", "Australia/Oceania", false));
            countries.Add(new Country(149, "NE", "Niger", "Africa", false));
            countries.Add(new Country(150, "NC", "New Caledonia (French)", "Australia/Oceania", false));
            countries.Add(new Country(151, "NA", "Namibia", "Africa", false));
            countries.Add(new Country(152, "MZ", "Mozambique", "Africa", false));
            countries.Add(new Country(153, "MY", "Malaysia", "Asia", false));
            countries.Add(new Country(154, "MX", "Mexico", "North America", false));
            countries.Add(new Country(155, "MV", "Maldives", "Asia", false));
            countries.Add(new Country(156, "MU", "Mauritius", "Africa", false));
            countries.Add(new Country(157, "MT", "Malta", "Europe", true));
            countries.Add(new Country(158, "MS", "Montserrat", "North America", false));
            countries.Add(new Country(159, "MR", "Mauritania", "Africa", false));
            countries.Add(new Country(160, "MQ", "Martinique (French)", "North America", false));
            countries.Add(new Country(161, "MP", "Northern Mariana Islands", "Australia/Oceania", false));
            countries.Add(new Country(162, "MO", "Macau", "Asia", false));
            countries.Add(new Country(163, "MN", "Mongolia", "Asia", false));
            countries.Add(new Country(164, "MM", "Myanmar", "Asia", false));
            countries.Add(new Country(165, "ML", "Mali", "Africa", false));
            countries.Add(new Country(166, "MK", "Macedonia", "Europe", false));
            countries.Add(new Country(167, "MH", "Marshall Islands", "Australia/Oceania", false));
            countries.Add(new Country(168, "MG", "Madagascar", "Africa", false));
            countries.Add(new Country(169, "MD", "Moldova", "Europe", false));
            countries.Add(new Country(170, "MC", "Monaco", "Europe", false));
            countries.Add(new Country(171, "MA", "Morocco", "Africa", false));
            countries.Add(new Country(172, "LY", "Libya", "Africa", false));
            countries.Add(new Country(173, "LV", "Latvia", "Europe", true));
            countries.Add(new Country(174, "LU", "Luxembourg", "Europe", true));
            countries.Add(new Country(175, "LS", "Lesotho", "Africa", false));
            countries.Add(new Country(176, "LR", "Liberia", "Africa", false));
            countries.Add(new Country(177, "LK", "Sri Lanka", "Asia", false));
            countries.Add(new Country(178, "LI", "Liechtenstein", "Europe", false));
            countries.Add(new Country(179, "LC", "Saint Lucia", "Central America", false));
            countries.Add(new Country(180, "LB", "Lebanon", "Asia", false));
            countries.Add(new Country(181, "LA", "Lao People s Democratic Republic", "Asia", false));
            countries.Add(new Country(182, "KZ", "Kazakhstan", "Asia", false));
            countries.Add(new Country(183, "KY", "Cayman Islands", "North America", false));
            countries.Add(new Country(184, "KW", "Kuwait", "Asia", false));
            countries.Add(new Country(185, "KN", "Saint Kitts & Nevis Anguilla", "Central America", false));
            countries.Add(new Country(186, "KM", "Comoros", "Africa", false));
            countries.Add(new Country(187, "KI", "Kiribati", "Australia/Oceania", false));
            countries.Add(new Country(188, "KH", "Cambodia", "Asia", false));
            countries.Add(new Country(189, "KG", "Kyrgyzstan", "Asia", false));
            countries.Add(new Country(190, "KE", "Kenya", "Africa", false));
            countries.Add(new Country(191, "JP", "Japan", "Asia", false));
            countries.Add(new Country(192, "JO", "Jordan", "Asia", false));
            countries.Add(new Country(193, "JM", "Jamaica", "Central America", false));
            countries.Add(new Country(194, "IT", "Italy", "Europe", true));
            countries.Add(new Country(195, "IS", "Iceland", "Europe", false));
            countries.Add(new Country(196, "IR", "Iran", "Asia", false));
            countries.Add(new Country(197, "IQ", "Iraq", "Asia", false));
            countries.Add(new Country(198, "IO", "British Indian Ocean Territory", "Asia", false));
            countries.Add(new Country(199, "INT", "International", null, null));
            countries.Add(new Country(200, "IN", "India", "Asia", false));
            countries.Add(new Country(201, "IL", "Israel", "Asia", false));
            countries.Add(new Country(202, "IE", "Ireland", "Europe", true));
            countries.Add(new Country(203, "ID", "Indonesia", "Asia", false));
            countries.Add(new Country(204, "HU", "Hungary", "Europe", true));
            countries.Add(new Country(205, "HT", "Haiti", "Central America", false));
            countries.Add(new Country(206, "HR", "Croatia", "Europe", true));
            countries.Add(new Country(207, "HN", "Honduras", "Central America", false));
            countries.Add(new Country(208, "HM", "Heard and McDonald Islands", "Antarctica", false));
            countries.Add(new Country(209, "HK", "Hong Kong", "Asia", false));
            countries.Add(new Country(210, "GY", "Guyana", "South America", false));
            countries.Add(new Country(211, "GW", "Guinea Bissau", "Africa", false));
            countries.Add(new Country(212, "GU", "Guam (USA)", "Australia/Oceania", false));
            countries.Add(new Country(213, "GT", "Guatemala", "Central America", false));
            countries.Add(new Country(214, "GR", "Greece", "Europe", true));
            countries.Add(new Country(215, "GQ", "Equatorial Guinea", "Africa", false));
            countries.Add(new Country(216, "GP", "Guadeloupe (French)", "North America", false));
            countries.Add(new Country(217, "GN", "Guinea", "Africa", false));
            countries.Add(new Country(218, "GM", "Gambia", "Africa", false));
            countries.Add(new Country(219, "GL", "Greenland", "North America", false));
            countries.Add(new Country(220, "GI", "Gibraltar", "Europe", false));
            countries.Add(new Country(221, "GH", "Ghana", "Africa", false));
            countries.Add(new Country(222, "GF", "French Guyana", "South America", false));
            countries.Add(new Country(231, "BM", "Bermuda", "North America", false));
            countries.Add(new Country(233, "SD", "Sudan", "Africa", false));
            countries.Add(new Country(234, "ME", "Montenegro", "Europe", false));
            countries.Add(new Country(225, "BA", "Bosnia and Herzegovina", "Europe", false));
            countries.Add(new Country(246, "SS", "South Sudan", "Africa", false));
            countries.Add(new Country(247, "AO", "Angola", "Africa", false));
            countries.Add(new Country(255, "CI", "Cote d Ivoire", "Africa", false));
            countries.Add(new Country(244, "SV", "El Salvador", "Central America", false));
            countries.Add(new Country(245, "BO", "Bolivia", "South America", false));
            countries.Add(new Country(256, "PY", "Paraguay", "South America", false));
        }

        public List<Country> Retrieve()
        {
            return countries;
        }

        public Country Retrieve(int countryId)
        {
            foreach (Country country in countries)
            {
                if (country.Id == countryId)
                {
                    return country;
                }
            }
            return null;
        }
        //public Country GetById(int id)
        //{
        //    var order = countries.FirstOrDefault(x => x.Id == id);
        //    return country;
        //}
    }
}
