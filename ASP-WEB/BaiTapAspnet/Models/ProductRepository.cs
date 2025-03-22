namespace ASP_WEB.Models
{
    public static class ProductRepository
    {
        private static readonly List<Product> Products = new()
        {
            new Product
            {
                ID = 1, 
                Name = "IPHONE 14 Pro Max", 
                Price = 32999000, 
                ImageURL = "/img/iphone-14-pro-max.jpg",
                ShortDescription = "Dòng Apple siêu đắt đỏ nhất thế giới, hiệu năng kém", 
                LongDescription = "Chạy chip Snapdragon 8 Elite",
                Storage = "512GB SSD", 
                Screen = "6.69 inch OLED", 
                Camera = "Triple Camera 24MP",
                Warranty = 12
            },
            new Product
            {
                ID = 2, 
                Name = "IPHONE 15 PRO MAX", 
                Price = 35999000, 
                ImageURL = "/img/iphone-15-pro-max.jpg",
                ShortDescription = "Dòng Apple siêu đắt đỏ nhất thế giới, hiệu năng kém", 
                LongDescription = "Chạy chip Apple A18 Pro",
                Storage = "128GB", 
                Screen = "6.5 inch OLED", 
                Camera = "Triple Camera 64MP",
                Warranty = 24
            },
            new Product
            {
                ID = 3, 
                Name = "IPHONE 15 PRO MAX", 
                Price = 35999000, 
                ImageURL = "/img/iphone-15-pro-max.jpg",
                ShortDescription = "Dòng Apple siêu đắt đỏ nhất thế giới, hiệu năng kém", 
                LongDescription = "Chạy chip Apple A18 Pro",
                Storage = "128GB", 
                Screen = "6.5 inch OLED", 
                Camera = "Triple Camera 64MP",
                Warranty = 24
            },
            new Product
            {
                ID = 4, 
                Name = "Samsung Galaxy S23 Ultra", 
                Price = 37999000, 
                ImageURL = "/img/samsung-s23-ultra.jpg",
                ShortDescription = "Dòng điện thoại flagship của Samsung", 
                LongDescription = "Chạy chip Snapdragon 8 Gen 2",
                Storage = "256GB", 
                Screen = "6.8 inch AMOLED", 
                Camera = "Quad Camera 200MP",
                Warranty = 24
            },
            new Product
            {
                ID = 5, 
                Name = "Google Pixel 8 Pro", 
                Price = 34999000, 
                ImageURL = "/img/google-pixel-8-pro.jpg",
                ShortDescription = "Điện thoại Android cao cấp từ Google", 
                LongDescription = "Chạy chip Google Tensor G3",
                Storage = "128GB", 
                Screen = "6.7 inch OLED", 
                Camera = "Triple Camera 50MP",
                Warranty = 24
            },
            new Product
            {
                ID = 6, 
                Name = "OnePlus 11", 
                Price = 27999000, 
                ImageURL = "/img/oneplus-11.jpg",
                ShortDescription = "Điện thoại cao cấp của OnePlus", 
                LongDescription = "Chạy chip Snapdragon 8 Gen 2",
                Storage = "256GB", 
                Screen = "6.7 inch AMOLED", 
                Camera = "Triple Camera 50MP",
                Warranty = 18
            },
            new Product
            {
                ID = 7, 
                Name = "Xiaomi 13 Pro", 
                Price = 30999000, 
                ImageURL = "/img/xiaomi-13-pro.jpg",
                ShortDescription = "Điện thoại cao cấp từ Xiaomi", 
                LongDescription = "Chạy chip Snapdragon 8 Gen 2",
                Storage = "256GB", 
                Screen = "6.73 inch AMOLED", 
                Camera = "Triple Camera 50MP",
                Warranty = 24
            },
            new Product
            {
                ID = 8, 
                Name = "Sony Xperia 1 IV", 
                Price = 32999000, 
                ImageURL = "/img/sony-xperia-1-iv.jpg",
                ShortDescription = "Điện thoại flagship với khả năng quay video siêu sắc nét", 
                LongDescription = "Chạy chip Snapdragon 8 Gen 1",
                Storage = "256GB", 
                Screen = "6.5 inch OLED", 
                Camera = "Quad Camera 48MP",
                Warranty = 24
            },
            new Product
            {
                ID = 9, 
                Name = "Oppo Find X5 Pro", 
                Price = 34999000, 
                ImageURL = "/img/oppo-find-x5-pro.jpg",
                ShortDescription = "Điện thoại cao cấp từ Oppo", 
                LongDescription = "Chạy chip Snapdragon 8 Gen 1",
                Storage = "256GB", 
                Screen = "6.7 inch AMOLED", 
                Camera = "Triple Camera 50MP",
                Warranty = 24
            },
            new Product
            {
                ID = 10, 
                Name = "Realme GT 2 Pro", 
                Price = 25999000, 
                ImageURL = "/img/realme-gt-2-pro.jpg",
                ShortDescription = "Điện thoại flagship của Realme", 
                LongDescription = "Chạy chip Snapdragon 8 Gen 1",
                Storage = "256GB", 
                Screen = "6.7 inch AMOLED", 
                Camera = "Triple Camera 50MP",
                Warranty = 18
            },
            new Product
            {
                ID = 11, 
                Name = "Huawei Mate 50 Pro", 
                Price = 41999000, 
                ImageURL = "/img/huawei-mate-50-pro.jpg",
                ShortDescription = "Điện thoại flagship của Huawei", 
                LongDescription = "Chạy chip Snapdragon 8 Gen 1",
                Storage = "512GB", 
                Screen = "6.74 inch OLED", 
                Camera = "Quad Camera 50MP",
                Warranty = 24
            },
            new Product
            {
                ID = 12, 
                Name = "Vivo X90 Pro", 
                Price = 35999000, 
                ImageURL = "/img/vivo-x90-pro.jpg",
                ShortDescription = "Điện thoại cao cấp của Vivo", 
                LongDescription = "Chạy chip Dimensity 9200",
                Storage = "256GB", 
                Screen = "6.78 inch AMOLED", 
                Camera = "Triple Camera 50MP",
                Warranty = 24
            }
        };

        public static List<Product> GetProducts()
        {
            return Products;
        }

        public static Product GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.ID == id);
        }
    }
}
