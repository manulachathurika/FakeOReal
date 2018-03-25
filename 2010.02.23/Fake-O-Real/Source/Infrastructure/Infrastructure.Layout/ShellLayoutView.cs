using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Practices.ObjectBuilder;
using FakeOReal.Infrastructure.Interface.Constants;
using FakeOReal.Infrastructure.Interface;
using FakeOReal.Infrastructure.Layout;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.EventBroker;


namespace FakeOReal.Infrastructure.Layout
{
    public partial class ShellLayoutView : UserControl
    {
        [EventPublication(EventTopicNames.LoadImage, PublicationScope.Global)]
        public event EventHandler<FakeOReal.Infrastructure.Interface.OnImageLoad> LoadImage;
    
        private ShellLayoutViewPresenter _presenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ShellLayoutView"/> class.
        /// </summary>
        public ShellLayoutView()
        {
            InitializeComponent();
            _tabWorkspace.Hide();
            _rightWorkspace.Name = WorkspaceNames.RightWorkspace;
            _tabWorkspace.Name = WorkspaceNames.TabWorkspace;
        }

        /// <summary>
        /// Sets the presenter.
        /// </summary>
        /// <value>The presenter.</value>
        [CreateNew]
        public ShellLayoutViewPresenter Presenter
        {
            set
            {
                _presenter = value;
                _presenter.View = this;
            }
        }

        /// <summary>
        /// Gets the main menu strip.
        /// </summary>
        /// <value>The main menu strip.</value>
        internal MenuStrip MainMenuStrip
        {
            get { return _mainMenuStrip; }
        }

        /// <summary>
        /// Gets the main status strip.
        /// </summary>
        /// <value>The main status strip.</value>
        internal StatusStrip MainStatusStrip
        {
            get { return _mainStatusStrip; }
        }

        /// <summary>
        /// Gets the main toolbar strip.
        /// </summary>
        /// <value>The main toolbar strip.</value>
        internal ToolStrip MainToolbarStrip
        {
            get { return _mainToolStrip; }
        }

        /// <summary>
        /// Close the application.
        /// </summary>
        private void OnFileExit(object sender, EventArgs e)
        {
            _presenter.OnFileExit();
        }

        /// <summary>
        /// Sets the status label.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetStatusLabel(string text)
        {
            _statusLabel.Text = text;
        }

        private void _opentoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Choose an Image";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = ofd.FileName; 
                try
                {
                    Image a = Image.FromFile(filename);
                    OnLoadImage(new OnImageLoad(a, filename));
                    this.panAndZoomPictureBox1.Image = Image.FromFile(filename);
                    int s = filename.LastIndexOf('\\');
                    string x = filename.Substring(filename.LastIndexOf('\\') + 1, ((filename.Length - 1) - filename.LastIndexOf('\\')));
                    this.imageTab.Text = x;                    
                    _tabWorkspace.Show();
                }
                catch
                {
                    MessageBox.Show(String.Format("Invalide File: {0}", ofd.FileName));
                    return;
                }                
            }  
        }

        protected virtual void OnLoadImage(FakeOReal.Infrastructure.Interface.OnImageLoad eventArgs)
        {
            if (LoadImage != null)
            {
                LoadImage(this, eventArgs);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_tabWorkspace.SelectedIndex>0){
            _tabWorkspace.TabPages.Remove(_tabWorkspace.SelectedTab);
            }
        }

        private void databaseSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm();
            df.Show();
        }
    }
}
