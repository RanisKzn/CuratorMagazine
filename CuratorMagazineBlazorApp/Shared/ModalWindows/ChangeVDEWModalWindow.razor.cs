﻿using CuratorMagazineBlazorApp.Data.Services;
using CuratorMagazineWebAPI.Models.Entities.Domains;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;

namespace CuratorMagazineBlazorApp.Shared.ModalWindows;

/// <summary>
/// Class ModalChangeVDEWWindow.
/// Implements the <see cref="ComponentBase" />
/// </summary>
/// <seealso cref="ComponentBase" />
public partial class ChangeVDEWModalWindow
{
    [Parameter]
    public User? _vdew { get; set; }

    /// <summary>
    /// Gets or sets the division service.
    /// </summary>
    /// <value>The division service.</value>
    [Inject]
    public DivisionService? DivisionService { get; set; }

    /// <summary>
    /// The divisions
    /// </summary>
    private List<Division>? _divisions = new();

    /// <summary>
    /// Gets or sets the selected division.
    /// </summary>
    /// <value>The selected division.</value>
    private string? _selectedDivision { get; set; }

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

    /// <summary>
    /// On initialized as an asynchronous operation.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation.</returns>
    protected override async Task OnInitializedAsync()
    {
        var ret = await DivisionService?.PostAsync()!;
        _divisions = JsonConvert.DeserializeObject<List<Division>>(ret.Result.Items?.ToString() ?? string.Empty);

        _selectedDivision = _vdew.Division.Name;
    }

    /// <summary>
    /// Changes the vdew.
    /// </summary>
    public void ChangeVDEW()
    {

    }
}