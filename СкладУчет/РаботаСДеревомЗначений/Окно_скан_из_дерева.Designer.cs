﻿namespace СкладскойУчет
{
    partial class Окно_скан_из_дерева
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Пользователь = new System.Windows.Forms.Label();
            this.Инструкция = new System.Windows.Forms.Label();
            this.МенюПодбора = new System.Windows.Forms.ContextMenu();
            this.Подобрать = new System.Windows.Forms.MenuItem();
            this.Вычерк = new System.Windows.Forms.MenuItem();
            this.Завершить = new System.Windows.Forms.MenuItem();
            this.Таб = new System.Windows.Forms.TabControl();
            this.Подбор = new System.Windows.Forms.TabPage();
            this.СообщениеПодождите = new System.Windows.Forms.Label();
            this.ДопИнфоОТоваре = new System.Windows.Forms.Label();
            this.Поиск = new System.Windows.Forms.TabPage();
            this.СписокИнформации = new System.Windows.Forms.TextBox();
            this.ТекстДЯ = new System.Windows.Forms.Label();
            this.Меню = new System.Windows.Forms.Button();
            this.КнопкаПовторитьЗавершение = new System.Windows.Forms.Button();
            this.Дерево = new СкладскойУчет.РаботаСФормами.РасширенияЭлементов.TreeViewEx();
            this.Таб.SuspendLayout();
            this.Подбор.SuspendLayout();
            this.Поиск.SuspendLayout();
            this.SuspendLayout();
            // 
            // Пользователь
            // 
            this.Пользователь.BackColor = System.Drawing.SystemColors.Info;
            this.Пользователь.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Пользователь.Location = new System.Drawing.Point(4, 305);
            this.Пользователь.Name = "Пользователь";
            this.Пользователь.Size = new System.Drawing.Size(97, 15);
            this.Пользователь.Text = "_";
            // 
            // Инструкция
            // 
            this.Инструкция.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.Инструкция.Location = new System.Drawing.Point(3, 0);
            this.Инструкция.Name = "Инструкция";
            this.Инструкция.Size = new System.Drawing.Size(230, 9);
            this.Инструкция.Tag = "Инструкция";
            this.Инструкция.Text = "_";
            // 
            // МенюПодбора
            // 
            this.МенюПодбора.MenuItems.Add(this.Подобрать);
            this.МенюПодбора.MenuItems.Add(this.Вычерк);
            this.МенюПодбора.MenuItems.Add(this.Завершить);
            this.МенюПодбора.Popup += new System.EventHandler(this.МенюПодбора_Popup);
            // 
            // Подобрать
            // 
            this.Подобрать.Text = "Подобрать";
            this.Подобрать.Click += new System.EventHandler(this.Подобрать_Click);
            // 
            // Вычерк
            // 
            this.Вычерк.Text = "Вычерк";
            this.Вычерк.Click += new System.EventHandler(this.Вычерк_Click);
            // 
            // Завершить
            // 
            this.Завершить.Text = "Завершить подбор";
            this.Завершить.Click += new System.EventHandler(this.Завершить_Click);
            // 
            // Таб
            // 
            this.Таб.Controls.Add(this.Подбор);
            this.Таб.Controls.Add(this.Поиск);
            this.Таб.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Таб.Location = new System.Drawing.Point(3, 12);
            this.Таб.Name = "Таб";
            this.Таб.SelectedIndex = 0;
            this.Таб.Size = new System.Drawing.Size(230, 290);
            this.Таб.TabIndex = 5;
            // 
            // Подбор
            // 
            this.Подбор.BackColor = System.Drawing.SystemColors.Info;
            this.Подбор.ContextMenu = this.МенюПодбора;
            this.Подбор.Controls.Add(this.КнопкаПовторитьЗавершение);
            this.Подбор.Controls.Add(this.СообщениеПодождите);
            this.Подбор.Controls.Add(this.Дерево);
            this.Подбор.Controls.Add(this.ДопИнфоОТоваре);
            this.Подбор.Location = new System.Drawing.Point(4, 22);
            this.Подбор.Name = "Подбор";
            this.Подбор.Size = new System.Drawing.Size(222, 264);
            this.Подбор.Text = "1.Подбор";
            // 
            // СообщениеПодождите
            // 
            this.СообщениеПодождите.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.СообщениеПодождите.Location = new System.Drawing.Point(17, 35);
            this.СообщениеПодождите.Name = "СообщениеПодождите";
            this.СообщениеПодождите.Size = new System.Drawing.Size(184, 54);
            this.СообщениеПодождите.Text = "Подождите идет синхронизация данных с ИБД";
            this.СообщениеПодождите.Visible = false;
            // 
            // ДопИнфоОТоваре
            // 
            this.ДопИнфоОТоваре.ContextMenu = this.МенюПодбора;
            this.ДопИнфоОТоваре.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.ДопИнфоОТоваре.Location = new System.Drawing.Point(0, 214);
            this.ДопИнфоОТоваре.Name = "ДопИнфоОТоваре";
            this.ДопИнфоОТоваре.Size = new System.Drawing.Size(222, 46);
            // 
            // Поиск
            // 
            this.Поиск.Controls.Add(this.СписокИнформации);
            this.Поиск.Location = new System.Drawing.Point(4, 22);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(222, 264);
            this.Поиск.Text = "2.Поиск";
            this.Поиск.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // СписокИнформации
            // 
            this.СписокИнформации.AcceptsReturn = true;
            this.СписокИнформации.BackColor = System.Drawing.SystemColors.HighlightText;
            this.СписокИнформации.ForeColor = System.Drawing.SystemColors.InfoText;
            this.СписокИнформации.Location = new System.Drawing.Point(-1, 3);
            this.СписокИнформации.Multiline = true;
            this.СписокИнформации.Name = "СписокИнформации";
            this.СписокИнформации.ReadOnly = true;
            this.СписокИнформации.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.СписокИнформации.Size = new System.Drawing.Size(225, 255);
            this.СписокИнформации.TabIndex = 1;
            this.СписокИнформации.Text = "Сканируйте ШК для получения информации";
            // 
            // ТекстДЯ
            // 
            this.ТекстДЯ.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.ТекстДЯ.Location = new System.Drawing.Point(108, 305);
            this.ТекстДЯ.Name = "ТекстДЯ";
            this.ТекстДЯ.Size = new System.Drawing.Size(81, 15);
            // 
            // Меню
            // 
            this.Меню.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Меню.Location = new System.Drawing.Point(189, 300);
            this.Меню.Name = "Меню";
            this.Меню.Size = new System.Drawing.Size(50, 22);
            this.Меню.TabIndex = 0;
            this.Меню.Text = "&0.меню";
            this.Меню.Click += new System.EventHandler(this.Меню_Click);
            // 
            // КнопкаПовторитьЗавершение
            // 
            this.КнопкаПовторитьЗавершение.BackColor = System.Drawing.Color.LightSalmon;
            this.КнопкаПовторитьЗавершение.Location = new System.Drawing.Point(0, 212);
            this.КнопкаПовторитьЗавершение.Name = "КнопкаПовторитьЗавершение";
            this.КнопкаПовторитьЗавершение.Size = new System.Drawing.Size(223, 53);
            this.КнопкаПовторитьЗавершение.TabIndex = 5;
            this.КнопкаПовторитьЗавершение.Text = "Повторить завершение задания";
            this.КнопкаПовторитьЗавершение.Visible = false;
            this.КнопкаПовторитьЗавершение.Click += new System.EventHandler(this.КнопкаПовторитьЗавершение_Click);
            // 
            // Дерево
            // 
            this.Дерево.ContextMenu = this.МенюПодбора;
            this.Дерево.Location = new System.Drawing.Point(0, 1);
            this.Дерево.Name = "Дерево";
            this.Дерево.Size = new System.Drawing.Size(222, 212);
            this.Дерево.TabIndex = 3;
            this.Дерево.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Дерево_AfterSelect_1);
            this.Дерево.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Дерево_NodeMouseClick);
            // 
            // Окно_скан_из_дерева
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ContextMenu = this.МенюПодбора;
            this.ControlBox = false;
            this.Controls.Add(this.Меню);
            this.Controls.Add(this.ТекстДЯ);
            this.Controls.Add(this.Таб);
            this.Controls.Add(this.Инструкция);
            this.Controls.Add(this.Пользователь);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "Окно_скан_из_дерева";
            this.Text = "Выбор";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Окно_выбора_из_списка_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Окно_выбора_из_списка_KeyDown);
            this.Таб.ResumeLayout(false);
            this.Подбор.ResumeLayout(false);
            this.Поиск.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Пользователь;
        private System.Windows.Forms.Label Инструкция;
        private System.Windows.Forms.TabControl Таб;
        private System.Windows.Forms.TabPage Подбор;
        private System.Windows.Forms.TabPage Поиск;
        private System.Windows.Forms.Label ТекстДЯ;
        private System.Windows.Forms.Label ДопИнфоОТоваре;
        private System.Windows.Forms.TextBox СписокИнформации;
        private System.Windows.Forms.ContextMenu МенюПодбора;
        private System.Windows.Forms.MenuItem Подобрать;
        private System.Windows.Forms.MenuItem Вычерк;
        private System.Windows.Forms.MenuItem Завершить;
        private System.Windows.Forms.Button Меню;
        private СкладскойУчет.РаботаСФормами.РасширенияЭлементов.TreeViewEx Дерево;
        private System.Windows.Forms.Label СообщениеПодождите;
        private System.Windows.Forms.Button КнопкаПовторитьЗавершение;
    }
}