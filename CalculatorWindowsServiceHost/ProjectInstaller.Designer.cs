namespace CalculatorWindowsServiceHost
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.calcServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // calcServiceProcessInstaller
            // 
            this.calcServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.calcServiceProcessInstaller.Password = null;
            this.calcServiceProcessInstaller.Username = null;
            // 
            // calcServiceInstaller
            // 
            this.calcServiceInstaller.Description = "Calculator WCF Service Hosted as Win Service";
            this.calcServiceInstaller.DisplayName = "Calculator Windows Service";
            this.calcServiceInstaller.ServiceName = "CalculatorWindowsService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.calcServiceProcessInstaller,
            this.calcServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller calcServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller calcServiceInstaller;
    }
}