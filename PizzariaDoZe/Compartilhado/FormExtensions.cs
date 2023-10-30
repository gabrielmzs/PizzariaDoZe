namespace PizzariaDoZe.Compartilhado {
    public static class FormExtensions {
        public static void ConfigurarDialog(this Form form) {
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.KeyPreview = true;

            form.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


        }

   
    }
}
