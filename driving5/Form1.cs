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
                label1.Text = "Правилата за движение в населено място се прилагат:";
                button1.Text = "по всички участъци от пътя, по които се движат пешеходци";
                button2.Text = "след знака, с който е обозначено началото на населеното място";
                button3.Text = "от първата сграда в населеното място";
                button4.Text = "само, когато гледат полицаи";
                correctAns = 2;
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
                button4.Text = "видът на движещото се отпред ППС";ю
                correctAns = 3;
            }
            else if (qnum == 4)
            {
                label1.Text = "Когато няма други ограничения, водачите на леки моторни превозни средства с четири колела от категория "АМ", при движение извън населено място, не трябва да превишават:";
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
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 16)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 17)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 18)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 19)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 20)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 21)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 22)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 23)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 24)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 25)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
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
