﻿//библиотеки
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//что я добавил
using System.IO;//для управлениями файлами и папрк
using System.Threading;//для паузы
using System.Diagnostics;//процессы
using Microsoft.Win32;//для реестра

 
namespace Cclearpro
{

    public partial class main : Form
    {
        login f1;// 1 форма то есть авторизация


        //Time

        int c;//секунды
        int z;//минуты
        int x;//Часы

        int i;//для счёта процессов
 
        public main()
        {
            InitializeComponent();

  

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;//загружаем инфо иконку
            notifyIcon1.BalloonTipText = "Я буду здесь чтобы вы могли быстро открыть программу";//текст подсказки
            notifyIcon1.BalloonTipTitle = "Информация";//название подсказки
            notifyIcon1.ShowBalloonTip(5);//сколько она будет весеть
            this.ShowInTaskbar = false;
            notifyIcon1.Click += notifyIcon1_Click;

            //прочее

            if (Data.path == "")
            {
                pictureBox3.Visible = false;
                label10.Visible = false;
            }
        }

        void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        //кнопочки
        private void btcloses_Click(object sender, EventArgs e) 
        {
            if (Data.closeself == true)
            {
                DialogResult wat = MessageBox.Show("Вы уверены закрыть программу?", "Clearpro ПМ01", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (wat == DialogResult.Yes)
                {
                    Application.Exit();
                    if (Data.nameform == false) 
                    {
                        f1 = new login();
                        f1.Close();
                    }
                }
                
            }
            else if (Data.closeself == false)
            {
                Application.Exit();
            }
        }

        private void btminis_Click(object sender, EventArgs e)//чтобы скрыть
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Анимации

        //для закрытия
        private void btcloses_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btcloses_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
        }

        //для скрытия формы

        private void btminis_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btminis_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
        }

     
        private void main_Load(object sender, EventArgs e)
        {

            //Проверка имени

            if (Data.name == "")
            {
                MessageBox.Show("Error: Нет имени", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f1 = new login();
                f1.Show();
                this.Close();
            }
            else if (Data.name != "")
            {
                label1.Text = label1.Text + Data.name;
                radioButton2.Checked = true;  
            }

            

            //чтобы убить процесс (для старого режима)

            Data.proces = Process.GetProcesses();

            comboBox2.Items.Clear();

            foreach (Process name in Data.proces)
            {
                comboBox2.Items.Add(name.ProcessName);
            }

            //новый режим

            Process[] p = Process.GetProcesses();

            listBox2.Items.Clear();

            foreach (Process name in Data.proces)
            {
                listBox2.Items.Add(name.ProcessName);
            }

            label9.Text = "Всего процессов: " + p.Length;

            //для реестра

         

       

            //для загрузки аватарки

            try
            {
                pictureBox3.Image = new Bitmap(Data.path);
            }
            catch {

            }
        }

        //таймеры

        //чтобы понять сколько времени работает программа

        private void time_Tick(object sender, EventArgs e)
        {

            //время

            c++;
            if (c == 60)
            {
                z++;
                c = 0;
            }
            if (z == 60)
            {
                x++;
                z = 0;
            }
            label4.Text = "Время работы программы: ";
            label4.Text = Convert.ToString(label4.Text + c + ":" + z + ":" + x);

            //процессы

            //старый режим

            Data.proces = Process.GetProcesses();

            if (Data.proces.Length != i)
            {
                comboBox2.Items.Clear();

                foreach (Process name in Data.proces)
                {
                    comboBox2.Items.Add(name.ProcessName + ".exe");
                }
            }

            //новый режим

       

            if (checkkillprocess.Checked == true)
            {
                Process[] p = Process.GetProcesses();

                if (p.Length != i)
                {
                    listBox2.Items.Clear();

                    foreach (Process name in Data.proces)
                    {
                        listBox2.Items.Add(name.ProcessName + ".exe");
                    }

                    label9.Text = "Всего процессов: " + p.Length;
                }
                else
                {

                }

                i = p.Length;
            }
        }


   
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Очистка мусора

        //Для очистки
        private async void Clear_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                if (checkTemp.Checked == true)
                {
                    Data.addclear++;
                }

                if (checkdonl.Checked == true)
                {
                    Data.addclear++;
                }

                if (checkclearhyckdow.Checked == true)
                {
                    Data.addclear++;
                }


                progressBar1.Maximum = Data.addclear;


                if (checkTemp.Checked == true)
                {

                    //Для очитски папок

                    string[] lol;

                    lol = Directory.GetDirectories("C:\\Windows\\Temp");

                    foreach (string s in lol)
                    {
                        try
                        {
                            Directory.Delete(s, true);
                        }
                        catch (Exception ex)
                        {
                            Data.clearerrortempt = Data.clearerrortempt + 1;
                            listBox1.Items.Add($"Ошибка в очистки temp в папки: {ex.Message}");
                        }
                    }

                    listBox1.Items.Add("Очистка temp в папки завершина!");
                    listBox1.Items.Add("Ошибок при очистки temp в папки = " + Data.clearerrortempt);

                    progessclear(1);

                    //Для очитски файлов

                    string[] clear;

                    clear = Directory.GetFiles("C:\\Windows\\Temp");

                    foreach (string s in clear)
                    {
                        try
                        {
                            Directory.Delete(s, true);
                        }
                        catch (Exception ex)
                        {
                            Data.clearerrortempt = Data.clearerrortempt + 1;
                            listBox1.Items.Add($"Ошибка в temp файлы: {ex.Message}");
                        }
                    }

                    //заметка

                    //тут не то делано progressBar1

                    listBox1.Items.Add("Очистка temp в папки завершина в файлы!");
                    listBox1.Items.Add("Ошибок при очистки temp в папки в файлы = " + Data.clearerrortempt);
                }




                if (checkdonl.Checked == true)
                {

                    //для очисток папок

                    string[] lol;

                    lol = Directory.GetDirectories("C:\\Download");

                    foreach (string s in lol)
                    {
                        try
                        {
                            Directory.Delete(s, true);
                        }
                        catch (Exception ex)
                        {
                            Data.clearerdown = Data.clearerdown + 1;
                            listBox1.Items.Add($"Ошибка в очистки загрузок в папки: {ex.Message}");
                        }
                    }

                    listBox1.Items.Add("Очистка загрузок в папки завершина!");
                    listBox1.Items.Add("Ошибок при очистки загрузок в папки = " + Data.clearerdown);

                    progessclear(2);
                }

                Data.lo = 1;

 

                if (checkclearhyckdow.Checked == true)
                {

                    //для очистки пустых папок в докуметах

                    //очистка папок

                    string[] lol;

                    lol = Directory.GetDirectories("C:\\Download");

                    foreach (string s in lol)
                    {
                        try
                        {
                            Directory.Delete(s, false);
                        }
                        catch (Exception ex)
                        {
                            Data.cleardownown = Data.cleardownown + 1;
                            listBox1.Items.Add($"Ошибка в очистки документах в папки: {ex.Message}");
                        }
                    }

                    listBox1.Items.Add("Очистка документах в папки завершина!");
                    listBox1.Items.Add("Ошибок при очистки загрузок в папки = " + Data.cleardownown);

                    progessclear(3);
                }

                Data.loggbak = 0;

                MessageBox.Show("Завершено! Всего ошибок = " + (Data.clearerrortempt + Data.clearerrorcor + Data.clearerdown + Data.cleardownown), "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Data.clearerrortempt = 0;
                Data.clearerrorcor = 0;
                Data.clearerdown = 0;
                Data.cleardownown = 0;
                Data.addclear = 0;
                progressBar1.Value = 0;

            }
            else if (radioButton2.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process.Start("C:\\Windows\\System32\\cleanmgr.exe");
                }
                catch { MessageBox.Show("Error: Нет файла под пути C: Windows System32 cleanmgr.exe или другая проблема", "Clearpro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        //для прогресса бара

        public async void progessclear(int i)
        {
            switch (Data.addclear)
            {
                case 1:
                    if (i == 1)
                    {
                        progressBar1.Value++;
                    }
                    break;
                case 2:
                    if (i == 2)
                    {
                        progressBar1.Value++;
                    }
                    break;
                case 3:
                    if (i == 2)
                    {
                        progressBar1.Value++;
                    }
                    break;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
        }

        //настройки

 

        private void checkcloseself_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcloseself.Checked == true)
            {
                Data.closeself = true;
            }
            else if (checkcloseself.Checked == false)
            {
                Data.closeself = false;
            }
        }

        //информация

        private void checkcloseself_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывалось подвержедение чтобы закрыть прогу";
        }

        private void checkcloseself_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //Анимация

        private void checkamin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkamin.Checked == true)
            {
                Data.amin = true;
            }
            else if (checkamin.Checked == false)
            {
                Data.amin = false;
            }
        }

        //Информация

        private void checkamin_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывалось анимацию кнопок";
        }

        private void checkamin_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //текст которое показывает ваше имя

        //Информация

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывалось ваше имя";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }


        //чтобы инфу показывала

        private void checkinfoleft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinfoleft.Checked == true)
            {
                label5.Visible = true;
            }
            else if (checkinfoleft.Checked == false)
            {
                label5.Visible = false;
            }
        }

        //Информация

        private void checkinfoleft_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывало информацию в тексте";
        }

        private void checkinfoleft_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //Чтобы показывало время

        private void checktime_CheckedChanged(object sender, EventArgs e)
        {
            if (checktime.Checked == true)
            {
                label4.Visible = true;
            }
            else if (checktime.Checked == false)
            {
                label4.Visible = false;
            }
        }

        //анимация

        private void checktime_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывало время";
        }

        private void checktime_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //О программе

        private void btoproggm_Click(object sender, EventArgs e)
        {
       
        }

        private void btsavename_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Напишите ваше имя", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text.Length >= 9)
            {
                MessageBox.Show("Небольше 8!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            else if (textBox1.Text != "")
            {
                Data.name = "Здрайствуй " + textBox1.Text;
                label1.Text = Data.name;
                MessageBox.Show("Сохранено!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //сброс

        private void btsppoll_Click(object sender, EventArgs e)
        {
            DialogResult lol = MessageBox.Show("Вы уверены? Все ваши настройки будут удалены!", "Cclearpro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (lol == DialogResult.Yes)
            {

                //переменные

                Data.name = "";
                Data.amin = true;
                Data.closeself = true;
                Data.nameself = false;
                Data.amin = true;
                Data.infoself = true;
                Data.info = "Что это такое? ";
                Data.nameform = false;
                Data.colorbed = "DimGray";
                Data.lagg = true;

                //сброс обьектов

                checkcloseself.Checked = true;
                checkamin.Checked = true;
                checkinfoleft.Checked = true;
                checktime.Checked = true;
                tabPage5.BackColor = Color.DimGray;
           
                tabPage3.BackColor = Color.DimGray;
                tabPage2.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.DimGray;
                comboBox1.Text = "DimGray";
                label5.Text = "Что это такое? ";
                tbinfo.Text = "Что это такое? ";
                textBox1.Text = "";
                listBox1.Visible = true;
                checklogg.Checked = true;
                toolTip1.Active = true;

                //начинаем сброс имени ;)

                f1 = new login();
                f1.Show();
                this.Close();
            }
            else if (lol == DialogResult.No)
            {

            }
        }

        //Быстрые клавиши или горячии клавиши

        private void main_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar.ToString();

            
        }

        //Информация снова

        //Для очистки

        //кнопка для очистки

        private void Clear_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы очистить ваш компьютер";
        }

        private void Clear_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //радио для очистки "Средствами Windows"

        private void radioButton2_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы Windows чистил";
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //Опять сбросы

        private void postime_Click(object sender, EventArgs e)
        {


            //остановка кофликтов

            time.Enabled = false;

            //переменные

            c = 0;
            z = 0;
            x = 0;

            //Сброс обьектов

            label1.Text = "Время работы программы: ";

          

            time.Enabled = true;
        }


      

        private void postparametr_Click(object sender, EventArgs e)
        {
            DialogResult lol = MessageBox.Show("Вы уверены? Все ваши настройки будут сбросаны!", "Cclearpro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (lol == DialogResult.Yes)
            {

                //переменные

                Data.name = "";
                Data.amin = true;
                Data.closeself = true;
                Data.nameself = false;
                Data.amin = true;
                Data.infoself = true;
                Data.info = "Что это такое? ";
                Data.nameform = false;
                Data.colorbed = "DimGray";
                Data.lagg = true;
                Data.checkicons = true;

                //сброс обьектов

                checkcloseself.Checked = true;
                checkamin.Checked = true;
                checkinfoleft.Checked = true;
                checktime.Checked = true;
                tabPage5.BackColor = Color.DimGray;
         
                tabPage3.BackColor = Color.DimGray;
                tabPage2.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.DimGray;
                comboBox1.Text = "DimGray";
                label5.Text = "Что это такое? ";
                tbinfo.Text = "Что это такое? ";
                textBox1.Text = "";
                listBox1.Visible = true;
                checklogg.Checked = true;
                toolTip1.Active = true;
                notifyIcon1.Visible = true;
                checkicon.Checked = true;
                checlinfonorm.Checked = true;

            }
            else if (lol == DialogResult.No)
            {

            }
        }

  

        //для смена заднего цвета плотформы

        private void btsacecolor_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "DimGray")
            {
                tabPage5.BackColor = Color.DimGray;
           
                tabPage3.BackColor = Color.DimGray;
                tabPage2.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.DimGray;
                Data.colorbed = "DimGray";
            }
            else if (comboBox1.Text == "Gray")
            {
                tabPage5.BackColor = Color.Gray;
            
                tabPage3.BackColor = Color.Gray;
                tabPage2.BackColor = Color.Gray;
                tabPage1.BackColor = Color.Gray;
                Data.colorbed = "Gray";
            }
            else if (comboBox1.Text == "White")
            {
                tabPage5.BackColor = Color.White;
               
                tabPage3.BackColor = Color.White;
                tabPage2.BackColor = Color.White;
                tabPage1.BackColor = Color.White;
                Data.colorbed = "White";
            }
            else
            {
                MessageBox.Show("Ошибка", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //мусор

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        //мусор

  

        private void btinfo_Click(object sender, EventArgs e)
        {
            if (tbinfo.Text.Length <= 14)
            {
                try
                {
                    Data.info = tbinfo.Text + " ";
                    label5.Text = Data.info;
                    MessageBox.Show("Сохранено", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Слишком много симболов", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чё надо!?", "А Б В Г Д!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 

        //Открывает о программе

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

 

        //чтобы показывался логи

        private void checklogg_CheckedChanged(object sender, EventArgs e)
        {
            if (checklogg.Checked == false)
            {
                listBox1.Visible = false;
            }
            else if (checklogg.Checked == true)
            {
                listBox1.Visible = true;
            }
        }

        //настройки опять

        //Чтобы нормально показывал информацию

        private void checlinfonorm_CheckedChanged(object sender, EventArgs e)
        {
            if (checlinfonorm.Checked == true)
            {
                toolTip1.Active = true;
            }
            else
            {
                toolTip1.Active = false;
            }
        }

        //анимация

        private void checlinfonorm_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы очистить ваш компьютер";
        }

        private void checlinfonorm_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
        }

        //очистка мусора

        //Исправил баг

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
        }

        //инфа

        private void logwiew_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Чтобы посмотреть все логи";
        }

        private void logwiew_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
        }

        //чтобы посмотреть логи полностью

        private void logwiew_Click(object sender, EventArgs e)
        {

            //есть ошибка номер 1

            logssss ifrm = new logssss();
            ifrm.Show(); // отображаем Form-у
        }

        //настройки..

        private void checkicon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkicon.Checked == true)
            {
                notifyIcon1.Visible = true;
                Data.checkicons = true;
            }
            else if (checkicon.Checked != true)
            {
                notifyIcon1.Visible = false;
                Data.checkicons = false;
            }
        }

        //информация

        private void checkicon_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это иконка которое показывается в трее";
        }

        private void checkicon_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
        }

   

        //командная строка

        //чтобы убить процесс

        private void btkillprocess_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Выберите процесс");
            }
            else if (comboBox2.Text != "")
            {

                //удаляем!

                ProcessKiller.Proces.Kill(comboBox2.Text);
            }
        }

        //новый режим!

        //Убить процесс

        private void btkillprocessnew_Click(object sender, EventArgs e)
        {
            ProcessKiller.Proces.Kill(listBox2.SelectedItem.ToString());
        }

 

        //чтобы открыть в полном экране

        private void btOTKRET_Click(object sender, EventArgs e)
        {
       
        
        }

        //вытоновление системы

        //все утилиты

        private void btaloytuul_Click(object sender, EventArgs e)
        {
            aloytuul l = new aloytuul();
            l.Show();
        }

        //мусор

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        //мусор

        //вытоновление системы

        //автозагруска (в реестре)

        //удалить

        private void btdeletavto_Click(object sender, EventArgs e)
        {

        }

        //обновить

        private void btresetavto_Click(object sender, EventArgs e)
        {

        }

        //настройки

        //смена аватарки

        private void btopenavater_Click(object sender, EventArgs e)
        {
            string pp = "";

            OpenFileDialog filss = new OpenFileDialog();

            filss.FileName = pp;

            if (filss.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox3.Visible = true;
                    label10.Visible = true;
                    pictureBox3.Image = new Bitmap(filss.FileName);
                }
                catch
                {

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkdonl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkclearhyckdow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
