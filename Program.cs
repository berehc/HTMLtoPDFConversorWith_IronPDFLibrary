using IronPdf;
using IronPdf.Rendering;

IronPdf.License.LicenseKey = "LICENSE-KEY";

string ResourcePath = @"HTML-files/source";
string DestinationDirectory = @"destination/directory";

Random Rand = new Random(Math.Abs((int)DateTime.Now.Ticks));

var Renderer = new ChromePdfRenderer(); // Instantiates Chrome Renderer

var resultPath = @$"{DestinationDirectory}\ResultPDF-{Rand.Next()}.pdf";

Renderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.A4;
Renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Portrait;

Renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;

var pdf = Renderer.RenderHtmlFileAsPdf($@"{ResourcePath}\*.html");

pdf.SaveAs(resultPath); // Saves our PdfDocument object as a PDF
