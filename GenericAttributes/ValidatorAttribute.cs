namespace GenericAttributes
{
    internal class ValidatorAttribute<T> : Attribute where T : IValidator
    {
        public Type ValidatorType { get; private set; }

        public ValidatorAttribute() => ValidatorType = typeof(T);
    }
}
