namespace DesignPatterns.FactoryMethod_DP.CreatorExample.Creator
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }
    }
}
