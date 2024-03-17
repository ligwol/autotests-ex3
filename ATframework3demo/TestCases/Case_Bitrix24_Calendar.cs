using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_Calendar : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Создание события календаря", homePage => CreateEvent(homePage)));
            return caseCollection;
        }

        void CreateEvent(PortalHomePage homePage) {
            //Переход на страницу календаря
            homePage
                //Перейти в боковое меню
                .LeftMenu
                //Открыть календарь
                .OpenCalendar()
                //Нажать кнопку Создать
                .CreateCalendarEvent()
                //Выбрать из выпадающего списка "Каждый день"
                .RepeatEveryDay()
                //Нажать кнопку Сохранить
                .SaveEvent(); 
        }

    }
}
