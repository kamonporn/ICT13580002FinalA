using System;
using System.Collections.Generic;
using ICT13580002FinalA.Model;
using Xamarin.Forms;

namespace ICT13580002FinalA
{
	public partial class ProductNewPage : ContentPage
	{

		ProductNewPage product;
        private Product product1;

        public ProductNewPage(ProductNewPage product = null)
		{
			InitializeComponent();
			this.product = product;

			titleLabel.Text = product == null ? "เพิ่มสินค้า" : "แก้ไขข้อมูลสินค้า";

			saveButton.Clicked += SaveButton_Clicked;
			cancelButton.Clicked += CancelButton_Clicked;


            genPicker.Items.Add("ชาย");
            genPicker.Items.Add("หญิง");

            statusPicker.Items.Add("โสด");
            statusPicker.Items.Add("หญิง");
          

			if (product != null)
			{
				nameEntry.Text = product1.name;
				lastEntry.Text = product1.lastName;
                odlEntry.Text = product1.odl.ToString();
                genPicker.SelectedItem = product1.gen;
                numEntry.Text = product1.num.ToString();
                mailEntry.Text = product1.mail;
                addEditor.Text = product1.add;
                statusPicker.SelectedItem = product1.status;
                numbEntry.Text = product1.numb.ToString();
                moneyEntry.Text = product1.momoney.ToString();
                paEntry.Text = product1.pa;




       
    }

}

        public ProductNewPage(Product product1)
        {
            this.product1 = product1;
        }

        async void SaveButton_Clicked(object sender, EventArgs e)
		{
			var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

			if (isOk)
			{
				if (product == null)
				{
					var product = new ProductNewPage();
                    product1.name = nameEntry.Text;
                    product1.lastName = lastEntry.Text;
                    product1.odl = int.Parse(odlEntry.Text);
                    product1.gen = genPicker.SelectedItem.ToString();
                    product1.num = int.Parse(numEntry.Text);
                    product1.mail = mailEntry.Text;
                    product1.add = addEditor.Text;
                    product1.status = statusPicker.SelectedItem.ToString();
                    product1.numb = int.Parse(numbEntry.Text);
                    product1.momoney = int.Parse(moneyEntry.Text);
                    product1.pa = paEntry.Text;
                   
					//var id = App.DbHelpers.AddProduct(product);
					await DisplayAlert("บันทึกสำเร็จ", "รหสสินค้าของท่านคือ#" + id, "ตกลง");
				}
				else
				{
					product1.name = nameEntry.Text;
					product1.lastName = lastEntry.Text;
					product1.odl = int.Parse(odlEntry.Text);
					product1.gen = genPicker.SelectedItem.ToString();
					product1.num = int.Parse(numEntry.Text);
					product1.mail = mailEntry.Text;
					product1.add = addEditor.Text;
					product1.status = statusPicker.SelectedItem.ToString();
					product1.numb = int.Parse(numbEntry.Text);
					product1.momoney = int.Parse(moneyEntry.Text);
					product1.pa = paEntry.Text;

					//var id = App.DbHelpers.UpdateProduct(product);
					await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลสินค้าเรียบร้อย" + id, "ตกลง");
				}
				await Navigation.PopModalAsync();
			}
		}

		void CancelButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
        

}
