using System;
using System.Windows;
using System.Windows.Controls;
using ContasReceberClient.ViewModel.ContasReceber;

namespace ContasReceberClient.View.ContasReceber
{
    /// <summary>
    /// Interaction logic for Detalhe.xaml
    /// </summary>
    public partial class FinParcelaRecebimento : UserControl
    {
        public FinParcelaRecebimento()
        {
            InitializeComponent();
        }
		
		private void btPesquisarContaCaixa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((ViewFinLancamentoReceberViewModel)DataContext).pesquisarContaCaixa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }


		
		private void btPesquisarFinTipoPagamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((ViewFinLancamentoReceberViewModel)DataContext).pesquisarFinTipoRecebimento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }


    }
}
