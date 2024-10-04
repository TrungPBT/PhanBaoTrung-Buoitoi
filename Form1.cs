namespace PhanBaoTrung_Buoitoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Nhấp_Click(object sender, EventArgs e)
        {
            MyClass myClass = new MyClass();
            MessageBox.Show(myClass.PrintOut("Nhấp cmm à"));
            IIfc1 ifc = (IIfc1)myClass;
            MessageBox.Show(ifc.PrintOut("Lỳ vcc ra"));
        }

        private void btn_bienhinh_Click(object sender, EventArgs e)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Cat();
            animals[1] = new Bird();
            animals[2] = new Dog();
            foreach(Animal a in animals) 
            {
                ILiveBirth b = a as ILiveBirth;
                if (b != null)
                    MessageBox.Show(b.BaByRedCalled());
            }
        }
    }
}
