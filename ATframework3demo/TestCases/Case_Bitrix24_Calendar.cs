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
            caseCollection.Add(new TestCase("�������� ������� ���������", homePage => CreateEvent(homePage)));
            return caseCollection;
        }

        void CreateEvent(PortalHomePage homePage) {
            //������� �� �������� ���������
            homePage
                //������� � ������� ����
                .LeftMenu
                //������� ���������
                .OpenCalendar()
                //������ ������ �������
                .CreateCalendarEvent()
                //������� �� ����������� ������ "������ ����"
                .RepeatEveryDay()
                //������ ������ ���������
                .SaveEvent(); 
        }

    }
}
