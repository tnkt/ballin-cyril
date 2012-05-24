using System.Collections.Generic;
using System.Web.Mvc;
using iSore.Models;

namespace iSore.Views
{
  public static class HtmlHelperExtensions
  {
    public static MvcHtmlString Cards(this HtmlHelper helper, IEnumerable<Card> cards)
    {
      return new MvcHtmlString("NOT IMPLEMENTED");
    }
    public static MvcHtmlString PageIndexes(this HtmlHelper helper, IEnumerable<Card> cards)
    {
      return new MvcHtmlString("NOT IMPLEMENTED");
    }
  }
}