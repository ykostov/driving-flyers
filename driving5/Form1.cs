using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace driving5
{
    public partial class Form1 : Form
    {

        public int correctAns;
        public int number_questions = 0;
        public int unique_index = 0;
        public bool wasChosen = false;

        public List<int> qList = new List<int>(26);

        public Form1()
        {
            InitializeComponent();
        }


        public void QuestionChooser()
        {

            Random r = new Random();
            public int qnum = r.Next(1, 25);


            if (qList.Contains(qnum)) { wasChosen = true; }
            else
            {
                if (wasChosen == false)
                {
                    if (qnum == 1)
                    {
                        label2.Text = "Правилата за движение в населено място се прилагат:";
                        button6.Text = "по всички участъци от пътя, по които се движат пешеходци";
                        button7.Text = "след знака, с който е обозначено началото на населеното място";
                        button8.Text = "от първата сграда в населеното място";
                        button9.Text = "само, когато гледат полицаи";
                        correctAns = 2;


                        unique_index++;
                        qList.Add(qnum);

                        unique_index++;


                    }
                    else if (qnum == 2)
                    {

                        label2.Text = "Когато светофара свети в жълто и червено значението е:";
                        button6.Text = "Внимание, спри!";
                        button7.Text = "Внимание";
                        button8.Text = "Преминаването е забранено";
                        button9.Text = "Преминаването е разрешено";
                        correctAns = 3;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 3)
                    {

                        label2.Text = "Кой от изброените фактори е с най-голямо значение за определяне на дистанцията при движение зад друго ППС?";
                        button6.Text = "марката на автомобила";
                        button7.Text = "видът на превозвания товар";
                        button8.Text = "състоянието на пътя";
                        button9.Text = "видът на движещото се отпред ППС";
                        correctAns = 3;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 4)
                    {

                        label2.Text = "Когато няма други ограничения, водачите на леки моторни превозни средства с четири колела от категория 'АМ', при движение извън населено място, не трябва да превишават:";
                        button6.Text = "45 км/ч";
                        button7.Text = "50 км/ч";
                        button8.Text = "40 км/ч";
                        button9.Text = "55 км/ч";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 5)
                    {

                        label2.Text = "Как ще постъпите при заслепяване от светлините на насрещно движещо се превозно средство?";
                        button6.Text = "ще сигнализирам със звуков сигнал";
                        button7.Text = "ще го блъсна";
                        button8.Text = "ще намаля скоростта";
                        button9.Text = "ще продължа движението, като включа дългите светлини";
                        correctAns = 3;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 6)
                    {

                        label2.Text = "На водача на МПС със специален режим на движение е забранено:";
                        button6.Text = "да надвишава разрешената максимална скорост на движение";
                        button7.Text = "да не спазва сигналите на регулировчика";
                        button8.Text = "да преминава без да спира, при наличие на пътен знак, който изисква това";
                        button9.Text = "да преминава при забраняващ сигнал на светофара";
                        correctAns = 2;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 7)
                    {

                        label2.Text = "Конструктивната максимална скорост на мотопеда е не по-голяма от:";
                        button6.Text = "50 км/ч";
                        button7.Text = "55 км/ч";
                        button8.Text = "60 км/ч";
                        button9.Text = "45 км/ч";
                        correctAns = 4;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 8)
                    {

                        label2.Text = "При движение на превозното средство в завой, с висока скорост, най-опасно е:";
                        button6.Text = "ускореното износване на окачването";
                        button7.Text = "ускореното износване на кормилната уредба";
                        button8.Text = "ускореното износване на протектора на гумите";
                        button9.Text = "възможното странично хлъзгане на автомобила";
                        correctAns = 4;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 9)
                    {

                        label2.Text = "При изпреварването на кое от изброените ППС, трябва да се осигури по-голяма странична дистанция?";
                        button6.Text = "автомобил";
                        button7.Text = "велосипед";
                        button8.Text = "съчленен автобус";
                        button9.Text = "трактор";
                        correctAns = 2;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 10)
                    {

                        label2.Text = "Какво влияние оказва върху дължината на спирачния път блокирането на колелата при спиране?";
                        button6.Text = "намалява дължината на спирачния път";
                        button7.Text = "не оказва влияние върху дължината на спирачния път";
                        button8.Text = "увеличава дължината на спирачния път";
                        button9.Text = "никакво";
                        correctAns = 3;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 11)
                    {

                        label2.Text = "Когато паркирането върху тротоара е разрешено, разстоянието между превозното средство и сградата трябва да бъде не по-малко от:";
                        button6.Text = " 1,0 м";
                        button7.Text = " 2,0 м";
                        button8.Text = " 0,5 м";
                        button9.Text = " 1,5 м";
                        correctAns = 2;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 12)
                    {

                        label2.Text = "На водача е разрешено да използва дългите светлини при:";
                        button6.Text = "движение по осветени участъци от пътя";
                        button7.Text = "разминаване";
                        button8.Text = "движение зад друго МПС на разстояние, по-малко от 50 м";
                        button9.Text = "намалена видимост";
                        correctAns = 4;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 13)
                    {

                        label2.Text = "На водача на двуколесно превозно средство е разрешено:";
                        button6.Text = "да се движи с включени светлини през деня";
                        button7.Text = "да освобождава педалите, с които контролира превозното средство";
                        button8.Text = "да управлява превозното средство, без да държи кормилото с ръка";
                        button9.Text = "да превозва предмети, които пречат на управлението на превозното средство";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 14)
                    {

                        label2.Text = "Тротоарът е част от:";
                        button6.Text = "платното за движение";
                        button7.Text = "най-дясната пътна лента";
                        button8.Text = "разделителната ивица";
                        button9.Text = "пътното платно";
                        correctAns = 4;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 15)
                    {

                        label2.Text = "Слизането на деца до 12 години от автомобил, спрял на пътното платно, се извършва от:";
                        button6.Text = "страната на водача на МПС";
                        button7.Text = "страната на пътния банкет";
                        button8.Text = "не е разрешено";
                        button9.Text = "от по-удобната на водача страна";
                        correctAns = 2;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 16)
                    {

                        label2.Text = "Преди да намали значително скоростта на движение, водачът на МПС е задължен:";
                        button6.Text = "да напусне платното за движение";
                        button7.Text = "да премине в най-дясната пътна лента";
                        button8.Text = "да сигнализира с десен пътепоказател";
                        button9.Text = "да се убеди, че няма да застраши останалите участници в движението";
                        correctAns = 4;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 17)
                    {

                        label2.Text = "Допълнителна задна светлина за мъгла е разрешено да се използва:";
                        button6.Text = "само когато видимостта е намалена под 50 м";
                        button7.Text = "при движение през нощта";
                        button8.Text = "винаги при намалена видимост";
                        button9.Text = "когато искате да покажете на задния каква кола карате";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 18)
                    {

                        label2.Text = "Разрешено ли е водачите на ППС да се движат в непосредствена близост зад превозните средства със специален режим на движение?";
                        button6.Text = "да, когато няма ограничение на скоростта";
                        button7.Text = "не";
                        button8.Text = "да, във всички случаи";
                        button9.Text = "да, но зависи от ситуацията";
                        correctAns = 2;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 19)
                    {

                        label2.Text = "При несъответствие между сигналите на светофара и пътните знаци относно предимството трябва да се съобразявате:";
                        button6.Text = "със светлинните сигнали";
                        button7.Text = "с предписанията на пътните знаци";
                        button8.Text = "който има по-силна музика";
                        button9.Text = "който кара най-висока кола";
                        correctAns = 1;
                        qList.Add(qnum);

                        unique_index++;

                    }
                    else if (qnum == 20)
                    {

                        label2.Text = "Има ли лекарства, след приемането на които е забранено управлението на МПС?";
                        button6.Text = "да";
                        button7.Text = "не";
                        button8.Text = "да, но ако са наркотици";
                        button9.Text = "да, но ако са с алкохол";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 21)
                    {

                        label2.Text = "Сигналът подаван от водача преди извършването на маневра осигурява ли му предимство?";
                        button6.Text = "да";
                        button7.Text = "не";
                        button8.Text = "да, но ако завие рязко";
                        button9.Text = "винаги, дори и да не дадат другите водачи път";
                        correctAns = 2;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 22)
                    {

                        label2.Text = "При изпреварване се преминава от лявата страна на изпреварваното ППС.";
                        button6.Text = "правилно";
                        button7.Text = "грешно";
                        button8.Text = "правилно, но ако първо надуя клаксона";
                        button9.Text = "правилно, но ако първо присветна с дългите";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 23)
                    {

                        label2.Text = "Кои от изброените пътни превозни средства НЕ са моторни?";
                        button6.Text = "трамваите";
                        button7.Text = "мотопедите";
                        button8.Text = "мотопедите";
                        button9.Text = "автомобилите";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 24)
                    {

                        label2.Text = "Кое е грешното: преди да предприеме маневра водачът трябва да се убеди, че няма да създаде опасност за участниците в движението:";
                        button6.Text = "които преминават покрай него";
                        button7.Text = "които се движат след него";
                        button8.Text = "които се движат пред него";
                        button9.Text = "не е длъжен да се съобразява със сигналите, които подават";
                        correctAns = 4;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 25)
                    {

                        label2.Text = "Зависи ли коефициентът на сцепление на автомобилните гуми с пътя от състоянието на пътната настилка?";
                        button6.Text = "да";
                        button7.Text = "не";
                        button8.Text = "зависи";
                        button9.Text = "ДРУГО";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);

                    }
                    else if (qnum == 26)
                    {

                        label2.Text = "Каква мярка се прилага към водач, който управлява моторно превозно средство без застраховка 'Гражданска отговорност' на автомобилистите - до предоставяне на сключена валидна застраховка?";
                        button6.Text = "временно се отнема свидетелството за управление";
                        button7.Text = "глоба";
                        button8.Text = "прекратява се регистрацията на МПС";
                        button9.Text = "предупреждение";
                        correctAns = 1;

                        unique_index++;
                        qList.Add(qnum);
                    }

             
                        
                
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            QuestionChooser();
        }

    }

}

