namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        var contacts = new List<Contact> { 
            new Contact { Name="John Doe", Email="john@yahoo.com"} ,
             new Contact { Name="Jane Doe", Email="jane@yahoo.com"}
        };

        List<string> list = new List<string>()
        {
            "John Doe",
            "Janie Doe",
            "Tom Hanks",
            "Frank Liu"
        };
        listContacts.ItemsSource = contacts;
	}

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }

    private void btnEditContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));
    }

    private void btnAddContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}