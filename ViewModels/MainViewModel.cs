using CommunityToolkit.Mvvm.ComponentModel;
using EcoSystem.Client.Models;

namespace EcoSystem.Client.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string title = "EcoSystem Connect";

    [ObservableProperty]
    private List<Ecosystem> ecosystems = new()
    {
        new Ecosystem
        {
            Id = 1,
            Name = "Selva tropical",
            Description = "Ecosistema con una gran variedad de especies.",
            CreatedAt = DateTime.Now
        },
        new Ecosystem
        {
            Id = 2,
            Name = "Arrecife de coral",
            Description = "Ecosistema marino de alta biodiversidad.",
            CreatedAt = DateTime.Now
        }
    };
}