using System.Collections.Generic;

namespace SavarankiskasAirGenerator.Repositories
{
    public class AircraftRepository
    {
        private List<Aircraft> aircrafts = new List<Aircraft>();

        public AircraftRepository()
        {
            aircrafts.Add(new Aircraft(101, 1, 1082, "LY-SPH"));
            aircrafts.Add(new Aircraft(104, 9, 1093, "VQ-BSB"));
            aircrafts.Add(new Aircraft(105, 9, 1093, "VQ-BSA"));
            aircrafts.Add(new Aircraft(113, 1, 1120, "EI-FDL(EX.TC-KLA)"));
            aircrafts.Add(new Aircraft(1, 1, 1146, "UR-CKB"));
            aircrafts.Add(new Aircraft(41, 3, 6202, "PK-BBS"));
            aircrafts.Add(new Aircraft(42, 3, 6202, "PK-BBY"));
            aircrafts.Add(new Aircraft(43, 3, 6202, "PK-BBB"));
            aircrafts.Add(new Aircraft(44, 1, 1120, "TC-KLA"));
            aircrafts.Add(new Aircraft(45, 1, 1120, "EI-FDM"));
            aircrafts.Add(new Aircraft(46, 8, 1120, "EI-ETJ"));
            aircrafts.Add(new Aircraft(47, 8, 1120, "EI-ETH"));
            aircrafts.Add(new Aircraft(48, 8, 1120, "EI-ETK"));
            aircrafts.Add(new Aircraft(49, 8, 1120, "EI-ETL"));
            aircrafts.Add(new Aircraft(50, 8, 1120, "EI-FBV"));
            aircrafts.Add(new Aircraft(51, 8, 1120, "EI-FBF"));
            aircrafts.Add(new Aircraft(52, 8, 1120, "EI-FBH"));
            aircrafts.Add(new Aircraft(53, 3, 1701, "LY-FLH"));
            aircrafts.Add(new Aircraft(54, 1, 1701, "LY-SPA"));
            aircrafts.Add(new Aircraft(55, 1, 1701, "LY-SPB"));
            aircrafts.Add(new Aircraft(56, 1, 1701, "LY-SPC"));
            aircrafts.Add(new Aircraft(57, 5, 2676, "EX-37501"));
            aircrafts.Add(new Aircraft(58, 4, 2676, "EX-37401"));
            aircrafts.Add(new Aircraft(59, 3, 2676, "EX-37301"));
            aircrafts.Add(new Aircraft(60, 8, 1145, "UR-WRH"));
            aircrafts.Add(new Aircraft(61, 8, 1145, "UR-WRI"));
            aircrafts.Add(new Aircraft(62, 8, 1145, "UR-WRJ"));
            aircrafts.Add(new Aircraft(63, 1, 1145, "UR-WRK"));
            aircrafts.Add(new Aircraft(64, 1, 1145, "UR-WRM"));
            aircrafts.Add(new Aircraft(65, 8, 1145, "UR-WRO"));
            aircrafts.Add(new Aircraft(66, 8, 1145, "UR-WRP"));
            aircrafts.Add(new Aircraft(67, 1, 1082, "LY-SPK"));
            aircrafts.Add(new Aircraft(68, 1, 1082, "LY-SPJ"));
            aircrafts.Add(new Aircraft(69, 1, 1082, "SP-HAD"));
            aircrafts.Add(new Aircraft(71, 1, 1093, "VQ-BNR"));
            aircrafts.Add(new Aircraft(72, 1, 1093, "VP-BBN"));
            aircrafts.Add(new Aircraft(73, 1, 1093, "VP-BCU"));
            aircrafts.Add(new Aircraft(74, 1, 1093, "VP-BCN"));
            aircrafts.Add(new Aircraft(75, 1, 1093, "VP-BHW"));
            aircrafts.Add(new Aircraft(76, 1, 1093, "VP-BHX"));
            aircrafts.Add(new Aircraft(77, 1, 1093, "VP-BHZ"));
            aircrafts.Add(new Aircraft(78, 8, 1093, "VQ-BSQ"));
            aircrafts.Add(new Aircraft(79, 8, 1093, "VQ-BSM"));
            aircrafts.Add(new Aircraft(80, 5, 1093, "VP-BRU"));
            aircrafts.Add(new Aircraft(82, 5, 1093, "VP-BRV"));
            aircrafts.Add(new Aircraft(83, 5, 1093, "VP-BRQ"));
            aircrafts.Add(new Aircraft(84, 5, 1093, "VP-BRS"));
            aircrafts.Add(new Aircraft(85, 4, 1093, "VQ-BII"));
            aircrafts.Add(new Aircraft(86, 4, 1093, "VQ-BIK"));
            aircrafts.Add(new Aircraft(87, 5, 1093, "VQ-BNM"));
            aircrafts.Add(new Aircraft(88, 5, 1093, "VQ-BAB"));
            aircrafts.Add(new Aircraft(89, 4, 1093, "VP-BKW"));
            aircrafts.Add(new Aircraft(92, 9, 1093, "VQ-BPD"));
            aircrafts.Add(new Aircraft(93, 9, 1093, "VQ-BPC"));
            aircrafts.Add(new Aircraft(94, 9, 1093, "VQ-BPB"));
            aircrafts.Add(new Aircraft(95, 9, 1093, "VQ-BPA"));
            aircrafts.Add(new Aircraft(96, 9, 1093, "VP-BBA"));
            aircrafts.Add(new Aircraft(97, 9, 1093, "VP-BBC"));
            aircrafts.Add(new Aircraft(98, 9, 1093, "VP-BBE"));
            aircrafts.Add(new Aircraft(99, 9, 1093, "VP-BBM"));
            aircrafts.Add(new Aircraft(100, 9, 1093, "RA-67219"));
            aircrafts.Add(new Aircraft(102, 3, 1701, "LY-SPE"));
            aircrafts.Add(new Aircraft(106, 1, 1082, "LY-SPI"));
            aircrafts.Add(new Aircraft(110, 7, 1445, "SP-ENU"));
            aircrafts.Add(new Aircraft(112, 1, 1701, "LY-SPD"));
            aircrafts.Add(new Aircraft(4, 4, 1445, "SP-ENF"));
            aircrafts.Add(new Aircraft(17, 4, 1445, "SP-ENA"));
            aircrafts.Add(new Aircraft(18, 4, 1445, "SP-ENB"));
            aircrafts.Add(new Aircraft(19, 4, 1445, "SP-ENC"));
            aircrafts.Add(new Aircraft(20, 4, 1445, "SP-ENE"));
            aircrafts.Add(new Aircraft(21, 4, 1445, "SP-ENH"));
            aircrafts.Add(new Aircraft(22, 4, 1445, "SP-ENI"));
            aircrafts.Add(new Aircraft(23, 4, 1445, "SP-ENK"));
            aircrafts.Add(new Aircraft(31, 7, 1445, "SP-ENY"));
            aircrafts.Add(new Aircraft(32, 7, 1445, "SP-ENX"));
            aircrafts.Add(new Aircraft(33, 7, 1445, "SP-ENZ"));
            aircrafts.Add(new Aircraft(34, 7, 1445, "SP-ENW"));
            aircrafts.Add(new Aircraft(35, 7, 1445, "SP-ENV "));
            aircrafts.Add(new Aircraft(141, 8, 1120, "EI-FSB"));
            aircrafts.Add(new Aircraft(216, 1, 11277, "D-ASPE"));
            aircrafts.Add(new Aircraft(217, 1, 11277, "D-ASPF"));
            aircrafts.Add(new Aircraft(189, 1, 1093, "VQ-BWZ"));
            aircrafts.Add(new Aircraft(148, 1, 1082, "SP-HAI"));
            aircrafts.Add(new Aircraft(160, 4, 1462, "N/A"));
            aircrafts.Add(new Aircraft(162, 4, 1462, "857946"));
            aircrafts.Add(new Aircraft(193, 1, 1093, "VQ-BZS"));
            aircrafts.Add(new Aircraft(202, 8, 11277, "D-ASPC"));
            aircrafts.Add(new Aircraft(203, 8, 11277, "D-ASPD"));
            aircrafts.Add(new Aircraft(205, 8, 1082, "SP-HAU"));
            aircrafts.Add(new Aircraft(206, 8, 1082, "SP-HAV"));
            aircrafts.Add(new Aircraft(207, 8, 1082, "SP-HAW"));
            aircrafts.Add(new Aircraft(208, 8, 1082, "SP-HAX"));
            aircrafts.Add(new Aircraft(210, 8, 1082, "SP-HAY"));
            aircrafts.Add(new Aircraft(211, 8, 1082, "SP-HAZ"));
            aircrafts.Add(new Aircraft(151, 1, 1701, "LY-SPF"));
            aircrafts.Add(new Aircraft(125, 10, 2638, "SP-KTR"));
            aircrafts.Add(new Aircraft(126, 10, 2638, "SP-KTF"));
            aircrafts.Add(new Aircraft(127, 11, 2638, "SP-OLH"));
            aircrafts.Add(new Aircraft(128, 11, 2638, "SP-OLL"));
            aircrafts.Add(new Aircraft(181, 4, 11752, "HS-KMC"));
            aircrafts.Add(new Aircraft(163, 7, 1445, "SP-ENO"));
            aircrafts.Add(new Aircraft(164, 7, 1445, "SP-ENP"));
            aircrafts.Add(new Aircraft(167, 1, 11343, "CN-NMJ "));
            aircrafts.Add(new Aircraft(219, 8, 1145, "UR-WRT"));
            aircrafts.Add(new Aircraft(198, 1, 14218, "XU-801 (LY-SPH)"));
            aircrafts.Add(new Aircraft(200, 1, 3075, "AP-EDG"));
            aircrafts.Add(new Aircraft(156, 1, 1701, "XU-802 (LY-SPG)"));
            aircrafts.Add(new Aircraft(145, 7, 1445, "SP-ENQ"));
            aircrafts.Add(new Aircraft(157, 1, 11277, "D-ABDB"));
            aircrafts.Add(new Aircraft(158, 1, 11277, "D-ASPG"));
            aircrafts.Add(new Aircraft(192, 4, 5737, "LY-GTW"));
            aircrafts.Add(new Aircraft(138, 7, 1445, "SP-ENT"));
            aircrafts.Add(new Aircraft(188, 1, 11277, "D-ASPI"));
            aircrafts.Add(new Aircraft(122, 3, 1701, "LY-AQV"));
            aircrafts.Add(new Aircraft(123, 3, 1701, "LY-FLJ"));
            aircrafts.Add(new Aircraft(124, 3, 1701, "LY-AQX"));
            aircrafts.Add(new Aircraft(137, 1, 1082, "SP-HAH"));
            aircrafts.Add(new Aircraft(170, 4, 11752, "HS-KMA"));
            aircrafts.Add(new Aircraft(144, 3, 6202, "PK-BBC"));
            aircrafts.Add(new Aircraft(171, 4, 5737, "LY-CGC"));
            aircrafts.Add(new Aircraft(172, 3, 5737, "LY-LGC"));
            aircrafts.Add(new Aircraft(173, 3, 5737, "LY-GGC"));
            aircrafts.Add(new Aircraft(178, 4, 5737, "LY-MGC"));
            aircrafts.Add(new Aircraft(179, 4, 5737, "LY-PGC"));
            aircrafts.Add(new Aircraft(187, 1, 1701, "LY-ONL"));
            aircrafts.Add(new Aircraft(194, 8, 1093, "VP-BWO"));
            aircrafts.Add(new Aircraft(166, 1, 1462, "B78"));
            aircrafts.Add(new Aircraft(130, 1, 1145, "UR-WRN"));
            aircrafts.Add(new Aircraft(131, 1, 1145, "UR-WRL"));
            aircrafts.Add(new Aircraft(132, 3, 1035, "LY-FLC"));
            aircrafts.Add(new Aircraft(133, 3, 1035, "LY-FLE"));
            aircrafts.Add(new Aircraft(168, 4, 11752, "HS-KMB"));
            aircrafts.Add(new Aircraft(143, 7, 1445, "SP-ENR"));
            aircrafts.Add(new Aircraft(183, 5, 11557, "VP-BYJ"));
            aircrafts.Add(new Aircraft(119, 1, 1082, "SP-HAG"));
            aircrafts.Add(new Aircraft(186, 1, 1701, "LY-ONJ"));
        }

        public List<Aircraft> Retrieve()
        {
            return aircrafts;
        }

        public Aircraft Retrieve(int aircraftId)
        {
            foreach (Aircraft aircraft in aircrafts)
            {
                if (aircraft.Id == aircraftId)
                {
                    return aircraft;
                }
            }
            return null;
        }
    }
}
