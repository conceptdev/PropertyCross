using Newtonsoft.Json.Linq;

namespace PropertyCross.Model
{
  public static class Util
  {
    public static int? ToNullableInt(this JToken token, string propertyName)
    {
	var value = token[propertyName].ToString();
	  
      return string.IsNullOrEmpty(value) ? (int?)null : int.Parse(value);
    }
  }
}
