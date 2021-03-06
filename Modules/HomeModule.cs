using Nancy;
using Inventory.Objects;
using System.Collections.Generic;

namespace Inventory
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object> {{"items", Item.GetAll()}, {"categories", Category.GetAll()}};
        return View["index.cshtml", model];
      };
    }
  }
}
