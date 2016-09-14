using Nancy;
using CoreAllergies.Objects;

namespace CoreAllergies
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/response"] = _ =>
      {
        Allergies allergyScore = new Allergies(Request.Form["score"]);
        allergyScore.AllergyCalculater();
        return View["response.cshtml", allergyScore];
      };
    }
  }
}
