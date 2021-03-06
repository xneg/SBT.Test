# SBT.Test
### Комментарий по решению задачи:
Я очень долго пытался понять по условию, что от меня требуется. Я до сих пор не понимаю, как это можно сделать через Reflection и DI, которые использовать нельзя.
На мой взгляд два способа, через ```command.Execute(unit)``` и через ```unit.ExecuteCommand(command)```, неравнозначны.
Неравнозначны они из-за двух условий:
1) Должна быть возможность создать новую команду(например, поворот(RotateCommand)) вне библиотеки RST.Command. Старые юниты не должны поддерживать новую команду.
2) Должна быть возможность создать нового юнита(например, вертолёт), который умеет двигаться(MoveCommand) и вращаться(RotateCommand) вне библиотеки RST.Command.

То есть, получается, что команды, объявленные ранее, расширяемы, в то время, как юниты, объявленные ранее, не расширяемы. 

Сперва сделал вторым способом, "в лоб". Просто потому что это с точки зрения домена более логично - юнит выполняет команду. Фактически в этом случае получается, что ```ICommand``` выступает в роли такого расширяемого ```enum```, а уже сами юниты, получая этот ```enum``` что-то там решают.
Решение формально полностью удовлетворяет требованиям - не используются ни Reflection, ни DI, существующая библиотека не изменяется. Это решение в ветке ```master```. Но у меня всё это заняло от силы минут 15, тогда как вроде бы говорилось о том, что задача на пару часов.

Тогда я решил посмотреть первый способ, через ```command.Execute(unit)```. В этом случае, получается, что юнит должен предоставлять некое состояние, а уже команда управляет этим состоянием. Тут задача оказалась интереснее (как раз из-за того, что объявленные ранее команды должны быть расширяемы на новые юниты) и я реализовал её через паттерн Visitor.
Решение можно посмотреть в ветке ```command_approach```.

Повторюсь, по моим ощущениям, задаче не хватает уточнения, чтобы понять, что конкретно мне требуется сделать и какие навыки проверяются. 
> Следует иметь ввиду, что исполнение одной и той же команды может отличаться для разных юнитов и зависеть от их внутреннего состояния.

Вот это условие оно не проливает свет никак - должна быть логика команды инкапсулирована в юните или юнит только предоставляет своё состояние, но при этом должен быть свободен от логики команд - вот это непонятно.
