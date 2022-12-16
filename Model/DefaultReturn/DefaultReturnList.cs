using System.Net;

namespace SheetPlay.Lib.Model.DefaultReturn
{
    public class DefaultReturnList<T>
        where T : class
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public IEnumerable<T>? Value { get; set; }
        public string Message { get; set; }

        public DefaultReturnList()
        {
            this.HttpStatusCode = HttpStatusCode.BadRequest;
            this.Value = default;
            this.Message = string.Empty;
        }
    }
}
