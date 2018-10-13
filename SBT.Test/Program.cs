﻿using System;
using System.Collections.Generic;
using RST.Command;
using RST.Command.Extension;

namespace SBT.Test
{
    class Program
    {
        // Представьте себе некое игровое поле, на котором могут располагаться игровые юниты разных типов: автомобиль(Car), танк(Tank) и забор(Fence).
        // Танк должен уметь двигаться(MoveCommand) и стрелять(FireCommand), машина может только двигаться(MoveCommand), а забор вообще ничего не может делать.
        // Теперь представим ситуацию, что вы мышкой выделили часть игрового поля и в этой выделенной части находилось некоторое колличество юнитов каждого типа.
        // После этого вы хотите отдать всем выделенным юнитам одну и ту же команду(например, двигайтесь(MoveCommand)).
        // По этой команде те юниты, которые могут двигаться(танк и автомобиль), исполняют эту команду, а те, кто не могут(забор) - игнорируют её и ничего не делают.
        // Следует иметь ввиду, что исполнение одной и той же команды может отличаться для разных юнитов и зависеть от их внутреннего состояния.
        // Например, применение одной и той же команды двигаться(MoveCommand), может завставить танк сдвинуться на 3 "клетки" влево, а машину - на 2 "клетки" вверх.

        // Необходимо доработать библиотеку RST.Command по следующим направлениям:
        //  1) Должна быть возможность создать новую команду(например, поворот(RotateCommand)) вне библиотеки RST.Command. Старые юниты не должны поддерживать новую команду.
        //  2) Должна быть возможность создать нового юнита(например, вертолёт), который умеет двигаться(MoveCommand) и вращаться(RotateCommand) вне библиотеки RST.Command.
        //
        // Данные требование аналогичны ситуации, когда другой разработчик берёт вашу библиотеку
        // и пытается расширять её для своих целей не имея возможности модифицировать исходный код вашей библиотеки.

        // Варианты сценариев "Вариант 1" и "Вариант 2" эмулирую выделение и применение команд в группе юнитов.
        // Необходимо реализовать ТОЛЬКО ОДИН из приведённых ниже сценариев на ваше усмотрение.
        // Дорабатывать код можно по своему усмотрению.
        //
        // Требования:
        //  1) Необходимо избегать Reflection там, где это возможно.
        //  2) Использовать DI контейнеры запрещено.
        //  3) Код избранного для реализации варианта("Вариант 1" и "Вариант 2") должен оставаться неизменным.

        static void Main(string[] args)
        {
            // Команды для юнитов
            var commands = new List<ICommand> {new FireCommand(), new MoveCommand(), new RotateCommand()};
            // Юниты
            var units = new List<IUnit> {new Car(), new Tank(), new Fence(), new Helicopter()};

            // //Вариант 1: для каждой команды вызвать её исполнение на каждом юните.
            //foreach (var command in commands)
            //{
            //    foreach (var unit in units)
            //    {
            //        command.Execute(unit)
            //    }
            //}

            //Вариант 2: для каждого юнита вызвать исполнение команды на нём.
            foreach (var unit in units)
            {
                foreach (var command in commands)
                {
                    unit.ExecuteCommand(command);
                }
            }
        }
    }
}
