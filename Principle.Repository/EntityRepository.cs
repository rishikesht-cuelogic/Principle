using Principle.Models.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Repository
{
    public class EntityRepository
    {
        #region Declaration(s)
        private List<WildSearchModel> masterBrands;
        private List<WildSearchModel> newBrands;

        #endregion

        #region Properties
        public List<WildSearchModel> MasterBrands
        {
            get
            {
                return masterBrands;
            }
        }

        public List<WildSearchModel> NewBrands
        {
            get
            {
                return newBrands;
            }
        }
        #endregion

        #region Constructor(s)
        public EntityRepository()
        {
            CreateMockData();
        }

        #endregion

        #region Method(s)
        #endregion

        #region Function(s)
        public void CreateMockData()
        {
            masterBrands = new List<WildSearchModel>();
            masterBrands.Add(new WildSearchModel() { Id = 1, Name = "GEELY" });
            masterBrands.Add(new WildSearchModel() { Id = 2, Name = "HYUNDAI+SUZUKI" });
            masterBrands.Add(new WildSearchModel() { Id = 3, Name = "CADILLAC" });
            masterBrands.Add(new WildSearchModel() { Id = 4, Name = "CHANGHE" });
            masterBrands.Add(new WildSearchModel() { Id = 5, Name = "AUTOVAZ" });
            masterBrands.Add(new WildSearchModel() { Id = 6, Name = "MASERATI" });
            masterBrands.Add(new WildSearchModel() { Id = 7, Name = "YUEJIN" });
            masterBrands.Add(new WildSearchModel() { Id = 8, Name = "BIKA" });
            masterBrands.Add(new WildSearchModel() { Id = 9, Name = "ROVER" });
            masterBrands.Add(new WildSearchModel() { Id = 10, Name = "HONDA" });
            masterBrands.Add(new WildSearchModel() { Id = 11, Name = "ROEWE" });
            masterBrands.Add(new WildSearchModel() { Id = 12, Name = "DACIA" });
            masterBrands.Add(new WildSearchModel() { Id = 13, Name = "AIXAM" });
            masterBrands.Add(new WildSearchModel() { Id = 14, Name = "LAND ROVER" });
            masterBrands.Add(new WildSearchModel() { Id = 15, Name = "CHRYSLER+DODGE+JEEP" });
            masterBrands.Add(new WildSearchModel() { Id = 16, Name = "VOLKSWAGEN GROUP" });
            masterBrands.Add(new WildSearchModel() { Id = 17, Name = "FISKER" });
            masterBrands.Add(new WildSearchModel() { Id = 18, Name = "ZOTYE" });
            masterBrands.Add(new WildSearchModel() { Id = 19, Name = "LUXGEN" });
            masterBrands.Add(new WildSearchModel() { Id = 20, Name = "JCBL" });
            masterBrands.Add(new WildSearchModel() { Id = 21, Name = "JEEP" });
            masterBrands.Add(new WildSearchModel() { Id = 22, Name = "WEIZHI" });
            masterBrands.Add(new WildSearchModel() { Id = 23, Name = "TOWN LIFE" });
            masterBrands.Add(new WildSearchModel() { Id = 24, Name = "SUBARU" });
            masterBrands.Add(new WildSearchModel() { Id = 25, Name = "VOLVO" });
            masterBrands.Add(new WildSearchModel() { Id = 26, Name = "JAGUAR LAND ROVER" });
            masterBrands.Add(new WildSearchModel() { Id = 27, Name = "DAIHATSU+TOYOTA" });
            masterBrands.Add(new WildSearchModel() { Id = 28, Name = "SSANGYONG" });
            masterBrands.Add(new WildSearchModel() { Id = 29, Name = "ALPINA" });
            masterBrands.Add(new WildSearchModel() { Id = 30, Name = "HIGER" });
            masterBrands.Add(new WildSearchModel() { Id = 31, Name = "SUZUKI" });
            masterBrands.Add(new WildSearchModel() { Id = 32, Name = "HAWTAI" });
            masterBrands.Add(new WildSearchModel() { Id = 33, Name = "KARRY" });
            masterBrands.Add(new WildSearchModel() { Id = 34, Name = "UNIMOG" });
            masterBrands.Add(new WildSearchModel() { Id = 35, Name = "CHERY" });
            masterBrands.Add(new WildSearchModel() { Id = 36, Name = "JIANGHUAI" });
            masterBrands.Add(new WildSearchModel() { Id = 37, Name = "SOUEAST" });
            masterBrands.Add(new WildSearchModel() { Id = 38, Name = "FERRARI" });
            masterBrands.Add(new WildSearchModel() { Id = 39, Name = "KUNCHENG" });
            masterBrands.Add(new WildSearchModel() { Id = 40, Name = "DR." });
            masterBrands.Add(new WildSearchModel() { Id = 41, Name = "SAAB" });
            masterBrands.Add(new WildSearchModel() { Id = 42, Name = "SYM." });
            masterBrands.Add(new WildSearchModel() { Id = 43, Name = "PONTIAC" });
            masterBrands.Add(new WildSearchModel() { Id = 44, Name = "YEMA" });
            masterBrands.Add(new WildSearchModel() { Id = 45, Name = "GREAT WALL" });
            masterBrands.Add(new WildSearchModel() { Id = 46, Name = "ZAZ" });
            masterBrands.Add(new WildSearchModel() { Id = 47, Name = "TATA" });
            masterBrands.Add(new WildSearchModel() { Id = 48, Name = "GAZ" });
            masterBrands.Add(new WildSearchModel() { Id = 49, Name = "UTV." });
            masterBrands.Add(new WildSearchModel() { Id = 50, Name = "FORD+LINCOLN" });
            masterBrands.Add(new WildSearchModel() { Id = 51, Name = "RENAULT" });
            masterBrands.Add(new WildSearchModel() { Id = 52, Name = "HUMMER" });
            masterBrands.Add(new WildSearchModel() { Id = 53, Name = "TIANJIN" });
            masterBrands.Add(new WildSearchModel() { Id = 54, Name = "TESLA" });
            masterBrands.Add(new WildSearchModel() { Id = 55, Name = "JIANGNAN" });
            masterBrands.Add(new WildSearchModel() { Id = 56, Name = "FOTON" });
            masterBrands.Add(new WildSearchModel() { Id = 57, Name = "MUNDI AUTO" });
            masterBrands.Add(new WildSearchModel() { Id = 58, Name = "SCION" });
            masterBrands.Add(new WildSearchModel() { Id = 59, Name = "GMC TRUCK" });
            masterBrands.Add(new WildSearchModel() { Id = 60, Name = "AGRALE" });
            masterBrands.Add(new WildSearchModel() { Id = 61, Name = "INFINITI" });
            masterBrands.Add(new WildSearchModel() { Id = 62, Name = "DODGE" });
            masterBrands.Add(new WildSearchModel() { Id = 63, Name = "ZHONGXING" });
            masterBrands.Add(new WildSearchModel() { Id = 64, Name = "RUILING" });
            masterBrands.Add(new WildSearchModel() { Id = 65, Name = "ASTON MARTIN" });
            masterBrands.Add(new WildSearchModel() { Id = 66, Name = "ZHONGHUA" });
            masterBrands.Add(new WildSearchModel() { Id = 67, Name = "GEELY+GLEAGLE" });
            masterBrands.Add(new WildSearchModel() { Id = 68, Name = "HYUNDAI" });
            masterBrands.Add(new WildSearchModel() { Id = 69, Name = "XIYATE" });
            masterBrands.Add(new WildSearchModel() { Id = 70, Name = "XIALI" });
            masterBrands.Add(new WildSearchModel() { Id = 71, Name = "BEIJING" });
            masterBrands.Add(new WildSearchModel() { Id = 72, Name = "RADICAL SPORTCARS" });
            masterBrands.Add(new WildSearchModel() { Id = 73, Name = "DODGE+JEEP" });
            masterBrands.Add(new WildSearchModel() { Id = 74, Name = "ABARTH" });
            masterBrands.Add(new WildSearchModel() { Id = 75, Name = "SEAT" });
            masterBrands.Add(new WildSearchModel() { Id = 76, Name = "SOKON" });
            masterBrands.Add(new WildSearchModel() { Id = 77, Name = "JMC" });
            masterBrands.Add(new WildSearchModel() { Id = 78, Name = "MITSUBISHI" });
            masterBrands.Add(new WildSearchModel() { Id = 79, Name = "VOLKSWAGEN" });
            masterBrands.Add(new WildSearchModel() { Id = 80, Name = "ZAP" });
            masterBrands.Add(new WildSearchModel() { Id = 81, Name = "YUSHENG" });
            masterBrands.Add(new WildSearchModel() { Id = 82, Name = "DONGFENG" });
            masterBrands.Add(new WildSearchModel() { Id = 83, Name = "LITTLE" });
            masterBrands.Add(new WildSearchModel() { Id = 84, Name = "ENGLON" });
            masterBrands.Add(new WildSearchModel() { Id = 85, Name = "BUICK+CHEVROLET" });
            masterBrands.Add(new WildSearchModel() { Id = 86, Name = "BYD" });
            masterBrands.Add(new WildSearchModel() { Id = 87, Name = "ACURA" });
            masterBrands.Add(new WildSearchModel() { Id = 88, Name = "XARRINA" });
            masterBrands.Add(new WildSearchModel() { Id = 89, Name = "CHANA+HAFEI" });
            masterBrands.Add(new WildSearchModel() { Id = 90, Name = "MITSUBISHI+SOUEAST" });
            masterBrands.Add(new WildSearchModel() { Id = 91, Name = "ISUZU" });
            masterBrands.Add(new WildSearchModel() { Id = 92, Name = "CARBON" });
            masterBrands.Add(new WildSearchModel() { Id = 93, Name = "OLDSMOBILE" });
            masterBrands.Add(new WildSearchModel() { Id = 94, Name = "PROTON" });
            masterBrands.Add(new WildSearchModel() { Id = 95, Name = "DONGFENG+JBC" });
            masterBrands.Add(new WildSearchModel() { Id = 96, Name = "MORGAN" });
            masterBrands.Add(new WildSearchModel() { Id = 97, Name = "GOUPIL" });
            masterBrands.Add(new WildSearchModel() { Id = 98, Name = "BMW" });
            masterBrands.Add(new WildSearchModel() { Id = 99, Name = "KARSAN" });
            masterBrands.Add(new WildSearchModel() { Id = 100, Name = "XINKAI" });
            masterBrands.Add(new WildSearchModel() { Id = 101, Name = "JAGUAR" });

            newBrands = new List<WildSearchModel>();
            newBrands.Add(new WildSearchModel() { Id = 1, Name = "GILY" });
            newBrands.Add(new WildSearchModel() { Id = 2, Name = "MARUTI+KUZUKI" });
            newBrands.Add(new WildSearchModel() { Id = 3, Name = "HYUNDAI+SUZUKI" });
            newBrands.Add(new WildSearchModel() { Id = 10, Name = "HONDA" });
        }


        #endregion
    }
}
