using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relcastclass_calli__il_relcastclass_calli_
    {
        [Fact]
        public void _casts_coverage__il_relcastclass_calli__il_relcastclass_calli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relcastclass_calli\\_il_relcastclass_calli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
