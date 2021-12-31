using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driving5
{
    public partial class Form1 : Form
    {
        int correctAns;
        bool is_submmitted1 = true;

        public Form1()
        {
            InitializeComponent();
            QuestionChooser();
        }

        private void QuestionChooser()
        {
            Random r = new Random();
            int qnum = r.Next(1, 25);

            if (qnum == 1)
            {                

                if (is_submmitted1 == false)
                {
                    label1.Text = "Правилата за движение в населено място се прилагат:";
                    button1.Text = "по всички участъци от пътя, по които се движат пешеходци";
                    button2.Text = "след знака, с който е обозначено началото на населеното място";
                    button3.Text = "от първата сграда в населеното място";
                    button4.Text = "само, когато гледат полицаи";
                    correctAns = 2;

                    is_submmitted1 = true;
                }
            }
            else if (qnum == 2)
            {
                label1.Text = "Когато светофара свети в жълто и червено значението е:";
                button1.Text = "Внимание, спри!";
                button2.Text = "Внимание";
                button3.Text = "Преминаването е забранено";
                button4.Text = "Преминаването е разрешено";
                correctAns = 3;
            }
            else if (qnum == 3)
            {
                label1.Text = "Кой от изброените фактори е с най-голямо значение за определяне на дистанцията при движение зад друго ППС?";
                button1.Text = "марката на автомобила";
                button2.Text = "видът на превозвания товар";
                button3.Text = "състоянието на пътя";
                button4.Text = "видът на движещото се отпред ППС";
                correctAns = 3;
            }
            else if (qnum == 4)
            {
                label1.Text = "Когато няма други ограничения, водачите на леки моторни превозни средства с четири колела от категория 'АМ', при движение извън населено място, не трябва да превишават:";
                button1.Text = "45 км/ч";
                button2.Text = "50 км/ч";
                button3.Text = "40 км/ч";
                button4.Text = "55 км/ч";
                correctAns = 1;
            }
            else if (qnum == 5)
            {
                label1.Text = "Как ще постъпите при заслепяване от светлините на насрещно движещо се превозно средство?";
                button1.Text = "ще сигнализирам със звуков сигнал";
                button2.Text = "ще го блъсна";
                button3.Text = "ще намаля скоростта";
                button4.Text = "ще продължа движението, като включа дългите светлини";
                correctAns = 3;
            }
            else if (qnum == 6)
            {
                label1.Text = "На водача на МПС със специален режим на движение е забранено:";
                button1.Text = "да надвишава разрешената максимална скорост на движение";
                button2.Text = "да не спазва сигналите на регулировчика";
                button3.Text = "да преминава без да спира, при наличие на пътен знак, който изисква това";
                button4.Text = "да преминава при забраняващ сигнал на светофара";
                correctAns = 2;
            }
            else if (qnum == 7)
            {
                label1.Text = "Конструктивната максимална скорост на мотопеда е не по-голяма от:";
                button1.Text = "50 км/ч";
                button2.Text = "55 км/ч";
                button3.Text = "60 км/ч";
                button4.Text = "45 км/ч";
                correctAns = 4;
            }
            else if (qnum == 8)
            {
                label1.Text = "При движение на превозното средство в завой, с висока скорост, най-опасно е:";
                button1.Text = "ускореното износване на окачването";
                button2.Text = "ускореното износване на кормилната уредба";
                button3.Text = "ускореното износване на протектора на гумите";
                button4.Text = "възможното странично хлъзгане на автомобила";
                correctAns = 4;
            }
            else if (qnum == 9)
            {
                label1.Text = "При изпреварването на кое от изброените ППС, трябва да се осигури по-голяма странична дистанция?";
                button1.Text = "автомобил";
                button2.Text = "велосипед";
                button3.Text = "съчленен автобус";
                button4.Text = "трактор";
                correctAns = 2;
            }
            else if (qnum == 10)
            {
                label1.Text = "Какво влияние оказва върху дължината на спирачния път блокирането на колелата при спиране?";
                button1.Text = "намалява дължината на спирачния път";
                button2.Text = "не оказва влияние върху дължината на спирачния път";
                button3.Text = "увеличава дължината на спирачния път";
                button4.Text = "никакво";
                correctAns = 3;
            }
            else if (qnum == 11)
            {
                label1.Text = "Когато паркирането върху тротоара е разрешено, разстоянието между превозното средство и сградата трябва да бъде не по-малко от:";
                button1.Text = " 1,0 м";
                button2.Text = " 2,0 м";
                button3.Text = " 0,5 м";
                button4.Text = " 1,5 м";
                correctAns = 2;
            }
            else if (qnum == 12)
            {
                label1.Text = "На водача е разрешено да използва дългите светлини при:";
                button1.Text = "движение по осветени участъци от пътя";
                button2.Text = "разминаване";
                button3.Text = "движение зад друго МПС на разстояние, по-малко от 50 м";
                button4.Text = "намалена видимост";
                correctAns = 4;
            }
            else if (qnum == 13)
            {
                label1.Text = "На водача на двуколесно превозно средство е разрешено:";
                button1.Text = "да се движи с включени светлини през деня";
                button2.Text = "да освобождава педалите, с които контролира превозното средство";
                button3.Text = "да управлява превозното средство, без да държи кормилото с ръка";
                button4.Text = "да превозва предмети, които пречат на управлението на превозното средство";
                correctAns = 1;
            }
            else if (qnum == 14)
            {
                label1.Text = "Тротоарът е част от:";
                button1.Text = "платното за движение";
                button2.Text = "най-дясната пътна лента";
                button3.Text = "разделителната ивица";
                button4.Text = "пътното платно";
                correctAns = 4;
            }
            else if (qnum == 15)
            {
                label1.Text = "Слизането на деца до 12 години от автомобил, спрял на пътното платно, се извършва от:";
                button1.Text = "страната на водача на МПС";
                button2.Text = "страната на пътния банкет";
                button3.Text = "не е разрешено";
                button4.Text = "от по-удобната на водача страна";
                correctAns = 2;
            }
            else if (qnum == 16)
            {
                label1.Text = "Преди да намали значително скоростта на движение, водачът на МПС е задължен:";
                button1.Text = "да напусне платното за движение";
                button2.Text = "да премине в най-дясната пътна лента";
                button3.Text = "да сигнализира с десен пътепоказател";
                button4.Text = "да се убеди, че няма да застраши останалите участници в движението";
                correctAns = 4;
            }
            else if (qnum == 17)
            {
                label1.Text = "Допълнителна задна светлина за мъгла е разрешено да се използва:";
                button1.Text = "само когато видимостта е намалена под 50 м";
                button2.Text = "при движение през нощта";
                button3.Text = "винаги при намалена видимост";
                button4.Text = "когато искате да покажете на задния каква кола карате";
                correctAns = 1;
            }
            else if (qnum == 18)
            {
                label1.Text = "Разрешено ли е водачите на ППС да се движат в непосредствена близост зад превозните средства със специален режим на движение?";
                button1.Text = "да, когато няма ограничение на скоростта";
                button2.Text = "не";
                button3.Text = "да, във всички случаи";
                button4.Text = "да, но зависи от ситуацията";
                correctAns = 2;
            }
            else if (qnum == 19)
            {
                label1.Text = "При несъответствие между сигналите на светофара и пътните знаци относно предимството трябва да се съобразявате:";
                button1.Text = "със светлинните сигнали";
                button2.Text = "с предписанията на пътните знаци";
                button3.Text = "който има по-силна музика";
                button4.Text = "който кара най-висока кола";
                correctAns = 1;
            }
            else if (qnum == 20)
            {
                label1.Text = "Има ли лекарства, след приемането на които е забранено управлението на МПС?";
                button1.Text = "да";
                button2.Text = "не";
                button3.Text = "да, но ако са наркотици";
                button4.Text = "да, но ако са с алкохол";
                correctAns = 1;
            }
            else if (qnum == 21)
            {
                label1.Text = "Сигналът подаван от водача преди извършването на маневра осигурява ли му предимство?";
                button1.Text = "да";
                button2.Text = "не";
                button3.Text = "да, но ако завие рязко";
                button4.Text = "винаги, дори и да не дадат другите водачи път";
                correctAns = 2;
            }
            else if (qnum == 22)
            {
                label1.Text = "При изпреварване се преминава от лявата страна на изпреварваното ППС.";
                button1.Text = "правилно";
                button2.Text = "грешно";
                button3.Text = "правилно, но ако първо надуя клаксона";
                button4.Text = "правилно, но ако първо присветна с дългите";
                correctAns = 1;
            }
            else if (qnum == 23)
            {
                label1.Text = "Кои от изброените пътни превозни средства НЕ са моторни?";
                button1.Text = "трамваите";
                button2.Text = "мотопедите";
                button3.Text = "мотопедите";
                button4.Text = "автомобилите";
                correctAns = 1;
            }
            else if (qnum == 24)
            {
                label1.Text = "Кое е грешното: преди да предприеме маневра водачът трябва да се убеди, че няма да създаде опасност за участниците в движението:";
                button1.Text = "които преминават покрай него";
                button2.Text = "които се движат след него";
                button3.Text = "които се движат пред него";
                button4.Text = "не е длъжен да се съобразява със сигналите, които подават";
                correctAns = 4;
            }
            else if (qnum == 25)
            {
                label1.Text = "Зависи ли коефициентът на сцепление на автомобилните гуми с пътя от състоянието на пътната настилка?";
                button1.Text = "да";
                button2.Text = "не";
                button3.Text = "зависи";
                button4.Text = "ДРУГО";
                correctAns = 1;
            }
            else if (qnum == 26)
            {
                label1.Text = "Каква мярка се прилага към водач, който управлява моторно превозно средство без застраховка 'Гражданска отговорност' на автомобилистите - до предоставяне на сключена валидна застраховка?";
                button1.Text = "временно се отнема свидетелството за управление";
                button2.Text = "глоба";
                button3.Text = "прекратява се регистрацията на МПС";
                button4.Text = "предупреждение";
                correctAns = 1;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1111";
        }
    }
}
