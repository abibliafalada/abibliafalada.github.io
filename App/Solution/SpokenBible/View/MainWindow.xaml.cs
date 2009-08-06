﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using sbcore.Model;
using sbcore.Model.Interface;
using SpokenBible.Presenter;

namespace SpokenBible.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainPresenter presenter = null;
        
        public MainWindow(MainPresenter presenter)
        {
            this.presenter = presenter;
            InitializeComponent();
        }
        
        public void ClearContent()
        {
            documentReader.Document.Blocks.Clear();
            FlowDocument trickToMoveToBegin = documentReader.Document;
            documentReader.Document = null;
            documentReader.Document = trickToMoveToBegin;
        }

        public void ShowContent(ISbItem item)
        {
            Paragraph p = new Paragraph();
            p.Inlines.Add(item.Display);
            documentReader.Document.Blocks.Add(p);
            InternalShowContent(item);
        }

        private void InternalShowContent(ISbItem item)
        {
            foreach (ISbItem i in item.Children)
            {
                ShowContent(i);
            }
        }

        private void busca_TextChanged(object sender, RoutedEventArgs e)
        {
            this.presenter.SearchChanged(busca.Text);
        }


        internal void UpdateSuggestions(IEnumerable<string> sugestoes)
        {
            busca.ItemsSource = sugestoes;
        }

        private void busca_SearchRequest(object sender, RoutedEventArgs e)
        {
            this.presenter.SearchRequested(busca.Text);
        }

        private void ler_Click(object sender, RoutedEventArgs e)
        {
            if(this.documentReader.Selection.Text != string.Empty)
                this.presenter.SpeachRequest(this.documentReader.Selection.Text);
            else
                this.presenter.SpeachRequest("Selecione o texto a ser lido!");
        }

    }
}
