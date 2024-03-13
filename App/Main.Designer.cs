namespace App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            ProjectsListLabel = new Label();
            TasksListLabel = new Label();
            RecordsListLabel = new Label();
            ProjectsListView = new ListView();
            TasksListView = new ListView();
            RecordsListView = new ListView();
            SuspendLayout();
            // 
            // ProjectsListLabel
            // 
            resources.ApplyResources(ProjectsListLabel, "ProjectsListLabel");
            ProjectsListLabel.Name = "ProjectsListLabel";
            // 
            // TasksListLabel
            // 
            resources.ApplyResources(TasksListLabel, "TasksListLabel");
            TasksListLabel.Name = "TasksListLabel";
            // 
            // RecordsListLabel
            // 
            resources.ApplyResources(RecordsListLabel, "RecordsListLabel");
            RecordsListLabel.Name = "RecordsListLabel";
            // 
            // ProjectsListView
            // 
            ProjectsListView.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(ProjectsListView, "ProjectsListView");
            ProjectsListView.MultiSelect = false;
            ProjectsListView.Name = "ProjectsListView";
            ProjectsListView.ShowGroups = false;
            ProjectsListView.Sorting = SortOrder.Ascending;
            ProjectsListView.UseCompatibleStateImageBehavior = false;
            // 
            // TasksListView
            // 
            TasksListView.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(TasksListView, "TasksListView");
            TasksListView.MultiSelect = false;
            TasksListView.Name = "TasksListView";
            TasksListView.ShowGroups = false;
            TasksListView.Sorting = SortOrder.Ascending;
            TasksListView.UseCompatibleStateImageBehavior = false;
            // 
            // RecordsListView
            // 
            RecordsListView.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(RecordsListView, "RecordsListView");
            RecordsListView.MultiSelect = false;
            RecordsListView.Name = "RecordsListView";
            RecordsListView.ShowGroups = false;
            RecordsListView.Sorting = SortOrder.Ascending;
            RecordsListView.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RecordsListView);
            Controls.Add(TasksListView);
            Controls.Add(ProjectsListView);
            Controls.Add(RecordsListLabel);
            Controls.Add(TasksListLabel);
            Controls.Add(ProjectsListLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProjectsListLabel;
        private Label TasksListLabel;
        private Label RecordsListLabel;
        private ListView ProjectsListView;
        private ListView TasksListView;
        private ListView RecordsListView;
    }
}
