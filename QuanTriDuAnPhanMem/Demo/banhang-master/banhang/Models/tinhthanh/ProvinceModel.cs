namespace banhang.Models.tinhthanh
{
    public class ProvinceModel
    {
        public class Ward
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class District
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public List<Ward> Wards { get; set; }
        }

        public class Province
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public List<District> Districts { get; set; }
        }

    }
}
