using CuratorMagazineBlazorApp.Data.Services;
using CuratorMagazineWebAPI.Models.Entities;
using CuratorMagazineWebAPI.Models.Entities.Domains;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;

namespace CuratorMagazineBlazorApp.Shared.VDEW
{
    public partial class WorkWithGroupVDEW
    {
        [Parameter]
        public User? CurrentUser { get; set; }

        [Inject]
        public UserService? UserService { get; set; }

        private List<Group>? _groups;

        void DeleteGroup(Group group)
        {

        }

        void AddGroup(Group group)
        {

        }
        public async void GetGroups()
        {
            _groups = new List<Group>();
            var groups = await UserService.PostAsync();
            _groups = JsonConvert.DeserializeObject<List<Group>>(groups.Result.Items?.ToString() ?? string.Empty);
        }
    }
}
