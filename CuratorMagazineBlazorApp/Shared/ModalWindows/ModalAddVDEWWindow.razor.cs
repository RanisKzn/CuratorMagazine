﻿using CuratorMagazineBlazorApp.Data.Services;
using CuratorMagazineWebAPI.Models.Entities.Domains;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;

namespace CuratorMagazineBlazorApp.Shared.ModalWindows;

public partial class ModalAddVDEWWindow
{
    private User _vdew = new();

    /// <summary>
    /// Gets or sets the role callback.
    /// </summary>
    /// <value>The role callback.</value>
    [Parameter]
    public EventCallback<User> RoleCallback { get; set; }

    /// <summary>
    /// Gets or sets the user service.
    /// </summary>
    /// <value>The user service.</value>
    [Inject]
    public UserService? UserService { get; set; }

    /// <summary>
    /// Gets or sets the navigation manager.
    /// </summary>
    /// <value>The navigation manager.</value>
    [Inject]
    public NavigationManager NavigationManager { get; set; } = null!;

    private List<Division>? _divisions = new();

    private string _selectedDivision { get; set; }

    /// <summary>
    /// Called when [finish].
    /// </summary>
    /// <param name="editContext">The edit context.</param>
    private void OnFinish(EditContext editContext)
    {
        Console.WriteLine($"Success: {JsonConvert.SerializeObject(_vdew)}");
    }

    /// <summary>
    /// Called when [finish failed].
    /// </summary>
    /// <param name="editContext">The edit context.</param>
    private void OnFinishFailed(EditContext editContext)
    {
        Console.WriteLine($"Failed: {JsonConvert.SerializeObject(_vdew)}");

    }

    public void AddVDEW()
    {

    }
}