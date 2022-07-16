namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String lbl_Products = "�r�nler";
            String lbl_Basket = "Sepetim";
            lblProducts.Text = lbl_Products.ToString();
            lblBasket.Text = lbl_Basket.ToString();

            String[] urunler = { "Bilgisayar", "Laptop", "Tablet" };

            foreach (String str in urunler)
            {
                lbxProducts.Items.Add(str);
            }

            if (lbxBasket.Items.Count <= 0)//sepette eleman yoksa sepetten kald�r butonu aktif olmas�n.
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            if(lbxProducts.SelectedItem !=null)
            {
                lbxBasket.Items.Add(lbxProducts.SelectedItem);
                btnRemove.Enabled = true;
                }
            else
            {
                MessageBox.Show("�ncelikle bir eleman se�iniz.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          if(lbxBasket.SelectedItems != null)
            {
                lbxBasket.Items.Remove(lbxBasket.SelectedItem);
                if (lbxBasket.Items.Count <= 0)
                {
                    btnRemove.Enabled = false;
                }
            }
        }
    }
}