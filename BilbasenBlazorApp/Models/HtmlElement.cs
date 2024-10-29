namespace BilbasenBlazorApp.Models
{
    public class HtmlElement
    {
        private readonly string elementType;
        private readonly List<HtmlElement> children = new List<HtmlElement>();

        public readonly List<string> classList = new List<string>();
        public string id = "";
        public string innerHTML = "";

        public HtmlElement(string type)
        {
            elementType = type.ToLower();
        }

        public void appendChild(HtmlElement child)
        {
            children.Add(child);
        }

        public string Render()
        {
            string entry = elementType;
            if (classList.Count() > 0)
            {
                string classes = String.Join(" ", classList.ToArray());
                entry += $" class=\"{classes}\"";
            }

            string inner = innerHTML;

            if (children.Count() > 0)
            {
                foreach (HtmlElement element in children)
                {
                    inner += element.Render();
                }
            }

            return $"<{entry}>{inner}</{elementType}>";
        }
    }
}
