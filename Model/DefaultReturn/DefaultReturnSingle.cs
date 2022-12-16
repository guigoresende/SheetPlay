using System.Net;

namespace SheetPlay.Lib.Model.DefaultReturn
{
    public class DefaultReturnSingle<T>
        where T : class
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public T? Value { get; set; }
        public string Message { get; set; }

        public DefaultReturnSingle()
        {
            this.HttpStatusCode = HttpStatusCode.BadRequest;
            this.Value = default;
            this.Message = string.Empty;

        }

    }
}
