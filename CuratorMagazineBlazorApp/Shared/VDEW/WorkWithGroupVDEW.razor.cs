using CuratorMagazineBlazorApp.Data.Services;
using CuratorMagazineWebAPI.Models.Entities.Domains;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Group = CuratorMagazineWebAPI.Models.Entities.Domains.Group;

namespace CuratorMagazineBlazorApp.Shared.VDEW
{
    public partial class WorkWithGroupVDEW
    {
        [Parameter]
        public User? CurrentUser { get; set; }

        [Inject]
        public UserService? UserService { get; set; }

        [Inject]
        public GroupService? GroupService { get; set; }

        private List<Group>? Groups { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var ret = await GroupService?.PostAsync()!;
            Groups = JsonConvert.DeserializeObject<List<CuratorMagazineWebAPI.Models.Entities.Domains.Group>>(ret.Result.Items?.ToString() ?? string.Empty);
        }

        void DeleteGroup(Group group)
        {

        }

        void AddGroup(Group group)
        {

        }
        public async Task GetGroups()
        {
            //Groups = new List<Group>();
            //var groups = await UserService.PostAsync();
            //Groups = JsonConvert.DeserializeObject<List<Group>>(groups.Result.Items?.ToString() ?? string.Empty);
        }
    }
}
