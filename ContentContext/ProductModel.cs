namespace ContentContext{
    public class ProductModel{
        public ProductModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slugg { get; set; }
    }
}