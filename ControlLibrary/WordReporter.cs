using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static Microsoft.FSharp.Compiler.Ast.SynExpr;
using Microsoft.Office.Interop.Word;
using MigraDoc.DocumentObjectModel;

namespace ControlLibrary
{
    public partial class WordReporter : Component
    {
        static void Main(string[] args)
        {
            // путь к документу
            string pathDocument = AppDomain.CurrentDomain.BaseDirectory + "example.docx";

            // создаём документ
            DocX document = DocX.Create(pathDocument);

            // Вставляем параграф и указываем текст
            document.InsertParagraph("Тест");

            // вставляем параграф и передаём текст
            document.InsertParagraph("Тест").
                     // устанавливаем шрифт
                     Font("Calibri").
                     // устанавливаем размер шрифта
                     FontSize(36).
                     // устанавливаем цвет
                     Color(Color.FromRgbColor(255,Color color)).
                     // делаем текст жирным
                     Bold().
                     // устанавливаем интервал между символами
                     Spacing(15).
                     // выравниваем текст по центру
                     Alignment = Alignment.center;

            // вставляем параграф и добавляем текст
            Paragraph paragraph = document.InsertParagraph();
            // выравниваем параграф по правой стороне
            paragraph.Alignment = Alignment.right;

            // добавляем отдельную строку со своим форматированием
            paragraph.AppendLine("Тест").
                     // устанавливаем размер шрифта
                     FontSize(20).
                     // добавляем курсив
                     Italic().
                     // устанавливаем точечное подчёркивание
                     UnderlineStyle(UnderlineStyle.dotted).
                     // устанавливаем цвет подчёркивания
                     UnderlineColor(Color.DarkOrange).
                     // добавляем выделение текста
                     Highlight(Highlight.yellow);
            // добавляем пустую строку
            paragraph.AppendLine();
            // добавляем ещё одну строку
            paragraph.AppendLine("Тест");

            // сохраняем документ
            document.Save();
        }
    }
    }

