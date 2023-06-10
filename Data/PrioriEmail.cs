namespace PRIORI_SERVICES_WEB.Data.Model;

public record PrioriVerificationEmail(string Titulo, string Motivo, int DigitosCodigo)
{
    protected static string GenerateAuthenticationID(int digits = 6) => new Random().Next(0, (int)Math.Pow(10, digits)).ToString($"D{digits}");

    public string Generate() => $@"
<body style=""background-color: #f4f4f4; margin: 0 !important; padding: 0 !important;"">
    <div style=""display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: 'Lato', Helvetica, Arial,sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;"">
        {Titulo}
    </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
        <!-- LOGO -->
        <tr>
            <td bgcolor=""#5846f9"" align=""center""><table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                <tr>
                    <td align=""center"" valign=""top"" style=""padding: 40px 10px 40px 10px;""> 
                    </td>
                </tr>
            </td>
        </tr>
        <tr>
            <td bgcolor=""#5846f9"" align=""center"" style=""padding: 0px 10px 0px 10px;"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                    <tr>
                        <td bgcolor=""#ffffff"" align=""center"" valign=""top"" style=""padding: 40px 20px 20px 20px; border-radius: 4px 4px 0px 0px;color: #111111; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; letter-spacing:4px; line-height: 48px;"">
                            <h1 style=""font-size: 48px; font-weight: 400; margin: 2;"">
                                <i>PRIORI</i>
                            </h1>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor=""#f4f4f4"" align=""center"" style=""padding: 0px 10px 0px 10px;"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"" style=""padding: 20px 30px 40px 30px; color: #666666; font-family: 'Lato', Helvetica,Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;"">
                            <p style=""margin: 0;"">{Motivo}</p>
                            <p style=""text-align: center;"">Código de verificação:</p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"">
                            <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                <tr>
                                    <td bgcolor=""#ffffff"" align=""center"" style=""padding: 0px 30px 60px 30px;"">
                                        <table border=""0"" cellspacing=""0"" cellpadding=""0""><tr><td align=""center"" style=""border-radius: 3px;"" bgcolor=""#5846f9"">{GenerateAuthenticationID(DigitosCodigo)}
                                    </td>
                                </tr>
                            </table>
                        </td>    
                    </tr>
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"" style=""padding: 0px 30px 20px 30px; color: #666666; font-family: 'Lato', Helvetica,Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;"">
                            <p style=""margin: 0;"">Se você tiver alguma dúvida, basta responder a este e-mail &mdash;teremos prazer em ajudar.</p></td></tr><tr><td bgcolor=""#ffffff"" align=""left"" style=""padding: 0px 30px 40px 30px; border-radius: 0px 0px 4px 4px; color: #666666;font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;"">
                            <p style=""margin: 0;"">Cordialmente,<br>Equipe <i>Priori</i></p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</body>";
}
