using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relinstftn__il_relinstftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relinstftn__il_relinstftn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relinstftn\\_il_relinstftn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
