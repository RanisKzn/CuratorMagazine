﻿using CuratorMagazineBlazorApp.Data.Services;
using CuratorMagazineWebAPI.Models.Entities.Domains;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace CuratorMagazineBlazorApp.Shared.ModalWindows;

/// <summary>
/// Class ChangeCuratorModalWindow.
/// Implements the <see cref="ComponentBase" />
/// </summary>
/// <seealso cref="ComponentBase" />
public partial class ChangeCuratorModalWindow
{
    /// <summary>
    /// Gets or sets the curator.
    /// </summary>
    /// <value>The curator.</value>
    [Parameter]
    public User? Curator { get; set; }

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

    /// <summary>
    /// The divisions
    /// </summary>
    private List<Division>? _divisions;

    /// <summary>
    /// Called when [finish].
    /// </summary>
    /// <param name="editContext">The edit context.</param>
    private void OnFinish(EditContext editContext)
    {
        Console.WriteLine($"Success: {JsonConvert.SerializeObject(Curator)}");
    }

    /// <summary>
    /// Called when [finish failed].
    /// </summary>
    /// <param name="editContext">The edit context.</param>
    private void OnFinishFailed(EditContext editContext)
    {
        Console.WriteLine($"Failed: {JsonConvert.SerializeObject(Curator)}");
    }

    /// <summary>
    /// Changes the curator.
    /// </summary>
    private void ChangeCurator()
    {

    }
}