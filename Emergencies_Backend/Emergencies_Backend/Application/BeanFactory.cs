namespace Application
{
    public class BeanFactory
    {
        private readonly Dictionary<string, object> _beans = new Dictionary<string, object>();

        public void RegisterBean(string beanName, object beanInstance)
        {
            _beans[beanName] = beanInstance;
        }

        public object GetBean(string beanName)
        {
            if (_beans.ContainsKey(beanName))
            {
                return _beans[beanName];
            }
            throw new Exception($"Bean {beanName} not found");
        }
    }
}
