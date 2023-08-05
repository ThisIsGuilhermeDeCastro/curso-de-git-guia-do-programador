using Store.Base;

namespace ContentContext.Product{
    public class Product : Base{
        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePostProduct { get; set; }
    }
}