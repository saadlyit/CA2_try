using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_CA2_Assignment;
using System.Collections.Generic;

namespace Testing
{//==========================Test For Breakdown Info=========================================
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Breakdown_add_Test()
        {
            Breakdown_Maintenance b = new Breakdown_Maintenance();// create obj b
            bool acutal = b.savevalues("4", "test", "test", "test", "test", "test");//This is the text i m updating in database
            bool expected = true;//returned bool value from method savevalues method
            Assert.AreEqual(expected, acutal, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Breakdown_Updatevalues_Test()
        {
            Breakdown_Maintenance b = new Breakdown_Maintenance();// create obj b
            bool acutal = b.updatevalues("4", "test", "test", "test", "test", "test");//enter all right values in updatevalue method.
            bool expected = true;//returned bool value from method updatevalues method
            Assert.AreEqual(expected, acutal, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Breakdown_Delete_Test()
        {
            Breakdown_Maintenance b = new Breakdown_Maintenance();// create obj b
            bool actual = b.deletevalues("4");//enter all right values in deletevalue method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual should match
        }
        [TestMethod]
        public void Breakdown_view_Test()
        {
            Breakdown_Maintenance b = new Breakdown_Maintenance();// create obj b
            bool actual = b.view("btnclick");//enter all right values in btnclick method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Breakdown_view_Testfail()
        {
            Breakdown_Maintenance b = new Breakdown_Maintenance();// create obj b
            bool actual = b.view("");//enter all wrong values in deletevalue method.
            bool expected = false;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        //==========================Test For Component info=========================================
        [TestMethod]
        public void component_Update_Test()
        {
            Component_info c = new Component_info();// create obj c
            bool actual = c.updatevalues("4", "test", "test", "test", "test");//enter all right values in updatevalue method.
            bool expected = true;//returned bool value from method updatevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Component_save_Test()
        {
            Component_info c = new Component_info();// create obj c
            bool acutal = c.savevalue("test", "test", "test", "test", "test");//enter all right values in savevalue method.
            bool expected = true;//returned bool value from method savevalues method
            Assert.AreEqual(expected, acutal, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void component_Delete_Test()
        {
            Component_info c = new Component_info();// create obj c
            bool actual = c.deletevalue("");//enter all right values in deletevalue method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual should match
        }
        [TestMethod]
        public void component_Breakdown_view_Test()
        {
            Component_info c = new Component_info();// create obj c
            bool actual = c.view("btnclick");//enter all right values in view method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual should match
        }
        [TestMethod]
        public void Component_view_Testfail()
        {
            Component_info c = new Component_info();// create obj c
            bool actual = c.view("");//enter all right values in view method.
            bool expected = false;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is false  whereas actual should match
        }

        //==========================Test For Maintenance services=========================================
        [TestMethod]
        public void Qualified_employees_Update_Test()
        {
            Qualified_employees q = new Qualified_employees();// create obj q
            bool actual = q.Updatevalue("4", "test", "test", "test", "test", "test");//enter all right values in updatevalue method.
            bool expected = true;//returned bool value from method Updatevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual should match
        }
        [TestMethod]
        public void Qualified_employees_save_Test()
        {
            Qualified_employees q = new Qualified_employees();// create obj q
            bool actual = q.savevalue("5", "test", "test", "test", "test", "test");//enter all right values in savevalue method.
            bool expected = true;//returned bool value from method savevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Qualified_employees_delete_Test()
        {
            Qualified_employees q = new Qualified_employees();// create obj q
            bool actual = q.deletevalue("5");//enter all right values in deletevalue method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Maintenance_update_Test()
        {
            Qualified_employees maintenance = new Qualified_employees();// create obj maintenance
            bool actual = maintenance.updatemain_value("4", "test", "test", "test", "test", "test");//enter all right values in updatemain_value method.
            bool expected = true;//returned bool value from method updatemain_values method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Maintenance_save_Test()
        {
            Qualified_employees maintenance = new Qualified_employees();// create obj maintenance
            bool actual = maintenance.savemain_value("5", "test", "test", "test", "test", "test");//enter all right values in savemain_value method.
            bool expected = true;//returned bool value from method savemain_alues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Maintenance_delete_Test()
        {
            Qualified_employees maintenance = new Qualified_employees();// create obj maintenance
            bool actual = maintenance.deletemain_value("5");//enter all right values in deletemain_value method.
            bool expected = true;//returned bool value from method deltemain_values method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Maintain_searchvaluefor_qualified_Test()
        {
            Qualified_employees m = new Qualified_employees();//declare obj m
            bool actual = m.search_value("Names of qualified employees");//enter all right values in search_value method.
            bool expected = true;//returned bool value from method search_value method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Maintain_searchvaluefor_Maintaincompany_Test()
        {
            Qualified_employees m = new Qualified_employees();//declare obj m
            bool actual = m.search_value("Name of maintenance Company");//enter all right values in search_value method.
            bool expected = true;//returned bool value from method search_value method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void qualified_view_Test()
        {
            Qualified_employees c = new Qualified_employees();// create obj ad
            bool actual = c.Qview("btnclick");//enter all right values in deletevalue method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Miantain_view_Testfail()
        {
            Qualified_employees c = new Qualified_employees();// create obj ad
            bool actual = c.main_view("");//enter all right values in deletevalue method.
            bool expected = false;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }

        //==========================Test For Mostservices by a company=========================================
        [TestMethod]
        public void Mostservices_updatevalue_Test()
        {
            Most_services_company m = new Most_services_company();//declare obj m
            bool actual = m.updatevalues("5", "test", "test", "test", "test");//enter all update values in updatevalues method.
            bool expected = true;//returned bool value from method updatevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Mostservices_savevalue_Test()
        {
            Most_services_company m = new Most_services_company();//Created obj m
            bool actual = m.savevalues("5", "testsave", "test", "test", "test");//enter all save values in register method.
            bool expected = true;//returned bool value from method savevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Mostservices_deletevalue_Test()
        {
            Most_services_company m = new Most_services_company();// expected is true  whereas actual is should match
            bool actual = m.deletevalues("5");//enter all right values in delete value method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Mostservices_view_Test()
        {
            Most_services_company c = new Most_services_company();// create obj ad
            bool actual = c.view("btnclick");//enter all right values in deletevalue method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Mostservices_view_failTest()
        {
            Most_services_company c = new Most_services_company();// create obj ad
            bool actual = c.view("");//enter all right values in deletevalue method.
            bool expected = false;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is false  whereas actual is should match
        }
        //==========================Test ForShutdown maintenance=========================================
        [TestMethod]
        public void Shutdown_update_Test()
        {
            Shutdown_Maintenance c = new Shutdown_Maintenance();// create obj ad
            bool actual = c.updatevalues("7", "testsh", "testsh", "testsh", "testsh", "tessh");//enter all right values in updatevalue method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is false  whereas actual is should match
        }

        [TestMethod]
        public void Shutdown_save_Test()
        {
            Shutdown_Maintenance c = new Shutdown_Maintenance();// create obj ad
            bool actual = c.savevalues("7", "testsh", "testsh", "testsh", "testsh", "tessh");//enter all right values in savevalue method.
            bool expected = true;//returned bool value from method save  method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is false  whereas actual is should match
        }
        [TestMethod]
        public void Shutdown_delete_Test()
        {
            Shutdown_Maintenance c = new Shutdown_Maintenance();// create obj ad
            bool actual = c.deletevalues("7");//enter all right values in deletevalue method.
            bool expected = true;//returned bool value from method delete  method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is false  whereas actual is should match
        }
        [TestMethod]
        public void shutdown_view_Test()
        {
            Shutdown_Maintenance c = new Shutdown_Maintenance();// create obj c
            bool actual = c.view("btnclick");//enter all right values in deletevalue method.
            bool expected = true;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void shutdown_view_failTest()
        {
            Most_services_company c = new Most_services_company();// create obj ad
            bool actual = c.view("");//enter all right values in deletevalue method.
            bool expected = false;//returned bool value from method deltevalues method
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is false  whereas actual is should match
        }
        //==========================Test For Register=========================================
        [TestMethod]
        public void Register_vlaue_test()
        {
            Register m = new Register(); //declare obj m
            bool actual = m.register("55", "Testr", "testr", "testr", "testr", "2");//enter all right values in register method.
            bool expected = true; //returned bool value from method register method
            Assert.AreEqual(expected, actual, "You did something wrong"); // expected is true  whereas actual should match
        }
        //==========================Test For Login_page=========================================
        [TestMethod]// Test Method for successfull Login
        public void login_vlaue_test()
        {
            MainWindow main = new MainWindow(); //declare obj main
            bool actual = main.Login_pagess("shah", "shah");// enter valid username and password
            bool expected = true; ////returned bool value from method login_pagess method 
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]// ====Test Method for unsuccessfull Login
        public void login_vlaue_unsuccesstest()
        {
            MainWindow main = new MainWindow();// create obj main
            bool actual = main.Login_pagess("1", "676");//enter invalid password
            bool expected = false;//returned bool value from method login_pagess method 
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        //==========================Test For Admin Dashboard=========================================
        [TestMethod]
        public void Admin_Update_test()
        {
            Admin_dashboard ad = new Admin_dashboard();// create obj ad
            bool actual = ad.update_value("66", "testad", "testad", "testad", "testad", "1");//enter valid values in database
            bool expected = true;//returned bool value from method login_pagess method 
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Admin_Save_test()
        {
            Admin_dashboard ad = new Admin_dashboard();// create obj ad
            bool actual = ad.save_value("66", "testad", "testad", "testad", "testad", "1");//enter valid values in database
            bool expected = true;//returned bool value from method save_value method 
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]
        public void Admin_delete_test()
        {
            Admin_dashboard ad = new Admin_dashboard(); // create obj ad
            bool actual = ad.delete_value("66");//enter valid values in database to delete
            bool expected = true;//returned bool value from method delete_value method 
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]// Test Method for successfull Login
        public void Admin_View_test()
        {
            Admin_dashboard main = new Admin_dashboard(); //declare obj main
            bool actual = main.view("btnclick");// enter valid username and password
            bool expected = true; ////returned bool value from method login_pagess method 
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
        [TestMethod]// ====Test Method for unsuccessfull Login
        public void Admin_View_unsuccesstest()
        {
            Admin_dashboard main = new Admin_dashboard();// create obj main
            bool actual = main.view("");//enter invalid password
            bool expected = false;//returned bool value from method login_pagess method 
            Assert.AreEqual(expected, actual, "You did something wrong");// expected is true  whereas actual is should match
        }
    }
}