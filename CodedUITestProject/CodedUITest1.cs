using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject
{
    /// <summary>
    /// Opis podsumowujący elementu CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void BtnNextTestMethod()
        {

            this.UIMap.btnNextRecordedMethod();
            this.UIMap.AssertbtnNext();
            

            // Aby wygenerować kod dla tego testu, wybierz pozycję „Generuj kod dla kodowanego testu interfejsu użytkownika” z menu skrótów i wybierz jeden z elementów menu.
        }

        [TestMethod]
        public void BtnPreviousTestMethod()
        {

            this.UIMap.btnPreviousRecordedMethod();
            this.UIMap.AssertbtnPrevious();
            // Aby wygenerować kod dla tego testu, wybierz pozycję „Generuj kod dla kodowanego testu interfejsu użytkownika” z menu skrótów i wybierz jeden z elementów menu.
        }

        #region Dodatkowe atrybuty testu

        // Można użyć następujących dodatkowych atrybutów w trakcie pisania testów:

        ////Użyj TestInitialize do uruchomienia kodu przed uruchomieniem każdego testu 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Aby wygenerować kod dla tego testu, wybierz opcję „Generuj kod dla kodowanego testu interfejsu użytkownika” z menu skrótów i wybierz jeden z elementów menu.
        //}

        ////Użyj TestCleanup do uruchomienia kodu po wykonaniu każdego testu
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Aby wygenerować kod dla tego testu, wybierz opcję „Generuj kod dla kodowanego testu interfejsu użytkownika” z menu skrótów i wybierz jeden z elementów menu.
        //}

        #endregion

        /// <summary>
        ///Pobiera lub ustawia kontekst testu, który udostępnia
        ///funkcjonalność i informację o bieżącym przebiegu testu.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
