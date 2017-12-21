using System;
using ICT13580002FinalA.Model;
using Xamarin.Forms;
using System.Collections.Generic;

namespace ICT13580002FinalA
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			newButton.Clicked += NewButton_Clicked;
		}

		void NewButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ProductNewPage());
		}
		protected override void OnAppearing()
		{
			LoadData();
		}
		void LoadData()
		{
            productListView.ItemsSource = App.DbHelpers.GetProducts();
		}

		void Edit_Clicked(object sender, System.EventArgs e)
		{

			var button = sender as MenuItem;
			var product = button.CommandParameter as Product;
			Navigation.PushModalAsync(new ProductNewPage(product));
		}
		async void Delete_Clicked(object sender, System.EventArgs e)
		{
			var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการลบใช่หรือไม่", "ใช่", "ไม่ใช่");
			if (isOk)
			{
				var button = sender as MenuItem;
				var product = button.CommandParameter as Product;

				App.dbHelpers.DeleteProduct(product);

				await DisplayAlert("ลบสำเร็จ", "ลบข้อมูลสินค้าเรียบร้อย", "ตกลง");
				LoadData();
			}
		}
	}
}
