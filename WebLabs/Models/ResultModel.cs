namespace WebLabs.Models
{
    public class ResultModel { 
        public string Result { get; set; }

        public ResultModel(int num1, int num2, Operation op)
        {
            Result = op switch
            {
                Operation.Plus => $"{num1} + {num2} = {num1 + num2}",
                Operation.Minus => $"{num1} - {num2} = {num1 - num2}",
                Operation.Multiply => $"{num1} * {num2} = {num1 * num2}",
                Operation.Divide => num2 == 0 ? "Нельзя делить на ноль" : $"{num1} / {num2} = {num1 / num2}",
                _ => "Не удалось посчитать результат"
            };
        }
        public ResultModel(CalcModel model) : this(model.Num1, model.Num2, model.Operation) { }
    }
}
