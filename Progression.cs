namespace pr4._7
{
    abstract class Progression
    {
        //первый член прогрессии
        protected int a0;
        //Возвращает kый элемент
        abstract public double GetElement(int k);
    }
}
