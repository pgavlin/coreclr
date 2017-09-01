using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_relinstftn__il_relinstftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relinstftn__il_relinstftn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relinstftn\\_il_relinstftn.cmd");
        }
    }
}
