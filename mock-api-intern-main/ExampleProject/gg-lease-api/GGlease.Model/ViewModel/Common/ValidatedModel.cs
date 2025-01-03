namespace GGlease.Model.ViewModel
{
    public class ValidatedModel<T> : ValidatedModel
    {
        public ValidatedModel(string error) : base(error) { }

        public ValidatedModel(T data)
        {
            Data = data;
        }

        public T? Data { get; set; }

    }

    public class ValidatedModel
    {
        public ValidatedModel(string error)
        {
            Error = new ErrorModel(error);
        }

        public ValidatedModel()
        {

        }

        public ErrorModel? Error { get; set; }
        public bool Success => Error == null;
    }
}