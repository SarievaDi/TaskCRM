using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JusanTaskCRM
{
    class Program
    {
        //Реализация 305-372 строки, 1-2 пункты
        //1.	Организовать запись и чтение коллекции данных классов в/из файл(а). 
        //2.	Организовать обработку некорректного формата входного файла.

        //Реализация класс Individual и Program, строки 27-30, 270-275 соответсвеноо
        //3.	Сделать вывод списка физ лиц.Упорядочить список физ.лиц по Фамилии, Имени, Отчеству.

        // Основная реализация класс Entity, строка 17
        //4.	Юр.лица могут иметь список контактных лиц, которые являются физ.лицами.

        //Реализация класс Program строки 279-299
        //5.	Сделать вывод 5 записей из списка юр. лиц.Упорядочить список юр.лиц по количеству контактных лиц (по убыванию).          

        static void Main(string[] args)
        {
            // Инициализируем объекты значениями
           
            Individual individual1 = new Individual(
                1,
                "Степанов",
                "Григорий",
                "Егорович",
                "990331067090",
                "Роман",
                "Лев",
                new DateTime(2021, 09, 19),
                DateTime.Today
                );

            Individual individual2 = new Individual(
                2,
                "Тимуров",
                "Ярослав",
                "Леонидович",
                "650908700805",
                "Лев",
                "Егор",
                new DateTime(2022, 01, 19),
                DateTime.Today
                );
            Individual individual3 = new Individual(
                3,
                "Романов",
                "Павел",
                "Иванович",
                "860526009556",
                "Давид",
                "Давид",
                new DateTime(2022, 02, 24),
                DateTime.Today
                );
            Individual individual4 = new Individual(
                4,
                "Давидова",
                "Марина",
                "Фёдоровна",
                "830806890700",
                "Артур",
                "Артур",
                new DateTime(2022, 02, 16),
                DateTime.Today
                );
            Individual individual5 = new Individual(
                5,
                "Каримова",
                "Диана",
                "Айбаровна",
                "990806890700",
                "Андрей",
                "Артур",
                new DateTime(2022, 02, 17),
                DateTime.Today
                );
            Individual individual6 = new Individual(
                6,
                "Салимов",
                "Самат",
                "Батырович",
                "000809890300",
                "Артур",
                "Артур",
                new DateTime(2022, 02, 27),
                DateTime.Today
                );
            Individual individual7 = new Individual(
                7,
                "Исмаилова",
                "Анар",
                "Амангелдиевна",
                "890526890702",
                "Максим",
                "Артур",
                new DateTime(2022, 02, 09),
                DateTime.Today
                );
            Individual individual8 = new Individual(
                8,
                "Мадиярова",
                "Самал",
                "Артуровна",
                "950722890500",
                "Егор",
                "Артур",
                new DateTime(2022, 02, 02),
                DateTime.Today
                );
            Individual individual9 = new Individual(
                9,
                "Сергеева",
                "Наталья",
                "Ивановна",
                "770816890650",
                "Марк",
                "Артур",
                new DateTime(2022, 02, 19),
                DateTime.Today
                );
            Individual individual10 = new Individual(
                10,
                "Тимурова",
                "Саида",
                "Диасовна",
                "910426890700",
                "Лев",
                "Артур",
                new DateTime(2022, 01, 16),
                DateTime.Today
                );
            Individual individual11 = new Individual(
                11,
                "Саматов",
                "Жайдар",
                "Берикович",
                "971129780390",
                "Артем",
                "Егор",
                new DateTime(2022, 03, 03),
                DateTime.Today
                );


            Entity entity1 = new Entity(
               1,
               "ИП Весна",
               "г. Алматы, ул. Абая, д.45",
               "Максимов",
               "Артем",
               "Давидович",
               "358423278654",
               "Максим",
               "Максим",
               new DateTime(2019, 12, 10),
               DateTime.Today,
               new List<Individual> {individual6, individual8}
               );

            Entity entity2 = new Entity(
                2,
                "ТОО Мир",
                "г. Алматы, ул. Назарбаева, д.33",
                "Иванов",
                "Антон",
                "Викторович",
                "780423978654",
                "Артур",
                "Артем",
                new DateTime(2021, 11, 02),
                DateTime.Today,
                new List<Individual> { individual9 }
                );

            Entity entity3 = new Entity(
                3,
                "ИП Damu",
                "г. Алматы, ул. Жарокова, д.51",
                "Романов",
                "Илья",
                "Михаилович",
                "104007378654",
                "Антон",
                "Антон",
                new DateTime(2022, 03, 01),
                DateTime.Today,
                new List<Individual> { individual1, individual10, individual11, individual7 }
                );

            Entity entity4 = new Entity(
                4,
                "ТОО RiseGroup",
                "г. Алматы, ул. Сатпаева, д.19",
                "Марков",
                "Руслан",
                "Степанович",
                "978654003026",
                "Марк",
                "Антон",
                new DateTime(2022, 02, 13),
                DateTime.Today,
                new List<Individual> { individual2, individual5 }
                );
            Entity entity5 = new Entity(
                5,
                "ТОО OilKaz",
                "г. Алматы, ул. Муканова, д.70",
                "Алмасов",
                "Руслан",
                "Магамедович",
                "400354003026",
                "Марина",
                "Андрей",
                new DateTime(2022, 02, 10),
                DateTime.Today,
                new List<Individual> { individual4 }
                );
            Entity entity6 = new Entity(
                6,
                "ТОО OceanGroup",
                "г. Алматы, ул. Абая, д.55",
                "Маратов",
                "Тимур",
                "Арманович",
                "483540030260",
                "Андрей",
                "Максим",
                new DateTime(2022, 02, 13),
                DateTime.Today,
                new List<Individual> { individual3 }
                );



            // С помощью up cast приводим объекты к общему типу

            Entity[] entities = new Entity[] {
                entity1,
                entity2,
                entity3,
                entity4,
                entity5,
                entity6
            };
            Individual[] individuals = new Individual[] {
                individual1,
                individual2,
                individual3,
                individual4,
                individual5,
                individual6,
                individual7,
                individual8,
                individual9,
                individual10,
                individual11
            };

            
            

            Console.WriteLine("Список всех физ. лиц: ");
            for (int i = 0; i < individuals.Length; i++)
            {
                string fullname = individuals[i].GetFullNameIndividual();
                Console.WriteLine(fullname);
            }

            Console.WriteLine();

            //создаем массив чисел по количеству контактных физ. лиц
            int[] a = new int[entities.Length];
            for (int i = 0; i < entities.Length; i++){
                a[i] = entities[i].individualContact.Count;
            }

            //Сортируем по убыванию
            Console.WriteLine("Генеральный директор: ");
            var orderedEntities = a.OrderByDescending(n => n);
            foreach (int c in orderedEntities)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[j] == c)
                    {
                        a[j] = 0;
                        Console.WriteLine(entities[j].JuridicalPersonLastName + '\t' + entities[j].JuridicalPersonFirstName + '\t' + entities[j].JuridicalPersonMiddlName);
                        Console.WriteLine("Количество контактных физ. лиц: "+c);
                    }
                }
            }

            Console.WriteLine();


            // Записываем коллекцию в файл и читаем из нее  
            string readPath = @"C:\FFiles\8789\write2.txt";
            string writePath = @"C:\FFiles\8789\write2.txt";
            string text = "";


            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                {
                    for (int i = 0; i < individuals.Length; i++)
                    {

                        DateTime create = (DateTime)individuals[i].DateCreate;
                        DateTime edit = (DateTime)individuals[i].DateEdit;

                        sw.WriteLine("ID физ. лица: "+ individuals[i].ID);
                        sw.WriteLine("Фамилия: "+ individuals[i].IndividualLastName);
                        sw.WriteLine("Имя: "+ individuals[i].IndividualFirstName);
                        sw.WriteLine("Отчество: "+ individuals[i].IndividualMiddleName);
                        sw.WriteLine("ИИН: "+ individuals[i].BIN_IIN);
                        sw.WriteLine("Автор создания: "+ individuals[i].nameCreator);
                        sw.WriteLine("Дата создания: " + create.ToShortDateString());
                        sw.WriteLine("Автор изменения: "+ individuals[i].nameEditor);
                        sw.WriteLine("Дата изменения: "+ edit.ToShortDateString() + '\n');
                        
                    }

                   

                    for (int i = 0; i < entities.Length; i++)
                    {
                      
                        DateTime create = (DateTime)entities[i].DateCreate;
                        DateTime edit = (DateTime)entities[i].DateEdit;

                        sw.WriteLine("ID юр. лица: " + entities[i].ID);
                        sw.WriteLine("Наименование организации: " + entities[i].OragnizationName);
                        sw.WriteLine("Юридический адрес: " + entities[i].OragnizationAddress);
                        sw.WriteLine("Генеральный директор: ");
                        sw.WriteLine("Фамилия: "+ entities[i].JuridicalPersonLastName);
                        sw.WriteLine("Имя: " + entities[i].JuridicalPersonFirstName);
                        sw.WriteLine("Отчество: " + entities[i].JuridicalPersonMiddlName);
                        sw.WriteLine("БИН: " + entities[i].BIN_IIN);
                        sw.WriteLine("Автор создания: "+ entities[i].nameCreator);
                        sw.WriteLine("Дата создания: " + create.ToShortDateString());
                        sw.WriteLine("Автор изменения: " + entities[i].nameEditor);
                        sw.WriteLine("Дата изменения: " + edit.ToShortDateString() + '\n');
                        Console.WriteLine();
                    }
                }
                using (StreamReader sr = new StreamReader(readPath, Encoding.Default))
                {
                    text = sr.ReadToEnd();
                    Console.WriteLine("Данные из файла\n" + text);
                }

            }
            catch
            {
                Console.WriteLine("Неверный формат файла");
                //throw new Exception("Неверный формат файла");
            }
            Console.ReadKey();
        }
    }
}
