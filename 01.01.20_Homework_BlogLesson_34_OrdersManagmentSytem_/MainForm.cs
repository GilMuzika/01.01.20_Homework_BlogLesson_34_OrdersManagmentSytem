using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._01._20_Homework_BlogLesson_34_OrdersManagmentSytem_
{
    public partial class MainForm : Form
    {
        private Random _rnd = new Random();
        private string[] namesToUsing;
        private string[] companiesToUsing;
        private string[] productsToUing;
        private Client currentClient;
        private Supplier currentSupplier;

        private DAO currentDAO = new DAO();

        public MainForm()
        {
            InitializeComponent();            
            ReadFromFile();
            Initialize();
        }
        private void Initialize()
        {
            tbnTabControl1.Width = this.ClientRectangle.Width;
            tbnTabControl1.Height = this.ClientRectangle.Height;
            tbnTabControl1.Location = new Point(0, 0);
            btnOrderTheproduct.Enabled = false;
            pnlClientAlredySignedIn.Visible = false;
            pnlAddNewProduct.Visible = false;

            cmbNewProductSuppliers.Items.AddRange(currentDAO.GetAllDefinedObjects<Supplier>().Select(x => new ComboItem<Supplier>(x)).ToArray());

            pnlClientAlredySignedIn.Width = this.ClientRectangle.Width;
            pnlClientAlredySignedIn.Location = new Point(0, 0);
            dgvCurrentClientOrders.Width = this.ClientRectangle.Width - 10;
            dgvCurrentClientOrders.Location = new Point(0, 200);
            dgvTrackingTable.DataSource = currentDAO.ViewAsGrid("TrackingLog");

            ResetClient();
            ResetSupplier();
            ResetProduct();            

            
        }
        private void ResetClient()
        {
            txtRealUserName.Text = namesToUsing[_rnd.Next(namesToUsing.Length - 1)];
            txtNewUserName.Text = Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(5, 10)).ToLower().FirstLetterToupper();
            txtNewPassword.Text = Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(10, 15));
            txtClientFamily.Text = txtRealUserName.Text + "son";

            pnlLongNumberCreatorPanel1.RandomNumber();
        }
        private void ResetSupplier()
        {
            txtSupplieruserName.Text = Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(5, 10)).ToLower().FirstLetterToupper();
            txtSupplierPassword.Text = Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(10, 15));
            txtSupplierCompanyName.Text = companiesToUsing[_rnd.Next(companiesToUsing.Length - 1)];
        }
        private void ResetProduct()
        {
            txtProsuctName.Text = productsToUing[_rnd.Next(productsToUing.Length - 1)];            
            numProductAmount.Value = _rnd.Next((int)numProductAmount.Minimum, (int)numProductAmount.Maximum);
            numProductPrice.Value = _rnd.Next((int)numProductPrice.Minimum, (int)numProductPrice.Maximum);
        }

        private void ReadFromFile()
        {
            string names = string.Empty;
            string companies = string.Empty;
            string products = string.Empty;
            try
            {
                names = File.ReadAllText("_names.txt");
                companies = File.ReadAllText("_companies.txt");
                products = File.ReadAllText("_products.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n\nSo the program will use the defult names");
                names = " Alfred Benny Connnor Daniel Eran ";
            }
            namesToUsing = names.Split(new char[] { ' ', '\t', '\n' }).Where(x => !String.IsNullOrEmpty(x)).ToArray();
            companiesToUsing = companies.Split(new char[] { ' ', '\t', '\n' });
            productsToUing = products.Split(new char[] { ' ', '\t', '\n' });
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                userName = txtNewUserName.Text,
                pass = Statics.Encrypt(txtNewPassword.Text, txtNewUserName.Text),
                name = txtRealUserName.Text,
                family = txtClientFamily.Text,
                credit = Statics.Encrypt(pnlLongNumberCreatorPanel1.Number, txtNewUserName.Text)
            };

            currentDAO.AddNewDefinedObject(client);

            ResetClient();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                userName = txtSupplieruserName.Text,
                pass = Statics.Encrypt(txtSupplierPassword.Text, txtSupplieruserName.Text),
                companyName = txtSupplierCompanyName.Text
            };
            currentDAO.AddNewDefinedObject(supplier);
            ResetSupplier();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                productName = txtProsuctName.Text,
                supplierNum = (cmbNewProductSuppliers.SelectedItem as ComboItem<Supplier>).Item.NUM,
                price = (int)numProductPrice.Value,
                amount = (int)numProductAmount.Value,
            };
            currentDAO.AddNewDefinedObject(product);
            ResetProduct();
        }

      
        private void btnSignInClient_Click(object sender, EventArgs e)
        {
            //string encrypted = Statics.Encrypt(txtSignInPass.Text, txtSingInUserName.Text);
            //MessageBox.Show($"{encrypted}\n{Statics.Decrypt(encrypted, txtSingInUserName.Text)}");

          bool IsIInTheSystem =  currentDAO.isIInTheSystem<Client>(txtSingInUserName.Text, Statics.Encrypt(txtSignInPass.Text, txtSingInUserName.Text), out currentClient);
            

            if (IsIInTheSystem == false)
            {
                this.tbnTabControl1.SelectedTab = tabNewClient;
                FlexibleMessageBox.Show("Sorry, but you currently not in the system. To use it, Plese sign up first");
            }

            else
            {
                btnOrderTheproduct.Enabled = false;
                pnlClientSignIn.Visible = false;
                pnlClientAlredySignedIn.Visible = true;
                dgvCurrentClientOrders.DataSource = currentDAO.ViewAsGrid("Orders", currentClient.NUM);

                cmbAllTheProducts.Items.AddRange(currentDAO.GetAllDefinedObjects<Product>().Select(x => new ComboItem<Product>(x)).ToArray());
                cmbNewProductSuppliers.SelectedIndex = -1;
                lblProductInfo.Text = string.Empty;
            }
        }

        private void cmbAllTheProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            btnOrderTheproduct.Enabled = true;
            lblProductInfo.Text = string.Empty;
            var selectedProduct = ((sender as ComboBox).SelectedItem as ComboItem<Product>).Item;
            numAmountOfOrder.Maximum = selectedProduct.amount;
            //for (int i = 1; i < selectedProduct.GetType().GetProperties().Length; i++) lblProductInfo.Text += $"{selectedProduct.GetType().GetProperties()[i].Name}: {selectedProduct.GetType().GetProperties()[i].GetValue(selectedProduct)}\n";

            //var suppl = currentDAO.GetOneDefinedObject<Supplier>(selectedProduct.supplierNum);

            lblProductInfo.Text += $"Name: {selectedProduct.productName}\n";
            lblProductInfo.Text += $"Supplier: {currentDAO.GetOneDefinedObject<Supplier>(selectedProduct.supplierNum).userName}\n";
            lblProductInfo.Text += $"Price: {selectedProduct.price}\n";
            lblProductInfo.Text += $"Amount aviliable: {selectedProduct.amount}\n";

            
        }

        private void btnOrderTheproduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (cmbAllTheProducts.SelectedItem as ComboItem<Product>).Item;
            currentDAO.MakeOrder(currentClient, selectedProduct, (int)numAmountOfOrder.Value);
            dgvCurrentClientOrders.DataSource = currentDAO.ViewAsGrid("Orders", currentClient.NUM);
        }

        private void btnSupplierSignIN_Click(object sender, EventArgs e)
        {
            bool IsIInTheSystem = currentDAO.isIInTheSystem<Supplier>(txtUserNameSupplier.Text, Statics.Encrypt(txtPasswordSupplier.Text, txtUserNameSupplier.Text), out currentSupplier);
            if(!IsIInTheSystem)
            {
                this.tbnTabControl1.SelectedTab = tabNewSupplier;
                FlexibleMessageBox.Show("Sorry, but you currently not in the system. To use it, Plese sign up first");
            }
            else
            {
                try
                {
                    pnlSuppierSigningIn.Visible = false;
                    pnlAddNewProduct.Visible = true;
                }
                catch (Exception ex)
                {
                    FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
