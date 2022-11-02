﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DCEUI.classes;

namespace DCEUI.Tests
{
    [TestClass()]
    public class Menu_ItemTests
    {
        Menu_Item menu_Item = new Menu_Item();

        [TestMethod()]
        public void Menu_ItemTest()
        {
            menu_Item.id = 01;
            menu_Item.name = "Delete All(containers, images, volumes)";
            menu_Item.docker_instructions = new List<string> { "get_all_docker_containers" };
            menu_Item.commandlinehandler_instructions = new List<string> { "delete_all_data_from_docker" };

            Assert.IsNotNull(menu_Item.id);
            Assert.IsNotNull(menu_Item.name);
            Assert.IsNotNull(menu_Item.docker_instructions);
            Assert.IsNotNull(menu_Item.commandlinehandler_instructions);
        }
    }
}