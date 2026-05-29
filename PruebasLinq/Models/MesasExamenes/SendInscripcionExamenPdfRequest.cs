namespace InstitutoServices.Models.MesasExamenes
{
    public class SendInscripcionExamenPdfRequest
    {
        public string PdfBase64 { get; set; } = string.Empty;
        public string FileName { get; set; } = "inscripcion-mesas-examenes.pdf";
    }
}
