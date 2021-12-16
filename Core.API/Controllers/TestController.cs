using Core.Common;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core.API.Controllers;

/// <summary>
/// Test 模块
/// </summary>
#if(simpleAuthorization)
[Authorize]
#elif (roleBased)
[Authorize(Roles = "Admin")]
[Authorize(Policy = "AdminRole")]
#elif (policyBased)
[Authorize(Policy = "Permission")]
#endif
[Route("api/[controller]")]
[ApiController]
public class TestController : BaseController
{
    /// <summary>
    /// 授权测试
    /// </summary>
    /// <returns></returns>
    [HttpGet("Index")]
    public async Task<ApiResult> Add()
    {
        return SUCCESS(data: "成功");
    }
}

//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='金' and account = '68557558';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='張哲偉' and account = '97679388';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='金益斌' and account = '92876495';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Ng' and account = '96098230';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='羅金慶' and account = '94588715';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='潘偉良' and account = '91621878';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳水泉' and account = '91378712';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='麥慶桃' and account = '91328487';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='郭稜佑' and account = '97312873';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='葉偉基' and account = '98328844';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黎頌豪' and account = '94372198';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='譚' and account = '98790289';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='LEE' and account = '91033209';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='wong' and account = '92639871';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='許' and account = '67400050';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='王' and account = '94123879';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黃' and account = '59894043';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Lo' and account = '95272629';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Chow' and account = '53360233';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='鄭' and account = '94867822';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='TSE' and account = '92151731';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Chan' and account = '62783199';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='楊' and account = '51134270';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黃' and account = '92183550';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Hon' and account = '55401220';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='So' and account = '54345456';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='王' and account = '64069860';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='wong' and account = '97672395';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='曾' and account = '92743883';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='張' and account = '94932188';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='羅' and account = '98635763';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='wong' and account = '91212763';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='law' and account = '61978922';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '92880239';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='郭' and account = '97918677';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '90249128';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='莫' and account = '97872586';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='關' and account = '95873045';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='卜 卜 盧' and account = '68087868';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='盧' and account = '93426644';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黄' and account = '95777885';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Cheung' and account = '63349578';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '96468373';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Leung' and account = '64279830';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Chan' and account = '60788768';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Lam' and account = '93083816';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='cheung' and account = '61013889';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='曾' and account = '92076898';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁' and account = '64966318';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='彭' and account = '96518881';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='彭' and account = '93053899';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Kong' and account = '63455303';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Wong' and account = '96406982';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='麥' and account = '90217288';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='翟' and account = '93314148';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='何' and account = '94227938';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Lau' and account = '51162467';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '94922588';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='So' and account = '62309547';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Kong' and account = '66366368';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='lam' and account = '65139040';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林友敬' and account = '94930207';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '97465789';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Ho' and account = '63808840';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '94537449';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='yeung' and account = '94885861';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '91444313';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Wong' and account = '52666816';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='譚' and account = '54454080';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='何' and account = '94366325';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Wong' and account = '60926735';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='twag' and account = '92519265';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '90139679';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='馬' and account = '90111019';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='law' and account = '93259783';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='萬春明' and account = '60912886';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黎灼炽' and account = '91235090';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='鄭振邦' and account = '60306896';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='鍾漢榮' and account = '90890998';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '52607979';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='鄺敢鴻' and account = '91734290';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '60905036';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '93493883';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '53114939';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='張軍凱' and account = '54082301';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳政' and account = '51299241';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳夢平' and account = '93469983';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='蔡錦基' and account = '90877367';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='麥俊誠' and account = '62734991';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='張朗軒' and account = '62585796';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳學禧' and account = '61104053';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='粱' and account = '96766238';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='chanhoiyuen' and account = '68466158';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='HUI Wai chi' and account = '91811027';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '92656995';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='law' and account = '62856280';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='吳' and account = '95554389';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='余' and account = '96597550';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Hung' and account = '94616579';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '63490021';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '59890712';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '63113526';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '67711751';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='許' and account = '91753728';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='羅' and account = '98805761';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='yip' and account = '67381907';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='吳景權' and account = '68082091';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '92738698';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='張1' and account = '90135562';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='洪' and account = '62207189';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '96013612';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='余' and account = '60738336';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陸' and account = '90829198';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='程' and account = '61763603';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Chan Hung Pui' and account = '60154590';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Ko Yiu Cho' and account = '91677703';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='楊雲' and account = '90813793';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='廖玉明' and account = '90530352';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='曹' and account = '90172889';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='劉' and account = '68879798';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='廖仲斌' and account = '65009821';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='chow' and account = '92114259';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳漢榮' and account = '91752075';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='張志輝' and account = '61993573';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林國' and account = '59884814';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Andywong' and account = '93718190';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='嚴' and account = '61992339';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '93831711';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='蔡' and account = '93820596';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='冼' and account = '97394619';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='袁' and account = '94307861';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁' and account = '90395096';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Song' and account = '51105462';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '62245138';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Li' and account = '96208710';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='胡' and account = '90126299';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Chan' and account = '94587223';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='chan' and account = '62939227';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '51367850';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='羅' and account = '91701698';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳鋭新' and account = '90819077';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='莫' and account = '96827823';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='許_' and account = '91714382';
//"UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='…
//葉' and account ='94572720';"
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='man' and account = '60545219';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='文' and account = '90186268';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='郭' and account = '94835375';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='呂' and account = '97979912';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '53164872';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黃' and account = '52119237';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='善' and account = '90102817';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='余' and account = '92276140';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='張' and account = '60781333';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='傅' and account = '56319643';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁' and account = '63933943';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='許' and account = '91363813';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '90161810';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '97458350';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Cheung' and account = '64317872';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='譚' and account = '97554800';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='楊' and account = '95253778';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='呂' and account = '96219132';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '55995233';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Law' and account = '90641998';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Yu' and account = '60998765';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='韓' and account = '92999324';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁' and account = '94581161';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁' and account = '90997641';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='伍國良' and account = '95146382';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='lung' and account = '94173230';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李' and account = '65671771';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='何思源' and account = '66888833';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁' and account = '53939018';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '90157986';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '98403828';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='lee' and account = '54091781';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黎錦榮' and account = '90593290';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='蘇國湛' and account = '62831121';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Lin' and account = '91459419';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='suen' and account = '61718617';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='文' and account = '62244473';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='David' and account = '93380182';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='王' and account = '91328385';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='王' and account = '54671718';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='丁' and account = '98790678';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '98632949';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黎生' and account = '94910596';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁' and account = '94292081';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '97785771';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Ma hon ping' and account = '94370237';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='文' and account = '92381182';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳先生' and account = '55775162';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林先生' and account = '62003093';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳先生' and account = '93514167';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='劉' and account = '60285738';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李先生' and account = '94913655';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='王' and account = '90369433';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='顏玉梅' and account = '96138505';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='曾耀民' and account = '64182012';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁詠粧' and account = '55786288';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='曾国良' and account = '63016808';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='植國星' and account = '90486678';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='伍會煌' and account = '97115540';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='盧永昌' and account = '94648049';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '92391707';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='朱麗樺' and account = '98226882';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='劉逢春' and account = '66062133';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='蔡志碧' and account = '62189680';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='潘粟' and account = '15818890633';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='劉逢春' and account = '93674630';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='刘逸才' and account = '96349243';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='潘光培' and account = '53737538';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='赖廣財' and account = '97132535';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁志威' and account = '96257027';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳漢燊' and account = '95120753';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李進文' and account = '63322690';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='譚辨諱' and account = '62541031';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='曾慶祥' and account = '96350356';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='鄭建昌' and account = '62235656';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳錦明' and account = '62196268';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='袁' and account = '53009836';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='shek' and account = '66091125';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳' and account = '60767280';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='孫漢強' and account = '98767433';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Tw c' and account = '96651332';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='ng' and account = '92107045';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='柯' and account = '90120354';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='chan wing kin' and account = '96676361';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='羅生' and account = '93109598';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='罗生' and account = '92752058';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林樹聰' and account = '92890336';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='leung' and account = '96389008';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Lo' and account = '56128756';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='譚' and account = '62002140';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='lam' and account = '54021515';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='chong' and account = '60633379';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='TSE' and account = '63377162';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='容' and account = '96001034';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='譚' and account = '92840270';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='cheung' and account = '96116694';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林' and account = '60111478';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='候' and account = '91756651';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Mok' and account = '62557862';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Chan' and account = '91335885';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='吳偉衡' and account = '90993673';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='lau chi yung' and account = '90728928';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Kwok' and account = '93370302';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='chan' and account = '93832349';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='周' and account = '96737531';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='光' and account = '90938382';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='王家荣' and account = '93256177';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黃文傑 (2837)' and account = '68449509';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黃城濱' and account = '62140867';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黃志堅 (2839)' and account = '60823473';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='林浩賢 (2831)' and account = '54059081';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Kinlo (2836)' and account = '96000559';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='楊志林' and account = '96096294';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Jeff (2833)' and account = '52209609';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Wong Chak Hei' and account = '67528627';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='鍾海富' and account = '98838054';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='李俊輝 (2827)' and account = '98389327';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黃國榮 (2834)' and account = '59883373';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='梁峻標' and account = '94291056';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='施學民 (2829)' and account = '54012358';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='陳林烽 (2832)' and account = '68483817';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='鄧永和 (2838)' and account = '91023678';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='黄子權 (2835)' and account = '54202226';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Carrey蔣 (2830)' and account = '93849519';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='司徒子傑 (2828)' and account = '98067764';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='Edmond (2826)' and account = '90234720';
//UPDATE dt_account SET account_groups = SUBSTRING(account_groups,1,LEN(account_groups) - 1) + ',"83"]' WHERE name='馮1' and account = '93873534';
