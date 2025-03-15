<h1>Notities voor toekomstige applicaties</h1>
<br>
- <b>MVVM</b> = Models, Views, ViewModels: De standaard voor XAML/C# applicatiestructuur. Hieraan kun je Services en Themes toevoegen.<br>
- <b>App.xaml / App.xaml.cs</b> bepaald wat bekend is en wat ingeladen word<br>
- <b>Public</b> functies zijn beschikbaar in de hele app en private functies zijn beschikbaar in de op dat moment beschikbare context. (huidige struct of klasse)<br>
- <b>void</b> declareer je als er geen object gemaakt hoeft te worden en geen retourwaarde nodig is<br>
- <b>static</b> declareer je als je wilt dat de functie hetzelfde blijft tijdens alle instances en klasses<br>
- 

- Routering initializatie:<br>
  <code> static class Navigator
    { private static ContentControl MainContent => ((MainWindow)Application.Current.MainWindow).MainContent;
              public static void Navigate(UIElement content)
              {
                  MainContent.Content = content;
              }
          }</code><br><br>
- Routering functie:<br>
- <code>private void Naam_Click(object sender, RoutedEventArgs e)
  {
  Navigator.Navigate(new Pagina1());
  }</code><br><br>

- Een functie voor een knop om het venster te minimaliseren. Lijkt op routering maar ipv een Navigate word het venster aangeroepen en de staat veranderd
- <code>private void Minimaliseren_Click(object sender, RoutedEventArgs e)
  {
  Window.GetWindow(this).WindowState = WindowState.Minimized;
  }</code><br><br>
- Een functie voor een knop om het venster te minimaliseren. Lijkt op routering maar ipv een Navigate word de staat van de applicatie aangepast. MessageBox = een standaard windows popup vraag.
- <code>private void Afsluiten_Click(object sender, RoutedEventArgs e)
  {
  MessageBoxResult result = MessageBox.Show("Wil je de applicatie afsluiten?", "Bevestiging",
  MessageBoxButton.YesNo, MessageBoxImage.Question);
  if (result == MessageBoxResult.Yes)
  {
  Application.Current.Shutdown();
  }
  }</code>