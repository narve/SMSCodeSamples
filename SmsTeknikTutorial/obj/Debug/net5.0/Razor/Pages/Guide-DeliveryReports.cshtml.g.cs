#pragma checksum "C:\Users\tomas\source\Workspaces\Spiff\SmsTeknikTutorial\SmsTeknikTutorial\Pages\Guide-DeliveryReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13cf47461fbeda05e83fbd500950e30550d56526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SmsTeknikTutorial.Pages.Pages_Guide_DeliveryReports), @"mvc.1.0.razor-page", @"/Pages/Guide-DeliveryReports.cshtml")]
namespace SmsTeknikTutorial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tomas\source\Workspaces\Spiff\SmsTeknikTutorial\SmsTeknikTutorial\Pages\_ViewImports.cshtml"
using SmsTeknikTutorial;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13cf47461fbeda05e83fbd500950e30550d56526", @"/Pages/Guide-DeliveryReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a3934d9e7d7864b525e5c0edd030f09cd961cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Guide_DeliveryReports : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Guide-HttpGetWrapper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Guide-WS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/CodeExamples", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Guide-XmlHttp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tomas\source\Workspaces\Spiff\SmsTeknikTutorial\SmsTeknikTutorial\Pages\Guide-DeliveryReports.cshtml"
  
    ViewData["Title"] = "Leveranserapporter";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n\r\n    \r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13cf47461fbeda05e83fbd500950e30550d565265265", async() => {
                WriteLiteral("Veiledning");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Leveranserapporter</li>
        </ol>
    </nav>

    <h1>Leveranserapporter</h1>


    <p>Plattformen inneholder metoder for å få leveranserapporter, det vil si status om meldingen fra den blir sendt frem til den når mottaker eller av ulike årsaker har feilet.</p>
    <p>Statusene dels inn i to typer: endelige og midlertidige. En endelig status er at meldingen feilet eller er mottatt på brukerens enhet. En midlertidig status er oppdatering undervegs, som at meldingen er lagt på kø og blir sendt senere. For alle midlertidige statuser vil det komme en endelig status, men de midlertidige meldingene varierer fra de ulike operatørene. I de fleste tilfellene bryr vi oss kun om endelige status, og frem til slik status foreligger anser vi meldingen som undervegs.</p>
    <p>For meldinger som har feilet vil leveranserapport inneholde årsak til feil. Feilmeldingene kan variere mellom operatørene, men vil typisk være ugyldig nummer, ugyl");
            WriteLiteral(@"dig avsender, blokkert, ukjent mottaker, etc.</p>

    <h5>Push eller pull</h5>
    <p>Leveransestatus kan enten oppdrives som push eller pull. Push vil si at statusrapporter blir sendt til oss (som http callback, e-post, etc.) når status har endret seg, mens pull vil si at vi må kalle et endepunkt for å motta gjeldende status.</p>
    <p>Om man ønsker å benytte push eller pull må vurderes i hvert enkelt tilfelle. Generelt sett bør man bruke push dersom man har behov for oppdatering av status så fort den foreligger. Derimot dersom status ikke er tidskritisk, og man kun trenger f.eks. oppdatering noen få ganger i døgnet, vil man kunne forespørre status på alle SMS som er under leveranse. Pull-metoden har nemlig mulighet for å kunne spørre om status til flere SMS samtidig ved oppgi SMSID, i motsetning til push som sender en oppdatering per SMS.</p>

    <h5>Push</h5>
    <p>Push vil si at statusoppdatering blir sendt til oss fortløpende som status endrer seg. Fordelen med denne metoden er at man får umid");
            WriteLiteral(@"delbar oppdatering, og det vil være en trigger for videre prosessering i systemet.</p>
    <p>Konfigurasjon av push melding konfigureres ved utsendelse av SMS. Metodene for konfigurasjon av leveranserapporter kan variere noe for de ulike grensesnittene, men prinsippet er det samme. Se underkapitlene for de ulike grensesnittene for mer informasjon om hvordan leveranserapporter konfigureres.</p>
    <p>Push-leveranserapporter er ikke støttet i ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13cf47461fbeda05e83fbd500950e30550d565268983", async() => {
                WriteLiteral("HTTP Get Wrapper");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" eller i metoden <i>SendSMSSingle</i> i ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13cf47461fbeda05e83fbd500950e30550d5652610182", async() => {
                WriteLiteral("Web Service");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@".</p>
    <p>Man kan velge mellom følgende typer push meldinger:</p>
    <ol start=""0"">
        <li><strong>Ingen</strong> – Ingen push melding vil bli sendt. Velg dette dersom du ikke trenger leveranserapporter eller ønsker å benytte pull.</li>
        <li><strong>E-mail</strong> – Meldingen sendes til oppgitte e-post.</li>
        <li><strong>Http Get</strong> – Verdiene sendes som query string parameter til oppgitte URL, altså at verdiene legges inn i URL men at forespørselen ellers er blank.</li>
        <li><strong>Http Post</strong> – Verdiene sendes som form data til oppgitte URL.</li>
        <li><strong>Http XML</strong> – Verdiene sendes til oppgitte URL på XML format. Dette er det samme XML format som ved pull.</li>
    </ol>

    <p>Type push varsling angis i parameteren <i>deliverystatustype</i>, mens e-postadresse (dersom valg 1) eller URL (dersom valg 2-4) angis i parameteren <i>deliverystatusaddress</i>.</p>

    <div class=""alert alert-secondary"" role=""alert"">
        <h5 class=""");
            WriteLiteral(@"alert-heading"">Eksempel</h5>
        <p>Vi ønsker å motta leveranserapporter som Http Get (valg 2) som sendes til URL https://example.com/test.aspx </p>

        <p>I dette eksemplet bruker vi XML Post til å sende SMS, men prinsippet er tilsvarende for de andre grensesnittene.</p>

        <hr />

<pre class=""pre-scrollable""><code>
<span style='color:#004a43; '>&lt;?</span><span style='color:#800000; font-weight:bold; '>xml</span><span style='color:#004a43; '> </span><span style='color:#074726; '>version</span><span style='color:#808030; '>=</span><span style='color:#800000; '>""</span><span style='color:#7d0045; '>1.0</span><span style='color:#800000; '>""</span><span style='color:#004a43; '> </span><span style='color:#074726; '>encoding</span><span style='color:#808030; '>=</span><span style='color:#800000; '>""</span><span style='color:#0000e6; '>utf-8</span><span style='color:#800000; '>""</span><span style='color:#004a43; '> </span><span style='color:#004a43; '>?></span>
<span style='color:#a65700; ");
            WriteLiteral(@"'>&lt;</span><span style='color:#5f5035; '>sms-teknik</span><span style='color:#a65700; '>></span>
    <span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>udmessage</span><span style='color:#a65700; '>></span><span style='color:#004a43; '>&lt;![CDATA[</span>The quick brown fox<span style='color:#004a43; '>]]&gt;</span><span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>udmessage</span><span style='color:#a65700; '>></span>
    <span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smssender</span><span style='color:#a65700; '>></span>Test<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smssender</span><span style='color:#a65700; '>></span>
    <span style=""font-weight:bold;""><span style='color:#a65700;'>&lt;</span><span style='color:#5f5035; '>deliverystatustype</span><span style='color:#a65700; '>></span>2<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>deliverystatustype</span><span style='color:#a65700; ");
            WriteLiteral(@"'>></span></span>
    <span style=""font-weight:bold;""><span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>deliverystatusaddress</span><span style='color:#a65700; '>></span>https://example.com/test.aspx<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>deliverystatusaddress</span><span style='color:#a65700; '>></span></span>
    <span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>items</span><span style='color:#a65700; '>></span>
        <span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>recipient</span><span style='color:#a65700; '>></span>
            <span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>nr</span><span style='color:#a65700; '>></span>+4790000000<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>nr</span><span style='color:#a65700; '>></span>
        <span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>recipient</span><span style='color:#a65700; '>></spa");
            WriteLiteral(@"n>
    <span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>items</span><span style='color:#a65700; '>></span>
<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>sms-teknik</span><span style='color:#a65700; '>></span>
</code></pre>

        <hr />
        <p>For å motta verdiene på vårt oppgitte endepunkt leses bare query string (dersom <i>HTTP GET</i>) og form data (dersom <i>HTTP POST</i>) ut på vanlig måte.</p>

        <p>Slik leser vi ut verdien <i>smsid</i> for <i>HTTP Get</i>:</p>

        <code>
            <pre style='color:#000000;'><span style='color:#800000; font-weight:bold; '>string</span> id <span style='color:#808030; '>=</span> Request<span style='color:#808030; '>.</span>QueryString<span style='color:#808030; '>[</span><span style='color:#800000; '>""</span><span style='color:#0000e6; '>ref</span><span style='color:#800000; '>""</span><span style='color:#808030; '>]</span><span style='color:#800080; '>;</span></pre>
        </code>

       ");
            WriteLiteral(@" <p>Slik leser vi ut verdien <i>smsid</i> for <i>HTTP Post</i>:</p>

        <code>
            <pre style='color:#000000;'><span style='color:#800000; font-weight:bold; '>string</span> id <span style='color:#808030; '>=</span> Request<span style='color:#808030; '>.</span>Form<span style='color:#808030; '>[</span><span style='color:#800000; '>""</span><span style='color:#0000e6; '>ref</span><span style='color:#800000; '>""</span><span style='color:#808030; '>]</span><span style='color:#800080; '>;</span></pre>
        </code>

        <p>Tilgjengelige verdier vil være <i>ref</i> (smsid), <i>nr</i> (mobilnummer), <i>state</i> (status), <i>text</i> (innhold i tekstmeldingen), <i>datetime</i> (tidspukt for leveranse), <i>customid</i> (intern referanse dersom oppgitt ved utsendelse) og <i>smsparts</i> (antall meldingsdeler).</p>

        <hr />
        <p>Dersom det benyttes metoden <i>HTTP XML</i> vil følgende XML data bli sent til oppgitte endepunkt:</p>


        <code>
<pre style='color:#000000;'>");
            WriteLiteral(@"
<span style='color:#808030; '>&lt;</span>sms<span style='color:#808030; '>></span>
	<span style='color:#808030; '>&lt;</span>nr<span style='color:#808030; '>></span><span style='color:#808030; '>+</span><span style='color:#008c00; '>4790000000</span><span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span>nr<span style='color:#808030; '>></span>
	<span style='color:#808030; '>&lt;</span><span style='color:#800000; font-weight:bold; '>ref</span><span style='color:#808030; '>></span><span style='color:#008c00; '>1950940234</span><span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span><span style='color:#800000; font-weight:bold; '>ref</span><span style='color:#808030; '>></span>
	<span style='color:#808030; '>&lt;</span>state<span style='color:#808030; '>></span>DELIVRD<span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span>state<span style='color:#808030; '>></span>
	<span style='color:#808030; '>&lt;</span>text<span style='color:#808030;");
            WriteLiteral(@" '>></span>The quick brown fox<span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span>text<span style='color:#808030; '>></span>
	<span style='color:#808030; '>&lt;</span>datetime<span style='color:#808030; '>></span><span style='color:#008c00; '>2021</span><span style='color:#808030; '>-</span><span style='color:#008c00; '>08</span><span style='color:#808030; '>-</span><span style='color:#008c00; '>08</span> <span style='color:#008c00; '>13</span><span style='color:#808030; '>:</span><span style='color:#008c00; '>51</span><span style='color:#808030; '>:</span><span style='color:#008c00; '>13</span><span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span>datetime<span style='color:#808030; '>></span>
	<span style='color:#808030; '>&lt;</span>customid<span style='color:#808030; '>></span><span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span>customid<span style='color:#808030; '>></span>
	<span style='color:#808030; '>&lt;</span>smsparts<s");
            WriteLiteral(@"pan style='color:#808030; '>></span><span style='color:#008c00; '>1</span><span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span>smsparts<span style='color:#808030; '>></span>
<span style='color:#808030; '>&lt;</span><span style='color:#808030; '>/</span>sms<span style='color:#808030; '>></span>
</pre>
<!--Created using ToHtml.com on 2021-08-09 14:01:09 UTC -->
        </code>

    </div>
    

    <h5>Pull</h5>
    <p>Pull vil si å kalle et endepunkt for å få oppdatert informasjon om leveringsstatus på angitte meldinger (smsid).</p>

    <p>Operasjonen er tilgjengelig for grensesnittet Web Service (SOAP 1.1, SOAP 1.2, HTTP GET og HTTP Post), og også for grensesnittet XML HTTP Post. For begge grensesnittene får man mulighet til å sjekke status for flere meldinger samtidig.</p>

    <div class=""alert alert-info"">
        <h5 class=""alert-heading"">Legg til Web Service</h5>
        <p>For å legge inn Web Service benyttes følgende URL: <a href=""https://api.smsteknik.se/util");
            WriteLiteral(@"ities/Utilities.asmx"" target=""_blank"">https://api.smsteknik.se/utilities/Utilities.asmx</a>. Man legger da inn referanse til <i>Utilities</i> servicen som også inneholder følgende funksjoner:</p>
        <ul>
            <li>CheckCredits - Sjekk hvor mange credits som er igjen på kontoen</li>
            <li>DeleteQueuedSms - Slett SMS som er lagt i køen for fremtidig utsendelse</li>
            <li>RequestMSISDN - Forespør innkommende Msisdn.</li>
        </ul>
    </div>

     <div class=""alert alert-secondary"" role=""alert"">
        <h5 class=""alert-heading"">Eksempel</h5>
        <p>I eksempelet under bruker vi Web Service grensesnittet til å hente ut statusmelding for to meldinger samtidig.</p>
        <hr />

         <code>
<pre class=""pre-scrollable"" style='color:#000000;'><span style='color:#800000; font-weight:bold; '>var</span> service <span style='color:#808030; '>=</span> <span style='color:#800000; font-weight:bold; '>new</span> se<span style='color:#808030; '>.</span>smsteknik<span ");
            WriteLiteral(@"style='color:#808030; '>.</span>utilities<span style='color:#808030; '>.</span>UtilitiesSoapClient<span style='color:#808030; '>(</span>se<span style='color:#808030; '>.</span>smsteknik<span style='color:#808030; '>.</span>utilities<span style='color:#808030; '>.</span>UtilitiesSoapClient<span style='color:#808030; '>.</span>EndpointConfiguration<span style='color:#808030; '>.</span>UtilitiesSoap12<span style='color:#808030; '>)</span><span style='color:#800080; '>;</span>
<span style='color:#800000; font-weight:bold; '>var</span> result <span style='color:#808030; '>=</span> await service<span style='color:#808030; '>.</span>RequestStatusAsync<span style='color:#808030; '>(</span>id<span style='color:#808030; '>,</span> user<span style='color:#808030; '>,</span> pass<span style='color:#808030; '>,</span> <span style='color:#800000; font-weight:bold; '>new</span> <span style='color:#800000; font-weight:bold; '>string</span><span style='color:#808030; '>[</span><span style='color:#808030; '>]</span> <span sty");
            WriteLiteral(@"le='color:#800080; '>{</span> <span style='color:#800000; '>""</span><span style='color:#0000e6; '>1950940234</span><span style='color:#800000; '>""</span><span style='color:#808030; '>,</span> <span style='color:#800000; '>""</span><span style='color:#0000e6; '>1950940235</span><span style='color:#800000; '>""</span> <span style='color:#800080; '>}</span><span style='color:#808030; '>)</span><span style='color:#800080; '>;</span>
</pre>
         </code>


    <hr />
    Respons:

    <code>
<pre class=""pre-scrollable"" style='color:#000000;'><span style='color:#004a43; '>&lt;?</span><span style='color:#800000; font-weight:bold; '>xml</span><span style='color:#004a43; '> </span><span style='color:#074726; '>version</span><span style='color:#808030; '>=</span><span style='color:#800000; '>""</span><span style='color:#7d0045; '>1.0</span><span style='color:#800000; '>""</span><span style='color:#004a43; '> </span><span style='color:#074726; '>encoding</span><span style='color:#808030; '>=</span><span style='c");
            WriteLiteral(@"olor:#800000; '>""</span><span style='color:#0000e6; '>UTF-8</span><span style='color:#800000; '>""</span><span style='color:#004a43; '> </span><span style='color:#004a43; '>?></span>
<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smsteknik</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>1950940234<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>DELIVRD<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>donedat");
            WriteLiteral(@"e</span><span style='color:#a65700; '>></span>2021-08-08 13:51:13<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>donedate</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>1950940235<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>BLOCKED<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>d");
            WriteLiteral(@"onedate</span><span style='color:#a65700; '>></span>2021-08-08 13:51:27<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>donedate</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsteknik</span><span style='color:#a65700; '>></span>
</pre>
    </code>

    </div>

    <div class=""alert alert-secondary"" role=""alert"">
        <h5 class=""alert-heading"">Eksempel</h5>
        <p>I eksempelet under bruker vi grensesnittet <i>XML over HTTP</i> for å hente ut leveringsstatus for to meldinger. Eksemplet viser XML som postes til endepunktet <a href=""https://api.smsteknik.se/utilities/getstatus/"" target=""_blank"">https://api.smsteknik.se/utilities/getstatus/</a></p>
        <hr />
        Forespørsel:

        <code>
<pre class=""pre-scrollable"" style='color:#000000;'><span style='color:#004a43; '");
            WriteLiteral(@">&lt;?</span><span style='color:#800000; font-weight:bold; '>xml</span><span style='color:#004a43; '> </span><span style='color:#074726; '>version</span><span style='color:#808030; '>=</span><span style='color:#800000; '>""</span><span style='color:#7d0045; '>1.0</span><span style='color:#800000; '>""</span><span style='color:#004a43; '> </span><span style='color:#004a43; '>?></span>
<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>sms-teknik</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>1950940234<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>1950940235<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>");
            WriteLiteral(@"
<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>sms-teknik</span><span style='color:#a65700; '>></span>
</pre>
<!--Created using ToHtml.com on 2021-08-09 13:30:04 UTC -->
        </code>
    <hr />
    Respons:

    <code>
<pre class=""pre-scrollable"" style='color:#000000;'><span style='color:#004a43; '>&lt;?</span><span style='color:#800000; font-weight:bold; '>xml</span><span style='color:#004a43; '> </span><span style='color:#074726; '>version</span><span style='color:#808030; '>=</span><span style='color:#800000; '>""</span><span style='color:#7d0045; '>1.0</span><span style='color:#800000; '>""</span><span style='color:#004a43; '> </span><span style='color:#074726; '>encoding</span><span style='color:#808030; '>=</span><span style='color:#800000; '>""</span><span style='color:#0000e6; '>UTF-8</span><span style='color:#800000; '>""</span><span style='color:#004a43; '> </span><span style='color:#004a43; '>?></span>
<span style='color:#a65700; '>&lt;</span><span style='color:#5");
            WriteLiteral(@"f5035; '>smsteknik</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>1950940234<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>DELIVRD<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>donedate</span><span style='color:#a65700; '>></span>2021-08-08 13:51:13<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>donedate</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;/</span><span styl");
            WriteLiteral(@"e='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>1950940235<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsid</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>BLOCKED<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>state</span><span style='color:#a65700; '>></span>
		<span style='color:#a65700; '>&lt;</span><span style='color:#5f5035; '>donedate</span><span style='color:#a65700; '>></span>2021-08-08 13:51:27<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>donedate</span><span style='color:#a65700; '>></span>
	<span style='color:#a65700; '>&lt;/</span><spa");
            WriteLiteral(@"n style='color:#5f5035; '>item</span><span style='color:#a65700; '>></span>
<span style='color:#a65700; '>&lt;/</span><span style='color:#5f5035; '>smsteknik</span><span style='color:#a65700; '>></span>
</pre>
    </code>

     
    </div>

    
    <h2>Kodeeksempler</h2>
    <p>Under ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13cf47461fbeda05e83fbd500950e30550d5652631766", async() => {
                WriteLiteral("Kodeeksempler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" kan du laste ned fungerende kodeeksempler på hvordan man setter opp en push utsendelse av leveranserapporter for grensesnittet ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13cf47461fbeda05e83fbd500950e30550d5652633051", async() => {
                WriteLiteral("Web Service");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" og ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13cf47461fbeda05e83fbd500950e30550d5652634210", async() => {
                WriteLiteral("XML over HTTP");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(". I tillegg kan man se eksempler for bruk av pull for de grensesnittene dette er støttet.</p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13cf47461fbeda05e83fbd500950e30550d5652635472", async() => {
                WriteLiteral("Gå til kodeeksempler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmsTeknikTutorial.Pages.Guide_DeliveryReportsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SmsTeknikTutorial.Pages.Guide_DeliveryReportsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SmsTeknikTutorial.Pages.Guide_DeliveryReportsModel>)PageContext?.ViewData;
        public SmsTeknikTutorial.Pages.Guide_DeliveryReportsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
