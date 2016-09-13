using Nancy;

namespace Anagrams
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {return View["index.cshtml"];};
    }
  }
}
