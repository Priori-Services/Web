namespace PRIORI_SERVICES_WEB.Data.Model;
public enum ErrorMessageBoxDisplay {
    none,
    block
}
public class ErrorMessageBox {
    public string displaytype { get; set; } = ErrorMessageBoxDisplay.none.ToString();
    public string title { get; set; } = String.Empty;
    public string description {get;set;}= String.Empty;
}
public struct ErrorEntry {
    public bool is_error_valid;
    public string error_title;
    public string error_description;
    
}
