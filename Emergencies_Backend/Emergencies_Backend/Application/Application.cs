
namespace Application
{
    public class Application
    {
        private readonly BeanFactory _beanFactory;

        public Application()
        {
            _beanFactory = new BeanFactory();
            InitializeBeans();
        }

        private void InitializeBeans()
        {
            
            //Регистрирование зависимостей
        }

        public void Run()
        {
            // Запуск приложения
        }
    }
}
