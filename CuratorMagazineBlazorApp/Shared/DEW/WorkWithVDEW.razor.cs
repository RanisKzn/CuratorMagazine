using AntDesign.Core.Helpers.MemberPath;
using CuratorMagazineBlazorApp.Data.Services;
using CuratorMagazineBlazorApp.Models.States;
using CuratorMagazineWebAPI.Models.Entities;
using CuratorMagazineWebAPI.Models.Entities.Domains;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;

namespace CuratorMagazineBlazorApp.Shared.DEW
{
    public partial class WorkWithVDEW
    {
        [Parameter]
        public User? CurrentUser { get; set; }

        [Inject]
        public UserService? UserService { get; set; }

        [Parameter]
        public StateRoleNavBar? StateRoleNavBar { get; set; } = new();

        [Parameter]
        public EventCallback<StateRoleNavBar> StateRoleNavBarCallback { get; set; }

        private List<User>? _users = new();

        //public void ChangeOnDefaultStateRoleNavBar()
        //{
        //    StateRoleNavBar = new StateRoleNavBar() { RoleName = default };
        //    StateRoleNavBarCallback.InvokeAsync(StateRoleNavBar);
        //}

        void DeleteVDEW(User user)
        {

        }

        void AddVDEW(User user)
        {

        }

        async Task GetVDEW()
        {
            _users = new List<User>();
            var users = await UserService.PostAsync();
            _users = JsonConvert.DeserializeObject<List<User>>(users.Result.Items?.ToString() ?? string.Empty);
        }

        protected override async Task OnInitializedAsync()
        {
            await GetVDEW();
        }
    }
}
